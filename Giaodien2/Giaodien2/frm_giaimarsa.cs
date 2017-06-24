using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Giaodien2
{
    public partial class frm_giaimarsa : Form
    {
        public frm_giaimarsa()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strDir = openFileDialog1.FileName;
                //MessageBox.Show(strDir);
                txt_ChooseFile.Text = strDir;
            }
        }

        private void btn_ChooseKeyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML file|*.xml";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strDir = openFileDialog1.FileName;
                //MessageBox.Show(strDir);
                txt_ChooseKeyFile.Text = strDir;
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "DeCrypte File file|*.NEC";
            saveFileDialog1.Title = "Save DeCrypte File";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.FileName = txt_ChooseFile.Text.Remove(txt_ChooseFile.Text.Length - 4);

            if (txt_ChooseFile.Text.Length == 0)
            {
                MessageBox.Show(" Bạn chưa chọn File để Decypt!");
                return;
            }

            if (txt_ChooseKeyFile.Text.Length == 0)
            {
                MessageBox.Show(" Bạn chưa chọn File Private key!");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fin = null;
                int[] iHeader = new int[2];
                byte[] Header = new byte[sizeof(int) * 2];
                if (saveFileDialog1.FileName != "")
                {
                    FileStream fout = null;
                    FileStream fKey = null;
                    StreamReader swKey = null;
                    try
                    {
                        fout = (FileStream)saveFileDialog1.OpenFile();
                        fin = new FileStream(txt_ChooseFile.Text, FileMode.Open);
                        fKey = new FileStream(txt_ChooseKeyFile.Text, FileMode.Open);
                        swKey = new StreamReader(fKey);
                        string key = swKey.ReadToEnd();
                        {
                            CspParameters dummy = new CspParameters();

                            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(dummy))
                            {
                                RSA.FromXmlString(key);
                                byte[] buff = new byte[128];
                                byte[] buffout = null;
                                fin.Read(Header, 0, Header.Length);
                                for (var index = 0; index < 2; index++)
                                {
                                    iHeader[index] = BitConverter.ToInt32(Header, index * sizeof(int));
                                }
                                if (iHeader[0] != 12345 && iHeader[1] != 1)
                                {
                                    MessageBox.Show("Đây không phải là file chương trình đã mã hóa.");
                                    return;
                                }
                                while (fin.Read(buff, 0, 128) != 0)
                                {
                                    buffout = RSA.Decrypt(buff, true);
                                    fout.Write(buffout, 0, buffout.Length);
                                }
                            }
                        }

                    }
                    finally
                    {
                        if (fout != null) fout.Close();
                        if (fin != null) fin.Close();
                        if (fKey != null) fKey.Close();
                        if (swKey != null) swKey.Close();
                        MessageBox.Show("Đã giải mã xong!");
                    }
                }
            }
        }

        private void btn_ShowFolder_Click(object sender, EventArgs e)
        {
            string str2 = Directory.GetCurrentDirectory();
            if (Directory.Exists(str2))
                Process.Start(str2);
            else
                MessageBox.Show("Đường dẫn không tồn tại!");            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
