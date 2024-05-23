namespace task3_gui
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbFormatGenKey = new ComboBox();
            cbKeySizeGenKey = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPubKeyGenKey = new TextBox();
            txtPriKeyGenKey = new TextBox();
            btnGenKey = new Button();
            tabPage2 = new TabPage();
            label9 = new Label();
            txtCipherFileEncrypt = new TextBox();
            cbFormatEncrypt = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtPubKeyEncrypt = new TextBox();
            txtPlainFileEncrypt = new TextBox();
            btnEncrypt = new Button();
            tabPage3 = new TabPage();
            rtbRecoveredText = new RichTextBox();
            label6 = new Label();
            txtRecoveredFileDecrypt = new TextBox();
            cbFormatDecrypt = new ComboBox();
            label10 = new Label();
            labell = new Label();
            labelll = new Label();
            txtPriKeyDecrypt = new TextBox();
            txtCipherFileDecrypt = new TextBox();
            btnDecrypt = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1106, 815);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbFormatGenKey);
            tabPage1.Controls.Add(cbKeySizeGenKey);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtPubKeyGenKey);
            tabPage1.Controls.Add(txtPriKeyGenKey);
            tabPage1.Controls.Add(btnGenKey);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1098, 782);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate key";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbFormatGenKey
            // 
            cbFormatGenKey.FormattingEnabled = true;
            cbFormatGenKey.Items.AddRange(new object[] { "BER", "PEM" });
            cbFormatGenKey.Location = new Point(357, 307);
            cbFormatGenKey.Name = "cbFormatGenKey";
            cbFormatGenKey.Size = new Size(187, 28);
            cbFormatGenKey.TabIndex = 17;
            // 
            // cbKeySizeGenKey
            // 
            cbKeySizeGenKey.FormattingEnabled = true;
            cbKeySizeGenKey.Items.AddRange(new object[] { "3072", "4096" });
            cbKeySizeGenKey.Location = new Point(357, 215);
            cbKeySizeGenKey.Name = "cbKeySizeGenKey";
            cbKeySizeGenKey.Size = new Size(187, 28);
            cbKeySizeGenKey.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 315);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 15;
            label4.Text = "Format";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 223);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 14;
            label3.Text = "Key Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 130);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 13;
            label2.Text = "Public Key File";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 48);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 12;
            label1.Text = "Private Key File";
            // 
            // txtPubKeyGenKey
            // 
            txtPubKeyGenKey.Location = new Point(357, 122);
            txtPubKeyGenKey.Name = "txtPubKeyGenKey";
            txtPubKeyGenKey.Size = new Size(353, 28);
            txtPubKeyGenKey.TabIndex = 11;
            // 
            // txtPriKeyGenKey
            // 
            txtPriKeyGenKey.Location = new Point(357, 40);
            txtPriKeyGenKey.Name = "txtPriKeyGenKey";
            txtPriKeyGenKey.Size = new Size(353, 28);
            txtPriKeyGenKey.TabIndex = 10;
            // 
            // btnGenKey
            // 
            btnGenKey.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenKey.Location = new Point(480, 390);
            btnGenKey.Name = "btnGenKey";
            btnGenKey.Size = new Size(130, 62);
            btnGenKey.TabIndex = 9;
            btnGenKey.Text = "Gen Key";
            btnGenKey.UseVisualStyleBackColor = true;
            btnGenKey.Click += btnGenKey_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtCipherFileEncrypt);
            tabPage2.Controls.Add(cbFormatEncrypt);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtPubKeyEncrypt);
            tabPage2.Controls.Add(txtPlainFileEncrypt);
            tabPage2.Controls.Add(btnEncrypt);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1098, 782);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Encrypt";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 255);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 19;
            label9.Text = "Cipher File";
            // 
            // txtCipherFileEncrypt
            // 
            txtCipherFileEncrypt.Location = new Point(368, 247);
            txtCipherFileEncrypt.Name = "txtCipherFileEncrypt";
            txtCipherFileEncrypt.Size = new Size(353, 28);
            txtCipherFileEncrypt.TabIndex = 18;
            // 
            // cbFormatEncrypt
            // 
            cbFormatEncrypt.FormattingEnabled = true;
            cbFormatEncrypt.Items.AddRange(new object[] { "BER", "PEM" });
            cbFormatEncrypt.Location = new Point(368, 359);
            cbFormatEncrypt.Name = "cbFormatEncrypt";
            cbFormatEncrypt.Size = new Size(187, 28);
            cbFormatEncrypt.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 367);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 15;
            label5.Text = "Format";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 38);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 13;
            label7.Text = "Public Key File";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 140);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 12;
            label8.Text = "Plaintext File";
            // 
            // txtPubKeyEncrypt
            // 
            txtPubKeyEncrypt.Location = new Point(368, 30);
            txtPubKeyEncrypt.Name = "txtPubKeyEncrypt";
            txtPubKeyEncrypt.Size = new Size(353, 28);
            txtPubKeyEncrypt.TabIndex = 11;
            // 
            // txtPlainFileEncrypt
            // 
            txtPlainFileEncrypt.Location = new Point(368, 132);
            txtPlainFileEncrypt.Name = "txtPlainFileEncrypt";
            txtPlainFileEncrypt.Size = new Size(353, 28);
            txtPlainFileEncrypt.TabIndex = 10;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(513, 478);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(130, 62);
            btnEncrypt.TabIndex = 9;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rtbRecoveredText);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtRecoveredFileDecrypt);
            tabPage3.Controls.Add(cbFormatDecrypt);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(labell);
            tabPage3.Controls.Add(labelll);
            tabPage3.Controls.Add(txtPriKeyDecrypt);
            tabPage3.Controls.Add(txtCipherFileDecrypt);
            tabPage3.Controls.Add(btnDecrypt);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1098, 782);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Decrypt";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbRecoveredText
            // 
            rtbRecoveredText.Dock = DockStyle.Bottom;
            rtbRecoveredText.Location = new Point(0, 369);
            rtbRecoveredText.Name = "rtbRecoveredText";
            rtbRecoveredText.Size = new Size(1098, 413);
            rtbRecoveredText.TabIndex = 30;
            rtbRecoveredText.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 152);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 29;
            label6.Text = "Recovered File";
            // 
            // txtRecoveredFileDecrypt
            // 
            txtRecoveredFileDecrypt.Location = new Point(368, 144);
            txtRecoveredFileDecrypt.Name = "txtRecoveredFileDecrypt";
            txtRecoveredFileDecrypt.Size = new Size(353, 28);
            txtRecoveredFileDecrypt.TabIndex = 28;
            // 
            // cbFormatDecrypt
            // 
            cbFormatDecrypt.FormattingEnabled = true;
            cbFormatDecrypt.Items.AddRange(new object[] { "BER", "PEM" });
            cbFormatDecrypt.Location = new Point(368, 211);
            cbFormatDecrypt.Name = "cbFormatDecrypt";
            cbFormatDecrypt.Size = new Size(187, 28);
            cbFormatDecrypt.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 219);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 26;
            label10.Text = "Format";
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Location = new Point(193, 23);
            labell.Name = "labell";
            labell.Size = new Size(133, 20);
            labell.TabIndex = 25;
            labell.Text = "Private Key File";
            // 
            // labelll
            // 
            labelll.AutoSize = true;
            labelll.Location = new Point(187, 83);
            labelll.Name = "labelll";
            labelll.Size = new Size(95, 20);
            labelll.TabIndex = 24;
            labelll.Text = "Cipher File";
            // 
            // txtPriKeyDecrypt
            // 
            txtPriKeyDecrypt.Location = new Point(368, 15);
            txtPriKeyDecrypt.Name = "txtPriKeyDecrypt";
            txtPriKeyDecrypt.Size = new Size(353, 28);
            txtPriKeyDecrypt.TabIndex = 23;
            // 
            // txtCipherFileDecrypt
            // 
            txtCipherFileDecrypt.Location = new Point(368, 75);
            txtCipherFileDecrypt.Name = "txtCipherFileDecrypt";
            txtCipherFileDecrypt.Size = new Size(353, 28);
            txtCipherFileDecrypt.TabIndex = 22;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(502, 269);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(130, 62);
            btnDecrypt.TabIndex = 21;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 815);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cbFormatGenKey;
        private ComboBox cbKeySizeGenKey;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPubKeyGenKey;
        private TextBox txtPriKeyGenKey;
        private Button btnGenKey;
        private ComboBox cbFormatEncrypt;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtPubKeyEncrypt;
        private TextBox txtPlainFileEncrypt;
        private Button btnEncrypt;
        private Label label9;
        private TextBox txtCipherFileEncrypt;
        private RichTextBox rtbRecoveredText;
        private Label label6;
        private TextBox txtRecoveredFileDecrypt;
        private ComboBox cbFormatDecrypt;
        private Label label10;
        private Label labell;
        private Label labelll;
        private TextBox txtPriKeyDecrypt;
        private TextBox txtCipherFileDecrypt;
        private Button btnDecrypt;
    }
}