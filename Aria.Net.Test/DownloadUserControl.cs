using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aria.Net.Entities.Download;
using System.Threading;
using System.Diagnostics;

namespace Aria.Net.Test
{
    public partial class DownloadUserControl : UserControl
    {
        public string DownloadId { get; }
        public AriaClient Aria { get; }
        public CancellationTokenSource Cts { get; }

        public DownloadUserControl()
        {
            InitializeComponent();
        }

        public DownloadUserControl(string id, AriaClient client, CancellationToken token) : this()
        {
            this.DownloadId = id;
            this.Aria = client;
            this.Cts = CancellationTokenSource.CreateLinkedTokenSource(token);
        }

        public void BeginUpdateStatusAsync()
        {
            _ = Task.Run(this.UpdateStatusAsync, this.Cts.Token);
        }

        async Task UpdateStatusAsync()
        {
            while (!Cts.IsCancellationRequested)
            {
                try
                {
                    var result = await this.Aria.GetDownloadAsync(this.DownloadId, "completedLength", "totalLength", "status", "files", "bittorrent");

                    this.BeginInvoke(new Action(() =>
                    {
                        this.pgStatus.Value = GetProgress(result.CompletedLength, result.TotalLength);
                        this.tbFileNameOrTitle.Text = (result.BitTorrent?.Info?.Name ?? result.Files.FirstOrDefault()?.Path) ?? "Unknown file name";
                    }));

                    if (result.Status == AriaDownloadStatus.Completed)
                        break;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }

                await Task.Delay(1000);
            }
        }

        int GetProgress(long value, long total)
        {
            return (int)(((double)value / total) * 100);
        }
    }
}
