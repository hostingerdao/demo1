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
    public partial class frm_mahoarsa : Form
    {
        public frm_mahoarsa()
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

        private void frm_mahoarsa_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ShowFolder_Click(object sender, EventArgs e)
        {
            string str2 = Directory.GetCurrentDirectory();
            if (Directory.Exists(str2))
                Process.Start(str2);
            else
                MessageBox.Show("Đường dẫn không tồn tại!"); 
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "EnCrypte File file|*.NEC";
            saveFileDialog1.Title = "Save EnCrypte File";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.FileName = txt_ChooseFile.Text + ".NEC";

            if (txt_ChooseFile.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn file để Encry.");
                return;
            }
            if (txt_ChooseKeyFile.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn file Public Key.");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read file encry
                FileStream fin = null;
                int OAEP = 1;
                int StarB = 12345;
                int[] iHeader = { StarB, OAEP };
                byte[] Header = new byte[sizeof(int) * 2];
                Buffer.BlockCopy(iHeader, 0, Header, 0, Header.Length);
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
                                byte[] buff = new byte[86];
                                byte[] buffout = null;
                                fout.Write(Header, 0, Header.Length);
                                int c = fin.Read(buff, 0, 86);
                                do
                                {
                                    byte[] newArray = new byte[c];
                                    Array.Copy(buff, newArray, c);
                                    buffout = RSA.Encrypt(newArray, true);
                                    fout.Write(buffout, 0, buffout.Length);
                                    c = fin.Read(buff, 0, 86);
                                }
                                while (c != 0);
                            }
                        }

                    }
                    finally
                    {
                        MessageBox.Show("Đã mã hóa xong");
                        if (fout != null) fout.Close();
                        if (fin != null) fin.Close();
                        if (fKey != null) fKey.Close();
                        if (swKey != null) swKey.Close();
                    }
                }
            }
        }
    }
}
