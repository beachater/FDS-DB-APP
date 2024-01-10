using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS_application
{
    public class TranspPictureBox : PictureBox
    {
        public TranspPictureBox()
        {
            // Enable support for a transparent backcolor
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // Set the backcolor to transparent
            this.BackColor = Color.Transparent;
        }
    }
}