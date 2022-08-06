
namespace Decimation_Method_v2
{
    partial class DecimationMethodMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HowToBut = new System.Windows.Forms.Button();
            this.OddIntervalCom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearBut = new System.Windows.Forms.Button();
            this.AssignBut = new System.Windows.Forms.Button();
            this.DecryptionRadio = new System.Windows.Forms.RadioButton();
            this.EncryptionRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LanguageOptionCom = new System.Windows.Forms.ComboBox();
            this.MessageOutputRich = new System.Windows.Forms.RichTextBox();
            this.MessageInputRich = new System.Windows.Forms.RichTextBox();
            this.MessageOfKeyAlphabet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = " Aksi Takdirde Sonuç Yanlış Çıkacaktır veya Hata Mesajı ile Karşılaşacaksınız.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(665, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Hata Aldığınızda veya İşlemi Tamamladığınızda Temizle Butonunu Kullandıktan Sonra" +
    ", Tekrar Aynı İşlemi veya Farklı Bir İşlemi Yapabilirsiziniz.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "- Kurallar -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(792, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Şeçtiginiz Dildeki Alfabe Harflerinden Başka Harf Girmeyin. Örneğin: Dil Türkçe S" +
    "eçilip \"x, w ,q\" Gibi Karakterleri veya  Dil İngilizce Seçilip \"ö,ü,ı\" gibi Harf" +
    "leri Girmeyiniz.";
            // 
            // HowToBut
            // 
            this.HowToBut.Location = new System.Drawing.Point(471, 348);
            this.HowToBut.Name = "HowToBut";
            this.HowToBut.Size = new System.Drawing.Size(203, 52);
            this.HowToBut.TabIndex = 38;
            this.HowToBut.Text = "- Yöntem Hakkında Bilgi İçin Tıklayın -";
            this.HowToBut.UseVisualStyleBackColor = true;
            this.HowToBut.Click += new System.EventHandler(this.HowToBut_Click);
            // 
            // OddIntervalCom
            // 
            this.OddIntervalCom.FormattingEnabled = true;
            this.OddIntervalCom.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.OddIntervalCom.Location = new System.Drawing.Point(500, 174);
            this.OddIntervalCom.Name = "OddIntervalCom";
            this.OddIntervalCom.Size = new System.Drawing.Size(121, 21);
            this.OddIntervalCom.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Odd Interval..:";
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(442, 259);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(120, 70);
            this.ClearBut.TabIndex = 35;
            this.ClearBut.Text = "Temizle";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // AssignBut
            // 
            this.AssignBut.Location = new System.Drawing.Point(599, 259);
            this.AssignBut.Name = "AssignBut";
            this.AssignBut.Size = new System.Drawing.Size(120, 70);
            this.AssignBut.TabIndex = 34;
            this.AssignBut.Text = "İşlem";
            this.AssignBut.UseVisualStyleBackColor = true;
            this.AssignBut.Click += new System.EventHandler(this.AssignBut_Click);
            // 
            // DecryptionRadio
            // 
            this.DecryptionRadio.AutoSize = true;
            this.DecryptionRadio.Location = new System.Drawing.Point(536, 203);
            this.DecryptionRadio.Name = "DecryptionRadio";
            this.DecryptionRadio.Size = new System.Drawing.Size(66, 17);
            this.DecryptionRadio.TabIndex = 32;
            this.DecryptionRadio.TabStop = true;
            this.DecryptionRadio.Text = "Deşifrele";
            this.DecryptionRadio.UseVisualStyleBackColor = true;
            // 
            // EncryptionRadio
            // 
            this.EncryptionRadio.AutoSize = true;
            this.EncryptionRadio.Location = new System.Drawing.Point(442, 203);
            this.EncryptionRadio.Name = "EncryptionRadio";
            this.EncryptionRadio.Size = new System.Drawing.Size(54, 17);
            this.EncryptionRadio.TabIndex = 31;
            this.EncryptionRadio.TabStop = true;
            this.EncryptionRadio.Text = "Şifrele";
            this.EncryptionRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dil Şeçiniz..:";
            // 
            // LanguageOptionCom
            // 
            this.LanguageOptionCom.FormattingEnabled = true;
            this.LanguageOptionCom.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.LanguageOptionCom.Location = new System.Drawing.Point(500, 134);
            this.LanguageOptionCom.Name = "LanguageOptionCom";
            this.LanguageOptionCom.Size = new System.Drawing.Size(121, 21);
            this.LanguageOptionCom.TabIndex = 29;
            // 
            // MessageOutputRich
            // 
            this.MessageOutputRich.Location = new System.Drawing.Point(108, 335);
            this.MessageOutputRich.Name = "MessageOutputRich";
            this.MessageOutputRich.ReadOnly = true;
            this.MessageOutputRich.Size = new System.Drawing.Size(232, 120);
            this.MessageOutputRich.TabIndex = 28;
            this.MessageOutputRich.Text = "";
            // 
            // MessageInputRich
            // 
            this.MessageInputRich.Location = new System.Drawing.Point(108, 200);
            this.MessageInputRich.Name = "MessageInputRich";
            this.MessageInputRich.Size = new System.Drawing.Size(232, 96);
            this.MessageInputRich.TabIndex = 27;
            this.MessageInputRich.Text = "";
            // 
            // MessageOfKeyAlphabet
            // 
            this.MessageOfKeyAlphabet.Location = new System.Drawing.Point(108, 150);
            this.MessageOfKeyAlphabet.Name = "MessageOfKeyAlphabet";
            this.MessageOfKeyAlphabet.Size = new System.Drawing.Size(232, 20);
            this.MessageOfKeyAlphabet.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "- Açık / Şifreli Mesaj Çıkış -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "- Açık / Şifreli Mesaj Girişi -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "- Anahtar Alfabe İçin  Mesaj -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Küçük Harf Harici (Büyük Harf ,Boşluk, Sayı ve Sembol Gibi) Veri Girmeyiniz, Giri" +
    "lmesi Gereken Alanları Boş Geçmeyiniz...";
            // 
            // DecimationMethodMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HowToBut);
            this.Controls.Add(this.OddIntervalCom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.AssignBut);
            this.Controls.Add(this.DecryptionRadio);
            this.Controls.Add(this.EncryptionRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LanguageOptionCom);
            this.Controls.Add(this.MessageOutputRich);
            this.Controls.Add(this.MessageInputRich);
            this.Controls.Add(this.MessageOfKeyAlphabet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DecimationMethodMainMenu";
            this.Text = "Decimation Method Şifrelemesi Author..:Burak GENÇ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button HowToBut;
        private System.Windows.Forms.ComboBox OddIntervalCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Button AssignBut;
        private System.Windows.Forms.RadioButton DecryptionRadio;
        private System.Windows.Forms.RadioButton EncryptionRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LanguageOptionCom;
        private System.Windows.Forms.RichTextBox MessageInputRich;
        private System.Windows.Forms.TextBox MessageOfKeyAlphabet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MessageOutputRich;
    }
}