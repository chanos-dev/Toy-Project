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
using System.Security.Cryptography;

namespace CryptChan
{
    public partial class FormLock : UserControl
    {
        string ext = "";


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
                    label_name.Text = strFile; // Path.GetFileName(strFile);
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

            label_name.Text = openFileDialog.FileName; // Path.GetFileName(openFileDialog.FileName);
            label_name.ForeColor = Color.LightCoral;
        }

        private void button_Encrpyt_Click(object sender, EventArgs e)
        {
            string passWord = Encrypt.Instance.EncyptPass(userTextBox1.ToString());
            byte[] keyBytes = Encoding.UTF8.GetBytes(passWord);
            byte[] saltBytes = SHA512.Create().ComputeHash(keyBytes);
            byte[] ImageData = null;

            if (ext.Contains("chan"))
            {
                byte[] exts = null;

                using (FileStream fs = new FileStream(label_name.Text, FileMode.Open, FileAccess.Read))
                {  
                    // Create a byte array of file stream length
                    ImageData = new byte[fs.Length-4];
                    exts = new byte[4];
                  
                    //Read block of bytes from stream into the byte array
                    fs.Read(ImageData, 0, Convert.ToInt32(fs.Length-4));                    
                    fs.Read(exts, 0, 4);
                } 

                byte[] encbytes = Encrypt.Instance.DecryptFile(ImageData, keyBytes, saltBytes);

                using (FileStream fss = new FileStream(label_name.Text + Encoding.Default.GetString(exts), FileMode.Create))
                { 
                    fss.Write(encbytes, 0, encbytes.Length); 
                }
            }
            else
            {
                using (FileStream fs = new FileStream(label_name.Text, FileMode.Open, FileAccess.Read))
                {

                    // Create a byte array of file stream length
                    ImageData = new byte[fs.Length];

                    //Read block of bytes from stream into the byte array
                    fs.Read(ImageData, 0, Convert.ToInt32(fs.Length));
                }

                byte[] encbytes = Encrypt.Instance.EncryptFile(ImageData, keyBytes, saltBytes); 

                //Save As

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\";

                saveFileDialog.Title = "CryptoChan Save";

                saveFileDialog.DefaultExt = "chan";

                saveFileDialog.Filter = "chan files(*.chan)|*.chan";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName.ToString(); 

                    using (FileStream fss = new FileStream(filePath, FileMode.Create))
                    {
                        byte[] exts = Encoding.UTF8.GetBytes(ext);

                        fss.Write(encbytes, 0, encbytes.Length);
                        fss.Write(exts, 0, exts.Length);
                    }
                } 
            }  

            return;

            //PW 암호화
            //file 암호화 후 PW 삽입
            //성공 시 sqlite.db에 파일 insert    
            string encPass = Encrypt.Instance.EncyptPass(userTextBox1.ToString());

            try
            {
                if (true)
                {
                    //Success                
                }
                else
                {
                    //Fail
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            return;

            DB db = new DB();

            try
            {
                if (db.ConnectionDataBase())
                {
                    db.InsertData(label_name.Text);
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void label_name_TextChanged(object sender, EventArgs e)
        {
            ext = Path.GetExtension(label_name.Text);

            if (ext.Contains("chan"))
                button_Crypto.Text = "Decrypt";
            else
                button_Crypto.Text = "Encrypt"; 
        }
    }
}
