namespace Giaodien2
{
    partial class GiaiMaRAS
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
            this.lbl_Decrypt = new DevComponents.DotNetBar.LabelX();
            this.btn_Close = new DevComponents.DotNetBar.ButtonX();
            this.btn_Decrypt = new DevComponents.DotNetBar.ButtonX();
            this.btn_ShowFolder = new DevComponents.DotNetBar.ButtonX();
            this.btn_ChooseKeyFile = new DevComponents.DotNetBar.ButtonX();
            this.txt_ChooseKeyFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ChooseFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_ChooseFile = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lbl_Decrypt
            // 
            // 
            // 
            // 
            this.lbl_Decrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Decrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_Decrypt.Location = new System.Drawing.Point(129, 12);
            this.lbl_Decrypt.Name = "lbl_Decrypt";
            this.lbl_Decrypt.Size = new System.Drawing.Size(140, 23);
            this.lbl_Decrypt.TabIndex = 26;
            this.lbl_Decrypt.Text = "DECRYPT ";
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Close.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(303, 143);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(68, 35);
            this.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Close.TabIndex = 33;
            this.btn_Close.Text = "Close";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Decrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Decrypt.Location = new System.Drawing.Point(23, 143);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(113, 35);
            this.btn_Decrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Decrypt.TabIndex = 32;
            this.btn_Decrypt.Text = "DECRYPT";
            this.btn_Decrypt.TextColor = System.Drawing.Color.Red;
            // 
            // btn_ShowFolder
            // 
            this.btn_ShowFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ShowFolder.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_ShowFolder.Location = new System.Drawing.Point(172, 143);
            this.btn_ShowFolder.Name = "btn_ShowFolder";
            this.btn_ShowFolder.Size = new System.Drawing.Size(97, 35);
            this.btn_ShowFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowFolder.TabIndex = 31;
            this.btn_ShowFolder.Text = "Show Folder";
            // 
            // btn_ChooseKeyFile
            // 
            this.btn_ChooseKeyFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseKeyFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseKeyFile.Location = new System.Drawing.Point(275, 97);
            this.btn_ChooseKeyFile.Name = "btn_ChooseKeyFile";
            this.btn_ChooseKeyFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseKeyFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseKeyFile.TabIndex = 30;
            this.btn_ChooseKeyFile.Text = "Choose Public Key File";
            // 
            // txt_ChooseKeyFile
            // 
            // 
            // 
            // 
            this.txt_ChooseKeyFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseKeyFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseKeyFile.Location = new System.Drawing.Point(9, 100);
            this.txt_ChooseKeyFile.Name = "txt_ChooseKeyFile";
            this.txt_ChooseKeyFile.PreventEnterBeep = true;
            this.txt_ChooseKeyFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseKeyFile.TabIndex = 29;
            // 
            // txt_ChooseFile
            // 
            // 
            // 
            // 
            this.txt_ChooseFile.Border.Class = "TextBoxBorder";
            this.txt_ChooseFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ChooseFile.Location = new System.Drawing.Point(9, 64);
            this.txt_ChooseFile.Name = "txt_ChooseFile";
            this.txt_ChooseFile.PreventEnterBeep = true;
            this.txt_ChooseFile.Size = new System.Drawing.Size(246, 20);
            this.txt_ChooseFile.TabIndex = 28;
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseFile.Location = new System.Drawing.Point(275, 64);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseFile.TabIndex = 27;
            this.btn_ChooseFile.Text = "Choose File";
            // 
            // GiaiMaRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 193);
            this.Controls.Add(this.lbl_Decrypt);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_ShowFolder);
            this.Controls.Add(this.btn_ChooseKeyFile);
            this.Controls.Add(this.txt_ChooseKeyFile);
            this.Controls.Add(this.txt_ChooseFile);
            this.Controls.Add(this.btn_ChooseFile);
            this.Name = "GiaiMaRAS";
            this.Text = "GiaiMaRAS";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Decrypt;
        private DevComponents.DotNetBar.ButtonX btn_Close;
        private DevComponents.DotNetBar.ButtonX btn_Decrypt;
        private DevComponents.DotNetBar.ButtonX btn_ShowFolder;
        private DevComponents.DotNetBar.ButtonX btn_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseKeyFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ChooseFile;
        private DevComponents.DotNetBar.ButtonX btn_ChooseFile;
    }
}