namespace OtelYonetim
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
            btnMekan = new Button();
            btnOturan = new Button();
            btnOdeme = new Button();
            btnHavuz = new Button();
            btnFitness = new Button();
            btnRezervasyonIslemleri = new Button();
            lstOdenmisRezervasyonlar = new ListBox();
            lstHavuzKullananlar = new ListBox();
            lstFitnessKullananlar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnMekan
            // 
            btnMekan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMekan.Location = new Point(11, 106);
            btnMekan.Name = "btnMekan";
            btnMekan.Size = new Size(129, 29);
            btnMekan.TabIndex = 0;
            btnMekan.Text = "Mekan İşlemleri";
            btnMekan.UseVisualStyleBackColor = true;
            btnMekan.Click += btnMekan_Click;
            // 
            // btnOturan
            // 
            btnOturan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOturan.Location = new Point(146, 106);
            btnOturan.Name = "btnOturan";
            btnOturan.Size = new Size(138, 29);
            btnOturan.TabIndex = 1;
            btnOturan.Text = "Oturan İşlemleri";
            btnOturan.UseVisualStyleBackColor = true;
            btnOturan.Click += btnOturan_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOdeme.Location = new Point(290, 106);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(134, 29);
            btnOdeme.TabIndex = 2;
            btnOdeme.Text = "Ödeme İşlemleri";
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // btnHavuz
            // 
            btnHavuz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHavuz.Location = new Point(700, 106);
            btnHavuz.Name = "btnHavuz";
            btnHavuz.Size = new Size(129, 29);
            btnHavuz.TabIndex = 3;
            btnHavuz.Text = "Havuz İşlemleri";
            btnHavuz.UseVisualStyleBackColor = true;
            btnHavuz.Click += btnHavuz_Click;
            // 
            // btnFitness
            // 
            btnFitness.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFitness.Location = new Point(565, 106);
            btnFitness.Name = "btnFitness";
            btnFitness.Size = new Size(129, 29);
            btnFitness.TabIndex = 4;
            btnFitness.Text = "Fitness işlemleri";
            btnFitness.UseVisualStyleBackColor = true;
            btnFitness.Click += btnFitness_Click;
            // 
            // btnRezervasyonIslemleri
            // 
            btnRezervasyonIslemleri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRezervasyonIslemleri.Location = new Point(430, 106);
            btnRezervasyonIslemleri.Name = "btnRezervasyonIslemleri";
            btnRezervasyonIslemleri.Size = new Size(129, 29);
            btnRezervasyonIslemleri.TabIndex = 5;
            btnRezervasyonIslemleri.Text = "Rezervasyonlar";
            btnRezervasyonIslemleri.UseVisualStyleBackColor = true;
            btnRezervasyonIslemleri.Click += button1_Click;
            // 
            // lstOdenmisRezervasyonlar
            // 
            lstOdenmisRezervasyonlar.FormattingEnabled = true;
            lstOdenmisRezervasyonlar.Location = new Point(12, 201);
            lstOdenmisRezervasyonlar.Name = "lstOdenmisRezervasyonlar";
            lstOdenmisRezervasyonlar.Size = new Size(803, 224);
            lstOdenmisRezervasyonlar.TabIndex = 6;
            // 
            // lstHavuzKullananlar
            // 
            lstHavuzKullananlar.FormattingEnabled = true;
            lstHavuzKullananlar.Location = new Point(12, 497);
            lstHavuzKullananlar.Name = "lstHavuzKullananlar";
            lstHavuzKullananlar.Size = new Size(398, 124);
            lstHavuzKullananlar.TabIndex = 7;
            // 
            // lstFitnessKullananlar
            // 
            lstFitnessKullananlar.FormattingEnabled = true;
            lstFitnessKullananlar.Location = new Point(416, 497);
            lstFitnessKullananlar.Name = "lstFitnessKullananlar";
            lstFitnessKullananlar.Size = new Size(399, 124);
            lstFitnessKullananlar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 39);
            label1.TabIndex = 9;
            label1.Text = "HOSGELDINIZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(64, 65);
            label2.Name = "label2";
            label2.Size = new Size(700, 26);
            label2.TabIndex = 10;
            label2.Text = "LUTFEN YAPMAK ISTEDIGINIZ ISLEM TURUNU SECINIZ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(11, 172);
            label3.Name = "label3";
            label3.Size = new Size(453, 26);
            label3.TabIndex = 11;
            label3.Text = "TAMAMLANMIS REZERVASYONLAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 468);
            label4.Name = "label4";
            label4.Size = new Size(216, 26);
            label4.TabIndex = 12;
            label4.Text = "HAVUZ RAPORU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(416, 468);
            label5.Name = "label5";
            label5.Size = new Size(232, 26);
            label5.TabIndex = 13;
            label5.Text = "FITNESS RAPORU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(832, 648);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstFitnessKullananlar);
            Controls.Add(lstHavuzKullananlar);
            Controls.Add(lstOdenmisRezervasyonlar);
            Controls.Add(btnRezervasyonIslemleri);
            Controls.Add(btnFitness);
            Controls.Add(btnHavuz);
            Controls.Add(btnOdeme);
            Controls.Add(btnOturan);
            Controls.Add(btnMekan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMekan;
        private Button btnOturan;
        private Button btnOdeme;
        private Button btnHavuz;
        private Button btnFitness;
        private Button btnRezervasyonIslemleri;
        private ListBox lstOdenmisRezervasyonlar;
        private ListBox lstHavuzKullananlar;
        private ListBox lstFitnessKullananlar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
