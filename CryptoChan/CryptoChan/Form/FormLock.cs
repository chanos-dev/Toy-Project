using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptChan
{
    public partial class FormLock : UserControl
    {
        public FormLock()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            panel_main.AllowDrop = true; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, panel.DisplayRectangle, Color.Silver, ButtonBorderStyle.Dashed);
        }

        private void panel_main_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] strFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string strFile in strFiles)
                {
                    label_name.Text = Path.GetFileName(strFile);
                    label_name.ForeColor = Color.LightCoral;
                }
            } 
        }

        private void panel_main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            } 
        }

        private void button_OpenFileBrowser_Click(object sender, EventArgs e)
        { 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.ShowDialog();

            label_name.Text = Path.GetFileName(openFileDialog.FileName);
            label_name.ForeColor = Color.LightCoral;

        }

        private void button_Encrpyt_Click(object sender, EventArgs e)
        {

        }
    }
}
