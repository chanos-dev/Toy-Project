using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptChan
{
    public partial class FormCrypt : Form
    {
        enum ButtonType
        {
            DashBoard,
            Lock,
            Calendar,
            Setting,
            Close
        }

        Point mousePoint;
        Timer dateTimer;
        CultureInfo culture = new CultureInfo("en-US");

        public FormCrypt()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        { 
            label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm (ddd)", culture);
            MoveTurnPanel(ButtonType.DashBoard);

            dateTimer = new Timer();
            dateTimer.Interval = 1000; //1 sec
            dateTimer.Tick += (sender, e) =>
            {
                label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm (ddd)", culture);
            };
            dateTimer.Start();
        }

        private void MoveTurnPanel(ButtonType buttonType)
        { 
            switch (buttonType)
            {
                case ButtonType.DashBoard:
                    panel_Turn.Height = button_DashBoard.Height;
                    panel_Turn.Top = button_DashBoard.Top;
                    break;
                case ButtonType.Lock:
                    panel_Turn.Height = button_Lock.Height;
                    panel_Turn.Top = button_Lock.Top;
                    break;
                case ButtonType.Calendar:
                    panel_Turn.Height = button_Calendar.Height;
                    panel_Turn.Top = button_Calendar.Top;
                    break;
                case ButtonType.Setting:
                    panel_Turn.Height = button_Setting.Height;
                    panel_Turn.Top = button_Setting.Top;
                    break;
            }
        }

        private void button_DashBoard_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.DashBoard);
        }

        private void button_Lock_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.Lock);
        }

        private void button_Calendar_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.Calendar);
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.Setting); 
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        { 

        }
    }
}
