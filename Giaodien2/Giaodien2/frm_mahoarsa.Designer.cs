namespace Giaodien2
{
    partial class frm_mahoarsa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Encrypt = new DevComponents.DotNetBar.LabelX();
            this.grb_File = new System.Windows.Forms.GroupBox();
            this.btn_ChooseKeyFile = new DevComponents.DotNetBar.ButtonX();
            this.txt_ChooseKeyFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ChooseFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_ChooseFile = new DevComponents.DotNetBar.ButtonX();
            this.btn_Close = new DevComponents.DotNetBar.ButtonX();
            this.btn_Decrypt = new DevComponents.DotNetBar.ButtonX();
            this.btn_ShowFolder = new DevComponents.DotNetBar.ButtonX();
            this.grb_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Encrypt
            // 
            // 
            // 
            // 
            this.lbl_Encrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_Encrypt.Location = new System.Drawing.Point(131, 12);
            this.lbl_Encrypt.Name = "lbl_Encrypt";
            this.lbl_Encrypt.Size = new System.Drawing.Size(140, 23);
            this.lbl_Encrypt.TabIndex = 26;
            this.lbl_Encrypt.Text = "ENCRYPT ";
            // 
            // grb_File
            // 
            this.grb_File.Controls.Add(this.btn_ChooseKeyFile);
            this.grb_File.Controls.Add(this.txt_ChooseKeyFile);
            this.grb_File.Controls.Add(this.txt_ChooseFile);
            this.grb_File.Controls.Add(this.btn_ChooseFile);
            this.grb_File.ForeColor = System.Drawing.Color.White;
            this.grb_File.Location = new System.Drawing.Point(12, 41);
            this.grb_File.Name = "grb_File";
            this.grb_File.Size = new System.Drawing.Size(403, 88);
            this.grb_File.TabIndex = 34;
            this.grb_File.TabStop = false;
            this.grb_File.Text = "File";
            // 
            // btn_ChooseKeyFile
            // 
            this.btn_ChooseKeyFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseKeyFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseKeyFile.Location = new System.Drawing.Point(267, 49);
            this.btn_ChooseKeyFile.Name = "btn_ChooseKeyFile";
            this.btn_ChooseKeyFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseKeyFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseKeyFile.TabIndex = 26;
            this.btn_ChooseKeyFile.Text = "Choose Public Key File";
            this.btn_ChooseKeyFile.Click += new System.EventHandler(this.btn_ChooseKeyFile_Click);
            // 
            // txt_ChooseKeyFile
            // 
            // 
            // 
            // 
            this.txt_ChooseKeyFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseKeyFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseKeyFile.Location = new System.Drawing.Point(8, 52);
            this.txt_ChooseKeyFile.Name = "txt_ChooseKeyFile";
            this.txt_ChooseKeyFile.PreventEnterBeep = true;
            this.txt_ChooseKeyFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseKeyFile.TabIndex = 25;
            // 
            // txt_ChooseFile
            // 
            // 
            // 
            // 
            this.txt_ChooseFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseFile.Location = new System.Drawing.Point(8, 19);
            this.txt_ChooseFile.Name = "txt_ChooseFile";
            this.txt_ChooseFile.PreventEnterBeep = true;
            this.txt_ChooseFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseFile.TabIndex = 24;
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseFile.Location = new System.Drawing.Point(267, 16);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseFile.TabIndex = 23;
            this.btn_ChooseFile.Text = "Choose File";
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Close.HoverImage = global::Giaodien2.Properties.Resources.tải_xuống;
            this.btn_Close.Image = global::Giaodien2.Properties.Resources.tải_xuống__4_;
            this.btn_Close.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(329, 143);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(62, 35);
            this.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Close.TabIndex = 33;
            this.btn_Close.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Decrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.HoverImage = global::Giaodien2.Properties.Resources.tải_xuống;
            this.btn_Decrypt.Image = global::Giaodien2.Properties.Resources.decrypt;
            this.btn_Decrypt.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Decrypt.Location = new System.Drawing.Point(37, 143);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(113, 35);
            this.btn_Decrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Decrypt.TabIndex = 32;
            this.btn_Decrypt.Text = "DECRYPT";
            this.btn_Decrypt.TextColor = System.Drawing.Color.Red;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_ShowFolder
            // 
            this.btn_ShowFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ShowFolder.HoverImage = global::Giaodien2.Properties.Resources.tải_xuống;
            this.btn_ShowFolder.Image = global::Giaodien2.Properties.Resources.images__1_;
            this.btn_ShowFolder.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_ShowFolder.Location = new System.Drawing.Point(191, 143);
            this.btn_ShowFolder.Name = "btn_ShowFolder";
            this.btn_ShowFolder.Size = new System.Drawing.Size(97, 35);
            this.btn_ShowFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowFolder.TabIndex = 31;
            this.btn_ShowFolder.Text = "Show Folder";
            this.btn_ShowFolder.Click += new System.EventHandler(this.btn_ShowFolder_Click);
            // 
            // frm_mahoarsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.Controls.Add(this.grb_File);
            this.Controls.Add(this.lbl_Encrypt);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_ShowFolder);
            this.Name = "frm_mahoarsa";
            this.Text = "frm_mahoarsa";
            this.Load += new System.EventHandler(this.frm_mahoarsa_Load);
            this.grb_File.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Encrypt;
        private DevComponents.DotNetBar.ButtonX btn_Close;
        private DevComponents.DotNetBar.ButtonX btn_Decrypt;
        private DevComponents.DotNetBar.ButtonX btn_ShowFolder;
        private System.Windows.Forms.GroupBox grb_File;
        private DevComponents.DotNetBar.ButtonX btn_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseFile;
        private DevComponents.DotNetBar.ButtonX btn_ChooseFile;
    }
}