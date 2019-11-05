using System.ComponentModel;

namespace System.Windows.Forms
{
    public class CopyableLabel : TextBox
    {
        public CopyableLabel() : base()
        {
            
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        public new bool ReadOnly
        {
            get
            {
                return true;
            }
            set
            {
                base.ReadOnly = true;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        public new BorderStyle BorderStyle
        {
            get
            {
                return BorderStyle.None;
            }
            set
            {
                base.BorderStyle = BorderStyle.None;
            }
        }
    }
}
