namespace AESCryptography
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void BtnEncprypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = TxtBoxFileNameInput.Text;
                string outputFile = TxtBoxFileNameOutput.Text;

                byte[] inputBytes = File.ReadAllBytes(inputFile);

                byte[] key = ParseKey(TxtBoxKey.Text);

                AESCrytography aes = new AESCrytography();

                byte[] outputBytes = aes.Encrypt(inputBytes, key);

                File.WriteAllBytes(outputFile, outputBytes);

                MessageBox.Show("Arquivo cifrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = TxtBoxFileNameInput.Text;
                string outputFile = TxtBoxFileNameOutput.Text;

                byte[] inputBytes = File.ReadAllBytes(inputFile);

                byte[] key = ParseKey(TxtBoxKey.Text);

                AESCrytography aes = new AESCrytography();

                byte[] outputBytes = aes.Decrypt(inputBytes, key);

                File.WriteAllBytes(outputFile, outputBytes);

                MessageBox.Show("Arquivo decifrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBoxFileName_Click(object sender, EventArgs e)
        {
            this.openFileArquivoEntrada.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.TxtBoxFileNameInput.Text = this.openFileArquivoEntrada.FileName;
        }

        private void TxtBoxFileNameOutput_Click(object sender, EventArgs e)
        {
            this.openFileArquivoSaida.ShowDialog();
        }

        private void openFileArquivoSaida_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.TxtBoxFileNameOutput.Text = this.openFileArquivoSaida.FileName;
        }

        private byte[] ParseKey(string keyText)
        {
            try
            {
                return keyText.Split(',')
                              .Select(x => Convert.ToByte(x.Trim()))
                              .ToArray();
            }
            catch
            {
                throw new Exception("Chave inválida");
            }
        }
    }
}
