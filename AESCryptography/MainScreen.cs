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

        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {

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
    }
}
