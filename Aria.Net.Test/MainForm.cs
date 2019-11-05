using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aria.Net.Entities.Download;
using Humanizer;

namespace Aria.Net.Test
{
    public partial class MainForm : Form
    {
        internal AriaClient client;
        internal CancellationTokenSource cts;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        async void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.client != null)
            {
                await this.client.DisconnectAsync();
                this.client = null;
                this.btnConnect.Text = "Connect";
                this.tbEndPoint.Enabled = true;

                if (cts != null)
                {
                    cts.Cancel();
                    cts = null;
                }

                return;
            }

            if (!Uri.TryCreate(this.tbEndPoint.Text, UriKind.Absolute, out var uri))
            {
                MessageBox.Show("Invalid host:port");
                return;
            }

            btnConnect.Enabled = false;

            client = new AriaClient(new AriaConfiguration
            {
                Host = uri.Host,
                IsSecure = uri.Scheme.Contains("wss") || uri.Scheme.Contains("https"),
                Port = uri.IsDefaultPort ? 6800 : uri.Port,
                Token = string.Empty
            });

            this.btnConnect.Text = "Disconnect";
            await client.ConnectAsync();

            cts = new CancellationTokenSource();

            _ = Task.Run(this.UpdateStatsAsync, cts.Token);
            _ = Task.Run(this.GetCurrentDownloadsAsync, cts.Token);

            btnConnect.Enabled = true;
            this.tbEndPoint.Enabled = false;
        }

        async Task UpdateStatsAsync()
        {
            while (client != null)
            {
                var stats = await client.GetStatsAsync();

                _ = this.Invoke(new Action(() =>
                {
                    try
                    {
                        tbDownloadSpeed.Text = int.Parse(stats.DownloadSpeed).Bytes().Per(TimeSpan.FromSeconds(1)).Humanize("#.##").ToString();
                        tbUploadSpeed.Text = int.Parse(stats.UploadSpeed).Bytes().Per(TimeSpan.FromSeconds(1)).Humanize("#.##").ToString();
                        tbActiveDownloads.Text = stats.ActiveDownloads;
                        tbDownloadsInQueue.Text = stats.WaitingDownloads;
                        tbStoppedDownloads.Text = stats.StoppedDownloads;
                        tbTotalDownloads.Text = stats.TotalStoppedDownloads;
                    }
                    catch { }
                }));

                await Task.Delay(1000);
            }

            _ = this.Invoke(new Action(() =>
            {
                try
                {
                    tbDownloadSpeed.Text = string.Empty;
                    tbUploadSpeed.Text = string.Empty;
                    tbActiveDownloads.Text = string.Empty;
                    tbDownloadsInQueue.Text = string.Empty;
                    tbStoppedDownloads.Text = string.Empty;
                    tbTotalDownloads.Text = string.Empty;
                }
                catch { }
            }));
        }

        async Task GetCurrentDownloadsAsync()
        {
            while(client != null)
            {
                {
                    _ = client.GetActiveDownloadsAsync().ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                            PopupateDownloads(t.Result);
                    });
                }
                {
                    _ = client.GetStoppedDownloadsAsync().ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                            PopupateDownloads(t.Result);
                    });
                }
                {
                    _ = client.GetWaitingDownloadsAsync().ContinueWith(t =>
                    {
                        if (!t.IsFaulted)
                            PopupateDownloads(t.Result);
                    });
                }

                await Task.Delay(2500);
            }
        }

        void PopupateDownloads(IEnumerable<AriaDownload> downloads)
        {
            _ = flpDownloads.Invoke(new Action(() =>
            {

                foreach (var download in downloads)
                {

                    bool found = false;

                    for (var i = 0; i < flpDownloads.Controls.Count; i++)
                    {
                        var control = flpDownloads.Controls[i];

                        if (!(control is DownloadUserControl download_user_control))
                            continue;
                        else
                        {
                            if (download_user_control.DownloadId.Equals(download.Id))
                            {
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        var download_user_control = new DownloadUserControl(download.Id, client, cts.Token);
                        download_user_control.BeginUpdateStatusAsync();
                        flpDownloads.Controls.Add(download_user_control);
                    }
                }
            }));
        }
    }
}
