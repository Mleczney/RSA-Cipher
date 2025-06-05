namespace RSA
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
            GenerateKeysButton = new Button();
            EncryptButton = new Button();
            DecryptButton = new Button();
            InputTextBox = new TextBox();
            EncryptedTextBox = new TextBox();
            DecryptedTextBox = new TextBox();
            PublicKeyTextBox = new TextBox();
            PrivateKeyTextBox = new TextBox();
            dTextBox = new TextBox();
            eTextBox = new TextBox();
            nTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GenerateKeysButton
            // 
            GenerateKeysButton.BackColor = SystemColors.ActiveCaption;
            GenerateKeysButton.FlatStyle = FlatStyle.Flat;
            GenerateKeysButton.Location = new Point(678, 320);
            GenerateKeysButton.Name = "GenerateKeysButton";
            GenerateKeysButton.Size = new Size(110, 31);
            GenerateKeysButton.TabIndex = 0;
            GenerateKeysButton.Text = "Generate Keys";
            GenerateKeysButton.UseVisualStyleBackColor = false;
            GenerateKeysButton.Click += GenerateKeysButton_Click;
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = SystemColors.ActiveCaption;
            EncryptButton.FlatStyle = FlatStyle.Flat;
            EncryptButton.Location = new Point(12, 101);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(67, 66);
            EncryptButton.TabIndex = 1;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = SystemColors.ActiveCaption;
            DecryptButton.FlatStyle = FlatStyle.Flat;
            DecryptButton.Location = new Point(85, 101);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(69, 66);
            DecryptButton.TabIndex = 2;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = false;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 14);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(303, 23);
            InputTextBox.TabIndex = 3;
            // 
            // EncryptedTextBox
            // 
            EncryptedTextBox.Location = new Point(12, 43);
            EncryptedTextBox.Name = "EncryptedTextBox";
            EncryptedTextBox.Size = new Size(685, 23);
            EncryptedTextBox.TabIndex = 4;
            // 
            // DecryptedTextBox
            // 
            DecryptedTextBox.Location = new Point(12, 72);
            DecryptedTextBox.Name = "DecryptedTextBox";
            DecryptedTextBox.Size = new Size(303, 23);
            DecryptedTextBox.TabIndex = 5;
            // 
            // PublicKeyTextBox
            // 
            PublicKeyTextBox.Location = new Point(117, 386);
            PublicKeyTextBox.Name = "PublicKeyTextBox";
            PublicKeyTextBox.Size = new Size(274, 23);
            PublicKeyTextBox.TabIndex = 6;
            // 
            // PrivateKeyTextBox
            // 
            PrivateKeyTextBox.Location = new Point(117, 415);
            PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            PrivateKeyTextBox.Size = new Size(274, 23);
            PrivateKeyTextBox.TabIndex = 7;
            // 
            // dTextBox
            // 
            dTextBox.Location = new Point(446, 415);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(342, 23);
            dTextBox.TabIndex = 8;
            // 
            // eTextBox
            // 
            eTextBox.Location = new Point(446, 386);
            eTextBox.Name = "eTextBox";
            eTextBox.Size = new Size(342, 23);
            eTextBox.TabIndex = 9;
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(446, 357);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(342, 23);
            nTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 389);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 11;
            label1.Text = "Public Key (FULL)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 418);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 12;
            label2.Text = "Private Key (FULL)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(419, 360);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 13;
            label3.Text = "N:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(419, 389);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 14;
            label4.Text = "E:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(420, 418);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 15;
            label5.Text = "D:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(321, 17);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 16;
            label6.Text = "Input";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(703, 46);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 17;
            label7.Text = "Encrypted";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(321, 75);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 18;
            label8.Text = "Decrypted";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.concept_cyber_security_encryption_key_600nw_2267597197_ezgif_com_webp_to_jpg_converter;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nTextBox);
            Controls.Add(eTextBox);
            Controls.Add(dTextBox);
            Controls.Add(PrivateKeyTextBox);
            Controls.Add(PublicKeyTextBox);
            Controls.Add(DecryptedTextBox);
            Controls.Add(EncryptedTextBox);
            Controls.Add(InputTextBox);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(GenerateKeysButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateKeysButton;
        private Button EncryptButton;
        private Button DecryptButton;
        private TextBox InputTextBox;
        private TextBox EncryptedTextBox;
        private TextBox DecryptedTextBox;
        private TextBox PublicKeyTextBox;
        private TextBox PrivateKeyTextBox;
        private TextBox dTextBox;
        private TextBox eTextBox;
        private TextBox nTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}