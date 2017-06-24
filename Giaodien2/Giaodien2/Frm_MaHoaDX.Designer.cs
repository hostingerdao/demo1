namespace Giaodien2
{
    partial class Frm_MaHoaDX
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
            this.btn_Encrypt = new DevComponents.DotNetBar.ButtonX();
            this.btn_Close = new DevComponents.DotNetBar.ButtonX();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_EncryptFile = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.gbx_File = new System.Windows.Forms.GroupBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Filename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_PathFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_OutFile = new DevComponents.DotNetBar.ButtonX();
            this.btn_ChooseFile = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbx_ModeOperation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbx_Algorithm = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.gbx_AlgorithmAndFigures = new System.Windows.Forms.GroupBox();
            this.cbx_Padding = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.gbx_File.SuspendLayout();
            this.gbx_AlgorithmAndFigures.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Encrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.HoverImage = global::Giaodien2.Properties.Resources.tải_xuống;
            this.btn_Encrypt.Image = global::Giaodien2.Properties.Resources.encrypt;
            this.btn_Encrypt.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Encrypt.Location = new System.Drawing.Point(343, 180);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(113, 35);
            this.btn_Encrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Encrypt.TabIndex = 21;
            this.btn_Encrypt.Text = "ENCRYPT";
            this.btn_Encrypt.TextColor = System.Drawing.Color.Red;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Close.HoverImage = global::Giaodien2.Properties.Resources.tải_xuống;
            this.btn_Close.Image = global::Giaodien2.Properties.Resources.tải_xuống__4_;
            this.btn_Close.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(447, 233);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(63, 35);
            this.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Close.TabIndex = 22;
            this.btn_Close.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Location = new System.Drawing.Point(113, 126);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PreventEnterBeep = true;
            this.txt_Password.Size = new System.Drawing.Size(160, 20);
            this.txt_Password.TabIndex = 19;
            // 
            // lb_EncryptFile
            // 
            // 
            // 
            // 
            this.lb_EncryptFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_EncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EncryptFile.FontBold = true;
            this.lb_EncryptFile.ForeColor = System.Drawing.Color.Blue;
            this.lb_EncryptFile.Location = new System.Drawing.Point(190, 12);
            this.lb_EncryptFile.Name = "lb_EncryptFile";
            this.lb_EncryptFile.Size = new System.Drawing.Size(190, 23);
            this.lb_EncryptFile.TabIndex = 17;
            this.lb_EncryptFile.Text = "ENCRYPT FILE";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Blue;
            this.labelX4.Location = new System.Drawing.Point(13, 125);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(94, 20);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Password Crypt";
            // 
            // gbx_File
            // 
            this.gbx_File.Controls.Add(this.labelX3);
            this.gbx_File.Controls.Add(this.txt_Filename);
            this.gbx_File.Controls.Add(this.labelX2);
            this.gbx_File.Controls.Add(this.txt_PathFile);
            this.gbx_File.Controls.Add(this.btn_OutFile);
            this.gbx_File.Controls.Add(this.btn_ChooseFile);
            this.gbx_File.ForeColor = System.Drawing.Color.Blue;
            this.gbx_File.Location = new System.Drawing.Point(5, 41);
            this.gbx_File.Name = "gbx_File";
            this.gbx_File.Size = new System.Drawing.Size(511, 77);
            this.gbx_File.TabIndex = 16;
            this.gbx_File.TabStop = false;
            this.gbx_File.Text = "File";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(8, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 20);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Filename Crypt";
            // 
            // txt_Filename
            // 
            // 
            // 
            // 
            this.txt_Filename.Border.Class = "TextBoxBorder";
            this.txt_Filename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Filename.Location = new System.Drawing.Point(106, 50);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.PreventEnterBeep = true;
            this.txt_Filename.Size = new System.Drawing.Size(278, 20);
            this.txt_Filename.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(8, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(77, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Path File";
            // 
            // txt_PathFile
            // 
            // 
            // 
            // 
            this.txt_PathFile.Border.Class = "TextBoxBorder";
            this.txt_PathFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_PathFile.Location = new System.Drawing.Point(106, 19);
            this.txt_PathFile.Name = "txt_PathFile";
            this.txt_PathFile.PreventEnterBeep = true;
            this.txt_PathFile.Size = new System.Drawing.Size(278, 20);
            this.txt_PathFile.TabIndex = 2;
            // 
            // btn_OutFile
            // 
            this.btn_OutFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_OutFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_OutFile.Location = new System.Drawing.Point(411, 45);
            this.btn_OutFile.Name = "btn_OutFile";
            this.btn_OutFile.Size = new System.Drawing.Size(82, 21);
            this.btn_OutFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_OutFile.TabIndex = 1;
            this.btn_OutFile.Text = "OutFile";
            this.btn_OutFile.Click += new System.EventHandler(this.btn_OutFile_Click);
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ChooseFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ChooseFile.Location = new System.Drawing.Point(411, 18);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(82, 21);
            this.btn_ChooseFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ChooseFile.TabIndex = 0;
            this.btn_ChooseFile.Text = "Choose File";
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Blue;
            this.labelX7.Location = new System.Drawing.Point(6, 77);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Padding Mode:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Blue;
            this.labelX6.Location = new System.Drawing.Point(8, 48);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(106, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Mode of Operation:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Blue;
            this.labelX5.Location = new System.Drawing.Point(8, 19);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Algorithm:";
            // 
            // cbx_ModeOperation
            // 
            this.cbx_ModeOperation.DisplayMember = "Text";
            this.cbx_ModeOperation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_ModeOperation.ForeColor = System.Drawing.Color.Blue;
            this.cbx_ModeOperation.FormattingEnabled = true;
            this.cbx_ModeOperation.ItemHeight = 14;
            this.cbx_ModeOperation.Location = new System.Drawing.Point(120, 51);
            this.cbx_ModeOperation.Name = "cbx_ModeOperation";
            this.cbx_ModeOperation.Size = new System.Drawing.Size(170, 20);
            this.cbx_ModeOperation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_ModeOperation.TabIndex = 4;
            // 
            // cbx_Algorithm
            // 
            this.cbx_Algorithm.DisplayMember = "Text";
            this.cbx_Algorithm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Algorithm.ForeColor = System.Drawing.Color.Blue;
            this.cbx_Algorithm.FormattingEnabled = true;
            this.cbx_Algorithm.ItemHeight = 14;
            this.cbx_Algorithm.Location = new System.Drawing.Point(120, 22);
            this.cbx_Algorithm.Name = "cbx_Algorithm";
            this.cbx_Algorithm.Size = new System.Drawing.Size(170, 20);
            this.cbx_Algorithm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Algorithm.TabIndex = 3;
            // 
            // gbx_AlgorithmAndFigures
            // 
            this.gbx_AlgorithmAndFigures.Controls.Add(this.cbx_Padding);
            this.gbx_AlgorithmAndFigures.Controls.Add(this.cbx_ModeOperation);
            this.gbx_AlgorithmAndFigures.Controls.Add(this.cbx_Algorithm);
            this.gbx_AlgorithmAndFigures.Controls.Add(this.labelX7);
            this.gbx_AlgorithmAndFigures.Controls.Add(this.labelX6);
            this.gbx_AlgorithmAndFigures.Controls.Add(this.labelX5);
            this.gbx_AlgorithmAndFigures.ForeColor = System.Drawing.Color.Blue;
            this.gbx_AlgorithmAndFigures.Location = new System.Drawing.Point(5, 158);
            this.gbx_AlgorithmAndFigures.Name = "gbx_AlgorithmAndFigures";
            this.gbx_AlgorithmAndFigures.Size = new System.Drawing.Size(307, 110);
            this.gbx_AlgorithmAndFigures.TabIndex = 20;
            this.gbx_AlgorithmAndFigures.TabStop = false;
            this.gbx_AlgorithmAndFigures.Text = "Algorithm And Figures";
            // 
            // cbx_Padding
            // 
            this.cbx_Padding.DisplayMember = "Text";
            this.cbx_Padding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Padding.ForeColor = System.Drawing.Color.Blue;
            this.cbx_Padding.FormattingEnabled = true;
            this.cbx_Padding.ItemHeight = 14;
            this.cbx_Padding.Location = new System.Drawing.Point(120, 80);
            this.cbx_Padding.Name = "cbx_Padding";
            this.cbx_Padding.Size = new System.Drawing.Size(170, 20);
            this.cbx_Padding.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Padding.TabIndex = 5;
            // 
            // Frm_MaHoaDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(522, 283);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lb_EncryptFile);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.gbx_File);
            this.Controls.Add(this.gbx_AlgorithmAndFigures);
            this.Name = "Frm_MaHoaDX";
            this.Text = "Frm_MaHoaDX";
            this.Load += new System.EventHandler(this.Frm_MaHoaDX_Load);
            this.gbx_File.ResumeLayout(false);
            this.gbx_AlgorithmAndFigures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Encrypt;
        private DevComponents.DotNetBar.ButtonX btn_Close;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
        private DevComponents.DotNetBar.LabelX lb_EncryptFile;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.GroupBox gbx_File;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Filename;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_PathFile;
        private DevComponents.DotNetBar.ButtonX btn_OutFile;
        private DevComponents.DotNetBar.ButtonX btn_ChooseFile;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_ModeOperation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_Algorithm;
        private System.Windows.Forms.GroupBox gbx_AlgorithmAndFigures;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_Padding;
    }
}