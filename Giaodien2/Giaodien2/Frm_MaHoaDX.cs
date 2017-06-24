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
    public partial class Frm_MaHoaDX : Form
    {
        public Frm_MaHoaDX()
        {
            InitializeComponent();
        }

        private void Frm_MaHoaDX_Load(object sender, EventArgs e)
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
                    EncryptFile(txt_PathFile.Text, txt_Filename.Text, txt_Password.Text);
                }
                else
                {
                    Encrypt(txt_PathFile.Text, txt_Filename.Text, txt_Password.Text);
                }
                MessageBox.Show("Success!", "Notification", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Cannot encrypt", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
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

        private CryptoStream DESCreateEncryptor(Stream fsEncrypted, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            return new CryptoStream(fsEncrypted, DES.CreateEncryptor(), CryptoStreamMode.Write);
        }

        private CryptoStream AESCreateEncryptor(Stream fsEncrypted, string sKey)
        {
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            return new CryptoStream(fsEncrypted, AES.CreateEncryptor(), CryptoStreamMode.Write);
        }

        private void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);

            string alg = "1";
            byte[] info = new UTF8Encoding(true).GetBytes(alg);
            fsEncrypted.Write(info, 0, info.Length);

            string mode = Convert.ToString(cbx_ModeOperation.SelectedIndex);
            byte[] info1 = new UTF8Encoding(true).GetBytes(mode);
            fsEncrypted.Write(info1, 0, info1.Length);

            string padding = Convert.ToString(cbx_Padding.SelectedIndex);
            byte[] info2 = new UTF8Encoding(true).GetBytes(padding);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
        }

        private string Encrypt(string PlainText, string Password, string Salt, string HashAlgorithm, int PasswordIterations, string InitialVector, int KeySize)
        {
            try
            {
                if (string.IsNullOrEmpty(PlainText))
                    return "";
                byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);
                PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
                byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
                RijndaelManaged SymmetricKey = new RijndaelManaged();
                SymmetricKey.Mode = CipherMode.CBC;
                byte[] CipherTextBytes = null;

                using (ICryptoTransform Encryptor = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes))
                {
                    using (MemoryStream MemStream = new MemoryStream())
                    {
                        using (CryptoStream CryptoStream = new CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write))
                        {
                            CryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length);
                            CryptoStream.FlushFinalBlock();
                            CipherTextBytes = MemStream.ToArray();
                            MemStream.Close();
                            CryptoStream.Close();
                        }
                    }
                }
                SymmetricKey.Clear();
                return Convert.ToBase64String(CipherTextBytes);
            }
            catch { throw; }
        }

        private string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public string EncryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());
            TDESAlgorithm.Padding = cryptPaddingMode(cbx_Padding.SelectedItem.ToString());
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        private void EncryptData(String inName, String outName, string sKey)
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
            CryptoStream encStream = new CryptoStream(fout, tdes.CreateEncryptor(), CryptoStreamMode.Write);
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

        public void Encrypt(string fileIn, string fileOut, string Password)
        {
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.Create, FileAccess.Write);

            string algr = "2";
            byte[] info = new UTF8Encoding(true).GetBytes(algr);
            fsOut.Write(info, 0, info.Length);

            string mode = Convert.ToString(cbx_ModeOperation.SelectedIndex);
            byte[] info1 = new UTF8Encoding(true).GetBytes(mode);
            fsOut.Write(info1, 0, info1.Length);

            string padding = Convert.ToString(cbx_Padding.SelectedIndex);
            byte[] info2 = new UTF8Encoding(true).GetBytes(padding);
            fsOut.Write(info2, 0, info2.Length);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                    0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            Rijndael alg = Rijndael.Create();
            alg.Mode = cryptCipherMode(cbx_ModeOperation.SelectedItem.ToString());
            alg.Key = pdb.GetBytes(32);
            alg.Padding = cryptPaddingMode(cbx_Padding.SelectedItem.ToString());
            alg.IV = pdb.GetBytes(16);

            CryptoStream cs = new CryptoStream(fsOut, alg.CreateEncryptor(), CryptoStreamMode.Write);

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
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
