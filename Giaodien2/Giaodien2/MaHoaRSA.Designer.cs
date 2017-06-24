namespace Giaodien2
{
    partial class MaHoaRSA
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
            this.grb_CreateKey = new System.Windows.Forms.GroupBox();
            this.btn_PublicKey = new DevComponents.DotNetBar.ButtonX();
            this.btn_PrivateKey = new DevComponents.DotNetBar.ButtonX();
            this.btn_NewKey = new DevComponents.DotNetBar.ButtonX();
            this.btn_Close = new DevComponents.DotNetBar.ButtonX();
            this.btn_Encrypt = new DevComponents.DotNetBar.ButtonX();
            this.btn_ShowFolder = new DevComponents.DotNetBar.ButtonX();
            this.btn_ChooseKeyFile = new DevComponents.DotNetBar.ButtonX();
            this.txt_ChooseKeyFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ChooseFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_ChooseFile = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grb_CreateKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_CreateKey
            // 
            this.grb_CreateKey.Controls.Add(this.btn_PublicKey);
            this.grb_CreateKey.Controls.Add(this.btn_PrivateKey);
            this.grb_CreateKey.Controls.Add(this.btn_NewKey);
            this.grb_CreateKey.ForeColor = System.Drawing.Color.White;
            this.grb_CreateKey.Location = new System.Drawing.Point(9, 52);
            this.grb_CreateKey.Name = "grb_CreateKey";
            this.grb_CreateKey.Size = new System.Drawing.Size(388, 82);
            this.grb_CreateKey.TabIndex = 17;
            this.grb_CreateKey.TabStop = false;
            this.grb_CreateKey.Text = "Create Key";
            // 
            // btn_PublicKey
            // 
            this.btn_PublicKey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_PublicKey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_PublicKey.Location = new System.Drawing.Point(33, 48);
            this.btn_PublicKey.Name = "btn_PublicKey";
            this.btn_PublicKey.Size = new System.Drawing.Size(213, 23);
            this.btn_PublicKey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_PublicKey.TabIndex = 2;
            this.btn_PublicKey.Text = "Save Public Key";
            // 
            // btn_PrivateKey
            // 
            this.btn_PrivateKey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_PrivateKey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_PrivateKey.Location = new System.Drawing.Point(33, 19);
            this.btn_PrivateKey.Name = "btn_PrivateKey";
            this.btn_PrivateKey.Size = new System.Drawing.Size(213, 23);
            this.btn_PrivateKey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_PrivateKey.TabIndex = 1;
            this.btn_PrivateKey.Text = "Save Private and Public Key";
            // 
            // btn_NewKey
            // 
            this.btn_NewKey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NewKey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_NewKey.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_NewKey.Location = new System.Drawing.Point(262, 19);
            this.btn_NewKey.Name = "btn_NewKey";
            this.btn_NewKey.Size = new System.Drawing.Size(106, 52);
            this.btn_NewKey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NewKey.TabIndex = 0;
            this.btn_NewKey.Text = "New Key RSA";
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Close.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(298, 241);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(68, 35);
            this.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Close";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Encrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Encrypt.Location = new System.Drawing.Point(26, 241);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(113, 35);
            this.btn_Encrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Encrypt.TabIndex = 24;
            this.btn_Encrypt.Text = "ENCRYPT";
            this.btn_Encrypt.TextColor = System.Drawing.Color.Red;
            // 
            // btn_ShowFolder
            // 
            this.btn_ShowFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ShowFolder.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_ShowFolder.Location = new System.Drawing.Point(171, 241);
            this.btn_ShowFolder.Name = "btn_ShowFolder";
            this.btn_ShowFolder.Size = new System.Drawing.Size(97, 35);
            this.btn_ShowFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowFolder.TabIndex = 23;
            this.btn_ShowFolder.Text = "Show Folder";
            // 
            // btn_ChooseKeyFile
            // 
            this.btn_ChooseKeyFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseKeyFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseKeyFile.Location = new System.Drawing.Point(271, 190);
            this.btn_ChooseKeyFile.Name = "btn_ChooseKeyFile";
            this.btn_ChooseKeyFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseKeyFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseKeyFile.TabIndex = 22;
            this.btn_ChooseKeyFile.Text = "Choose Public Key File";
            // 
            // txt_ChooseKeyFile
            // 
            // 
            // 
            // 
            this.txt_ChooseKeyFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseKeyFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseKeyFile.Location = new System.Drawing.Point(9, 193);
            this.txt_ChooseKeyFile.Name = "txt_ChooseKeyFile";
            this.txt_ChooseKeyFile.PreventEnterBeep = true;
            this.txt_ChooseKeyFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseKeyFile.TabIndex = 21;
            // 
            // txt_ChooseFile
            // 
            // 
            // 
            // 
            this.txt_ChooseFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseFile.Location = new System.Drawing.Point(9, 158);
            this.txt_ChooseFile.Name = "txt_ChooseFile";
            this.txt_ChooseFile.PreventEnterBeep = true;
            this.txt_ChooseFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseFile.TabIndex = 20;
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseFile.Location = new System.Drawing.Point(271, 158);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseFile.TabIndex = 19;
            this.btn_ChooseFile.Text = "Choose File";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(128, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(140, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "ENCRYPT ";
            // 
            // MaHoaRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 288);
            this.Controls.Add(this.grb_CreateKey);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_ShowFolder);
            this.Controls.Add(this.btn_ChooseKeyFile);
            this.Controls.Add(this.txt_ChooseKeyFile);
            this.Controls.Add(this.txt_ChooseFile);
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.labelX1);
            this.Name = "MaHoaRSA";
            this.Text = "MaHoaRSA";
            this.grb_CreateKey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_CreateKey;
        private DevComponents.DotNetBar.ButtonX btn_PublicKey;
        private DevComponents.DotNetBar.ButtonX btn_PrivateKey;
        private DevComponents.DotNetBar.ButtonX btn_NewKey;
        private DevComponents.DotNetBar.ButtonX btn_Close;
        private DevComponents.DotNetBar.ButtonX btn_Encrypt;
        private DevComponents.DotNetBar.ButtonX btn_ShowFolder;
        private DevComponents.DotNetBar.ButtonX btn_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseFile;
        private DevComponents.DotNetBar.ButtonX btn_ChooseFile;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}