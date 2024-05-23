using System.Runtime.InteropServices;

namespace task3_gui
{
    public partial class Form1 : Form
    {
        [DllImport("task3_dll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "GenerateAndSaveRSAKeys")]
        public static extern double GenerateAndSaveRSAKeys(int keySize, string format, string privateKeyFile, string publicKeyFile);
        [DllImport("task3_dll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "RSAencrypt")]
        public static extern double RSAencrypt(string format, string publicKeyFile, string PlaintextFile, string CipherFile);
        [DllImport("task3_dll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "RSAdecrypt")]
        public static extern double RSAdecrypt(string format, string secretKeyFile, string CipherFile, string PlaintextFile);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            if (txtPriKeyGenKey.Text == "" || txtPubKeyGenKey.Text == "")
            {
                MessageBox.Show("Please enter both private key file and public key file");
                return;
            }
            if (cbFormatGenKey.SelectedIndex == -1 || cbKeySizeGenKey.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose format and key size");
                return;
            }
            double time = 0;
            int keySize = int.Parse(cbKeySizeGenKey.SelectedItem.ToString());
            try
            {
                time = GenerateAndSaveRSAKeys(keySize, cbFormatGenKey.SelectedItem.ToString(),
                    txtPriKeyGenKey.Text, txtPubKeyGenKey.Text);
            }
            catch
            {
                MessageBox.Show("Fail to gen key");
                return;
            }
            MessageBox.Show("Successfully generate key\nTime for key generation: " + time.ToString() + " ms");

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtPubKeyEncrypt.Text == "" || txtPlainFileEncrypt.Text == "" || txtCipherFileEncrypt.Text == "")
            {
                MessageBox.Show("Please enter complete information");
                return;
            }
            if (cbFormatEncrypt.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose format");
                return;
            }
            double time = 0;
            try
            {
                time = RSAencrypt(cbFormatEncrypt.SelectedItem.ToString(), txtPubKeyEncrypt.Text,
                    txtPlainFileEncrypt.Text, txtCipherFileEncrypt.Text);
            }
            catch
            {
                MessageBox.Show("Fail to encrypt");
                return;
            }
            MessageBox.Show("Successfully encrypt\nTime for encryption: " + time.ToString() + " ms");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtPriKeyDecrypt.Text == "" || txtRecoveredFileDecrypt.Text == "" || txtCipherFileDecrypt.Text == "")
            {
                MessageBox.Show("Please enter complete information");
                return;
            }
            if (cbFormatDecrypt.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose format");
                return;
            }
            double time = 0;
            try
            {
                time = RSAdecrypt(cbFormatDecrypt.SelectedItem.ToString(), txtPriKeyDecrypt.Text,
                    txtCipherFileDecrypt.Text, txtRecoveredFileDecrypt.Text);
            }
            catch
            {
                MessageBox.Show("Fail to decrypt");
                return;
            }
            MessageBox.Show("Successfully encrypt\nTime for encryption: " + time.ToString() + " ms");
            FileStream fs = new FileStream(txtRecoveredFileDecrypt.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            rtbRecoveredText.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}