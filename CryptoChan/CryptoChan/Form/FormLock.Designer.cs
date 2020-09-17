namespace CryptChan
{
    partial class FormLock
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_Crypto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userTextBox1 = new CryptChan.UserTextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_OpenFileBrowser = new System.Windows.Forms.Button();
            this.label_text2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_text1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_main.Controls.Add(this.button_Crypto);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.userTextBox1);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.button_OpenFileBrowser);
            this.panel_main.Controls.Add(this.label_text2);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.label_text1);
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Location = new System.Drawing.Point(17, 15);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(580, 435);
            this.panel_main.TabIndex = 0;
            this.panel_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_main_DragDrop);
            this.panel_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_main_DragEnter);
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_Crypto
            // 
            this.button_Crypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Crypto.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button_Crypto.Location = new System.Drawing.Point(396, 92);
            this.button_Crypto.Name = "button_Crypto";
            this.button_Crypto.Size = new System.Drawing.Size(72, 31);
            this.button_Crypto.TabIndex = 12;
            this.button_Crypto.Text = "Crypto";
            this.button_Crypto.UseVisualStyleBackColor = true;
            this.button_Crypto.Click += new System.EventHandler(this.button_Encrpyt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(116, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "PassWord";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTextBox1
            // 
            this.userTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.userTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.userTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.userTextBox1.Location = new System.Drawing.Point(187, 91);
            this.userTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.Size = new System.Drawing.Size(207, 30);
            this.userTextBox1.TabIndex = 10;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label_name.ForeColor = System.Drawing.Color.Silver;
            this.label_name.Location = new System.Drawing.Point(9, 56);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(564, 29);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "(File name)";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_name.TextChanged += new System.EventHandler(this.label_name_TextChanged);
            // 
            // button_OpenFileBrowser
            // 
            this.button_OpenFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenFileBrowser.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button_OpenFileBrowser.Location = new System.Drawing.Point(225, 306);
            this.button_OpenFileBrowser.Name = "button_OpenFileBrowser";
            this.button_OpenFileBrowser.Size = new System.Drawing.Size(130, 31);
            this.button_OpenFileBrowser.TabIndex = 8;
            this.button_OpenFileBrowser.Text = "File Browser";
            this.button_OpenFileBrowser.UseVisualStyleBackColor = true;
            this.button_OpenFileBrowser.Click += new System.EventHandler(this.button_OpenFileBrowser_Click);
            // 
            // label_text2
            // 
            this.label_text2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label_text2.ForeColor = System.Drawing.Color.Silver;
            this.label_text2.Location = new System.Drawing.Point(9, 275);
            this.label_text2.Name = "label_text2";
            this.label_text2.Size = new System.Drawing.Size(564, 29);
            this.label_text2.TabIndex = 7;
            this.label_text2.Text = "or";
            this.label_text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CryptChan.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(241, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_text1
            // 
            this.label_text1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label_text1.ForeColor = System.Drawing.Color.Silver;
            this.label_text1.Location = new System.Drawing.Point(9, 250);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(564, 29);
            this.label_text1.TabIndex = 5;
            this.label_text1.Text = "Drag and drop file";
            this.label_text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label_title.ForeColor = System.Drawing.Color.Silver;
            this.label_title.Location = new System.Drawing.Point(9, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(564, 44);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "E n c r y p t i o n";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormLock";
            this.Size = new System.Drawing.Size(617, 464);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_text1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_OpenFileBrowser;
        private System.Windows.Forms.Label label_text2;
        private System.Windows.Forms.Label label_name;
        private UserTextBox userTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Crypto;
    }
}
