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
            this.openFileArquivo.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.TxtBoxFileName.Text = this.openFileArquivo.FileName;
        }
    }
}
