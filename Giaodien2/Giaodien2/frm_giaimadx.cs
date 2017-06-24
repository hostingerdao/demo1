using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien2
{
    public partial class frm_giaimadx : Form
    {
        public frm_giaimadx()
        {
            InitializeComponent();
        }

        private void GiaiMaDX_Load(object sender, EventArgs e)
        {
            loadAlgorithm();
            loadModeOperation();
            loadPaddingMode();
            cbx_Algorithm.SelectionStart = 0;
            cbx_Padding.SelectedItem = 0;
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog pathFile = new OpenFileDialog();
            if (pathFile.ShowDialog() == DialogResult.OK)
            {
                txt_PathFile.Text = pathFile.FileName;
            }
        }

        private void btn_OutFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog pathFile = new SaveFileDialog();
            if (pathFile.ShowDialog() == DialogResult.OK)
            {
                txt_Filename.Text = pathFile.FileName;
            }
        }

        private void loadAlgorithm()
        {
            string[] data = { "DES", "Rijndael" };
            cbx_Algorithm.DataSource = data;
        }

        private void loadPaddingMode()
        {
            string[] data = { "X923", "PKCS7", "ISO10126", "Zeros", "None" };
            cbx_Padding.DataSource = data;
        }

        private void loadModeOperation()
        {
            string[] data = { "CBC", "OFB", "CFB", "CTS", "ECB" };
            cbx_ModeOperation.DataSource = data;
        }

        private PaddingMode cryptPaddingMode(String str)
        {
            switch (str)
            {
                case "ANSIX923":
                    return PaddingMode.ANSIX923;
                case "ISO10126":
                    return PaddingMode.ISO10126;
                case "PKCS7":
                    return PaddingMode.PKCS7;
                case "Zeros":
                    return PaddingMode.Zeros;
                default:
                    return PaddingMode.None;
            }
        }

        private CipherMode cryptCipherMode(String ctr)
        {
            switch (ctr)
            {
                case "CFB":
                    return CipherMode.CFB;
                case "CTS":
                    return CipherMode.CTS;
                case "ECB":
                    return CipherMode.ECB;
                case "OFB":
                    return CipherMode.OFB;
                default:
                    return CipherMode.CBC;
            }
        }

        private bool isPathNotNull()
        {
            return txt_Filename.Text != "" && txt_PathFile.Text != "";
        }

        private void processFile()
        {
            Stream inputstream = File.OpenRead(txt_PathFile.Text);
            Stream outputstream = File.OpenWrite(txt_Filename.Text);
            BufferedStream bufInput = new BufferedStream(inputstream);
            BufferedStream bufOutput = new BufferedStream(outputstream);

            int SIZE_BUFF = 255;
            int bytesRead = 0;
            byte[] buffer = new byte[SIZE_BUFF];

            while ((bytesRead = bufInput.Read(buffer, 0, SIZE_BUFF)) > 0)
            {
                bufOutput.Write(buffer, 0, bytesRead);
            }
            bufOutput.Flush();
            inputstream.Close();
            outputstream.Close();
        }

        private void processFile2()
        {
            FileStream fs = new FileStream(txt_PathFile.Text, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            FileStream fo = new FileStream(txt_Filename.Text, FileMode.Create);
            StreamWriter wr = new StreamWriter(fo, Encoding.UTF8);
            String line = "";

            while ((line = rd.ReadLine()) != null)
            {
                wr.WriteLine(line);
            }
            rd.Close();
            wr.Close();
        }

        private void createFileOutput()
        {
            try
            {
                if (cbx_Algorithm.SelectedIndex == 0)
                {
                    DecryptFile(txt_PathFile.Text, txt_Filename.Text, txt_Password.Text);
                }
                else
                {
                    Decrypt(txt_PathFile.Text, txt_Filename.Text, txt_Password.Text);
                }
                MessageBox.Show("Success!", "Notification", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Cannot decrypt", "Notification", MessageBoxButtons.OK);
            }

        }

        private CryptoStream DESCreateDecryptor(Stream fsread, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            return new CryptoStream(fsread, DES.CreateDecryptor(), CryptoStreamMode.Read);
        }

        private CryptoStream AESCreateDecryptor(Stream fsread, string sKey)
        {
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            return new CryptoStream(fsread, AES.CreateDecryptor(), CryptoStreamMode.Read);
        }

        private void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);

            string algr = "1";
            byte[] info = new UTF8Encoding(true).GetBytes(algr);
            fsread.Read(info, 0, info.Length);
            string s = System.Text.Encoding.UTF8.GetString(info, 0, info.Length);

            if (s == "2")
            {
                Decrypt(sInputFilename, sOutputFilename, sKey);
                return;
            }
            else
            {
                string mode = Convert.ToString(cbx_ModeOperation.SelectedIndex);
                byte[] info1 = new UTF8Encoding(true).GetBytes(mode);
                fsread.Read(info1, 0, info1.Length);
                string modes = System.Text.Encoding.UTF8.GetString(info, 0, info.Length);
                cbx_ModeOperation.SelectedItem = Convert.ToInt16(modes);
                DES.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());
            }
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsread.Close();
            fsDecrypted.Close();

        }

        private string Decrypt(string CipherText, string Password, string Salt, string HashAlgorithm,
            int PasswordIterations, string InitialVector,
            int KeySize)
        {
            try
            {
                if (string.IsNullOrEmpty(CipherText))
                    return "";
                byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                byte[] CipherTextBytes = Convert.FromBase64String(CipherText);
                PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
                byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
                RijndaelManaged SymmetricKey = new RijndaelManaged();
                SymmetricKey.Mode = CipherMode.CBC;
                byte[] PlainTextBytes = new byte[CipherTextBytes.Length];
                int ByteCount = 0;
                using (ICryptoTransform Decryptor = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes))
                {
                    using (MemoryStream MemStream = new MemoryStream(CipherTextBytes))
                    {
                        using (CryptoStream CryptoStream = new CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read))
                        {
                            ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
                            MemStream.Close();
                            CryptoStream.Close();
                        }
                    }
                }
                SymmetricKey.Clear();
                return Encoding.UTF8.GetString(PlainTextBytes, 0, ByteCount);
            }
            catch { throw; }
        }

        private string DecryptStringFromBytes_Aes(string CipherText, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(CipherText);
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;

        }

        public string DecryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());
            TDESAlgorithm.Padding = cryptPaddingMode(cbx_Padding.SelectedItem.ToString());
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

        private void DecryptData(String inName, String outName, string sKey)
        {
            FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            byte[] bin = new byte[100];
            long rdlen = 0;
            long totlen = fin.Length;
            int len;

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(sKey));
            tdes.Key = TDESKey;

            CryptoStream encStream = new CryptoStream(fout, tdes.CreateDecryptor(), CryptoStreamMode.Write);
            Console.WriteLine("Encrypting...");

            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
                Console.WriteLine("{0} bytes processed", rdlen);
            }
            encStream.Close();
        }

        public void Decrypt(string fileIn,
                    string fileOut, string Password)
        {
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);

            string algr = "1";
            byte[] info = new UTF8Encoding(true).GetBytes(algr);
            fsIn.Read(info, 0, info.Length);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            Rijndael alg = Rijndael.Create();
            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            string mode = Convert.ToString(cbx_ModeOperation.SelectedIndex);
            byte[] info1 = new UTF8Encoding(true).GetBytes(mode);
            fsIn.Read(info1, 0, info1.Length);
            string modes = System.Text.Encoding.UTF8.GetString(info, 0, info.Length);

            cbx_ModeOperation.SelectedItem = Convert.ToInt16(modes);
            string a = cbx_ModeOperation.SelectedItem.ToString();
            alg.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());

            string padding = Convert.ToString(cbx_Padding.SelectedIndex);
            byte[] info2 = new UTF8Encoding(true).GetBytes(padding);
            fsIn.Read(info2, 0, info2.Length);
            string paddings = System.Text.Encoding.UTF8.GetString(info, 0, info.Length);
            cbx_Padding.SelectedItem = Convert.ToInt16(paddings);
            alg.Padding = cryptPaddingMode(cbx_Padding.SelectedItem.ToString());
            CryptoStream cs = new CryptoStream(fsOut, alg.CreateDecryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                cs.Write(buffer, 0, bytesRead);

            } while (bytesRead != 0);
            cs.Close();
            fsIn.Close();
            fsOut.Close();
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (txt_Filename.Text == "")
            {
                String[] nameFile = txt_PathFile.Text.Split('.');
                txt_Filename.Text = nameFile[nameFile.Length - 2] + "Crypt." + nameFile[nameFile.Length - 1];
            }
            if (txt_Password.Text.Length >= 8)
            {
                if (isPathNotNull())
                {
                    createFileOutput();
                }
                else
                {
                    MessageBox.Show("PathFile and FileName not Null!", "Notification", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Password is at least 8 characters", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
