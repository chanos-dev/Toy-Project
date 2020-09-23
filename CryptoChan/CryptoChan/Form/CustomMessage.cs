using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptChan
{
    public partial class CustomMessage : UserControl
    {
        public CustomMessage()
        {
            InitializeComponent(); 
        } 

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, panel.DisplayRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }         
    }
}
