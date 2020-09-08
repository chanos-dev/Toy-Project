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
    public partial class UserTextBox : UserControl
    {
        public UserTextBox()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            pictureBox_show.Tag = "No";
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, panel.DisplayRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        public override string ToString()
        {
            return textBox_pw.Text;
        }

        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            string showPassWord = pictureBox_show.Tag as string;

            if(showPassWord != null)
            {
                if(showPassWord.Equals("Yes"))
                {
                    pictureBox_show.Image = Properties.Resources.show_silver;
                    pictureBox_show.Tag = "No";
                    textBox_pw.PasswordChar = '●';
                }
                else
                {
                    pictureBox_show.Image = Properties.Resources.show_green;
                    pictureBox_show.Tag = "Yes";
                    textBox_pw.PasswordChar = '\0';
                }
            }            
        }
    }
}
