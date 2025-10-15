namespace AESCryptography
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtBoxKey = new TextBox();
            TxtBoxFileName = new TextBox();
            BtnEncprypt = new Button();
            BtnDecrypt = new Button();
            richTextBox1 = new RichTextBox();
            openFileArquivo = new OpenFileDialog();
            LabelChave = new Label();
            LabelArquivo = new Label();
            LabelOutput = new Label();
            SuspendLayout();
            // 
            // TxtBoxKey
            // 
            TxtBoxKey.Location = new Point(37, 76);
            TxtBoxKey.Name = "TxtBoxKey";
            TxtBoxKey.ReadOnly = true;
            TxtBoxKey.ScrollBars = ScrollBars.Vertical;
            TxtBoxKey.Size = new Size(532, 23);
            TxtBoxKey.TabIndex = 0;
            // 
            // TxtBoxFileName
            // 
            TxtBoxFileName.Cursor = Cursors.Hand;
            TxtBoxFileName.Location = new Point(37, 134);
            TxtBoxFileName.Name = "TxtBoxFileName";
            TxtBoxFileName.ReadOnly = true;
            TxtBoxFileName.Size = new Size(532, 23);
            TxtBoxFileName.TabIndex = 1;
            TxtBoxFileName.Click += TxtBoxFileName_Click;
            // 
            // BtnEncprypt
            // 
            BtnEncprypt.Location = new Point(122, 197);
            BtnEncprypt.Name = "BtnEncprypt";
            BtnEncprypt.Size = new Size(114, 47);
            BtnEncprypt.TabIndex = 3;
            BtnEncprypt.Text = "Encriptografar";
            BtnEncprypt.UseVisualStyleBackColor = true;
            BtnEncprypt.Click += BtnEncprypt_Click;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(353, 200);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(110, 44);
            BtnDecrypt.TabIndex = 4;
            BtnDecrypt.Text = "Descriptografar";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 278);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(532, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // openFileArquivo
            // 
            openFileArquivo.FileName = "openFileArquivo";
            openFileArquivo.FileOk += openFileDialog1_FileOk;
            // 
            // LabelChave
            // 
            LabelChave.AutoSize = true;
            LabelChave.Location = new Point(37, 58);
            LabelChave.Name = "LabelChave";
            LabelChave.Size = new Size(40, 15);
            LabelChave.TabIndex = 6;
            LabelChave.Text = "Chave";
            // 
            // LabelArquivo
            // 
            LabelArquivo.AutoSize = true;
            LabelArquivo.Location = new Point(37, 116);
            LabelArquivo.Name = "LabelArquivo";
            LabelArquivo.Size = new Size(49, 15);
            LabelArquivo.TabIndex = 7;
            LabelArquivo.Text = "Arquivo";
            // 
            // LabelOutput
            // 
            LabelOutput.AutoSize = true;
            LabelOutput.Location = new Point(37, 260);
            LabelOutput.Name = "LabelOutput";
            LabelOutput.Size = new Size(45, 15);
            LabelOutput.TabIndex = 8;
            LabelOutput.Text = "Output";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelOutput);
            Controls.Add(LabelArquivo);
            Controls.Add(LabelChave);
            Controls.Add(richTextBox1);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnEncprypt);
            Controls.Add(TxtBoxFileName);
            Controls.Add(TxtBoxKey);
            Name = "MainScreen";
            Text = "Form1";
            Load += MainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxKey;
        private TextBox TxtBoxFileName;
        private Button BtnEncprypt;
        private Button BtnDecrypt;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileArquivo;
        private Label LabelChave;
        private Label LabelArquivo;
        private Label LabelOutput;
    }
}
