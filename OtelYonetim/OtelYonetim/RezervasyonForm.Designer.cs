namespace OtelYonetim
{
    partial class RezervasyonForm
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
            lstKisiler = new ListBox();
            lstMekanlar = new ListBox();
            dtBaslangic = new DateTimePicker();
            dtBitis = new DateTimePicker();
            btnRezerveEt = new Button();
            lstRezervasyonlar = new ListBox();
            btnRezervasyonSil = new Button();
            btnRezervasyonGuncelle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.Location = new Point(12, 109);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(207, 184);
            lstKisiler.TabIndex = 0;
            // 
            // lstMekanlar
            // 
            lstMekanlar.FormattingEnabled = true;
            lstMekanlar.Location = new Point(272, 109);
            lstMekanlar.Name = "lstMekanlar";
            lstMekanlar.Size = new Size(214, 184);
            lstMekanlar.TabIndex = 1;
            // 
            // dtBaslangic
            // 
            dtBaslangic.Location = new Point(246, 324);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new Size(250, 27);
            dtBaslangic.TabIndex = 2;
            // 
            // dtBitis
            // 
            dtBitis.Location = new Point(246, 372);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new Size(250, 27);
            dtBitis.TabIndex = 3;
            // 
            // btnRezerveEt
            // 
            btnRezerveEt.Location = new Point(392, 433);
            btnRezerveEt.Name = "btnRezerveEt";
            btnRezerveEt.Size = new Size(94, 29);
            btnRezerveEt.TabIndex = 4;
            btnRezerveEt.Text = "Rezerve Et";
            btnRezerveEt.UseVisualStyleBackColor = true;
            btnRezerveEt.Click += btnRezerveEt_Click;
            // 
            // lstRezervasyonlar
            // 
            lstRezervasyonlar.FormattingEnabled = true;
            lstRezervasyonlar.Location = new Point(551, 109);
            lstRezervasyonlar.Name = "lstRezervasyonlar";
            lstRezervasyonlar.Size = new Size(608, 404);
            lstRezervasyonlar.TabIndex = 5;
            lstRezervasyonlar.SelectedIndexChanged += lstRezervasyonlar_SelectedIndexChanged;
            // 
            // btnRezervasyonSil
            // 
            btnRezervasyonSil.Location = new Point(331, 480);
            btnRezervasyonSil.Name = "btnRezervasyonSil";
            btnRezervasyonSil.Size = new Size(94, 29);
            btnRezervasyonSil.TabIndex = 6;
            btnRezervasyonSil.Text = "Sil";
            btnRezervasyonSil.UseVisualStyleBackColor = true;
            btnRezervasyonSil.Click += btnRezervasyonSil_Click;
            // 
            // btnRezervasyonGuncelle
            // 
            btnRezervasyonGuncelle.Location = new Point(441, 480);
            btnRezervasyonGuncelle.Name = "btnRezervasyonGuncelle";
            btnRezervasyonGuncelle.Size = new Size(94, 29);
            btnRezervasyonGuncelle.TabIndex = 7;
            btnRezervasyonGuncelle.Text = "Güncelle";
            btnRezervasyonGuncelle.UseVisualStyleBackColor = true;
            btnRezervasyonGuncelle.Click += btnRezervasyonGuncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(2, 20);
            label1.Name = "label1";
            label1.Size = new Size(706, 32);
            label1.TabIndex = 8;
            label1.Text = "REZERVASYON TALEBI OLUSTURMA SEKMESI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(2, 80);
            label2.Name = "label2";
            label2.Size = new Size(228, 26);
            label2.TabIndex = 9;
            label2.Text = "KAYITLI KISILER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(246, 80);
            label3.Name = "label3";
            label3.Size = new Size(270, 26);
            label3.TabIndex = 10;
            label3.Text = "KAYITLI MEKANLAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(572, 80);
            label4.Name = "label4";
            label4.Size = new Size(564, 26);
            label4.TabIndex = 11;
            label4.Text = "OLUSTURULMUS REZERVASYON TALEPLERI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(21, 329);
            label5.Name = "label5";
            label5.Size = new Size(198, 20);
            label5.TabIndex = 12;
            label5.Text = "BASLANGIC TARIHI :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(81, 379);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 13;
            label6.Text = "BITIS TARIHI :";
            // 
            // RezervasyonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1210, 588);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRezervasyonGuncelle);
            Controls.Add(btnRezervasyonSil);
            Controls.Add(lstRezervasyonlar);
            Controls.Add(btnRezerveEt);
            Controls.Add(dtBitis);
            Controls.Add(dtBaslangic);
            Controls.Add(lstMekanlar);
            Controls.Add(lstKisiler);
            Name = "RezervasyonForm";
            Text = "RezervasyonForm";
            Load += RezervasyonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKisiler;
        private ListBox lstMekanlar;
        private DateTimePicker dtBaslangic;
        private DateTimePicker dtBitis;
        private Button btnRezerveEt;
        private ListBox lstRezervasyonlar;
        private Button btnRezervasyonSil;
        private Button btnRezervasyonGuncelle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}