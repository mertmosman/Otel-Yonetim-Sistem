namespace OtelYonetim
{
    partial class OturanForm
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
            txtId = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbTur = new ComboBox();
            cmbBagli = new ComboBox();
            btnEkle = new Button();
            lstOturanlar = new ListBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            lblTur = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.Cornsilk;
            txtId.Location = new Point(62, 85);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 27);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.Cornsilk;
            txtAd.Location = new Point(62, 118);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(165, 27);
            txtAd.TabIndex = 1;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.Cornsilk;
            txtSoyad.Location = new Point(62, 151);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(165, 27);
            txtSoyad.TabIndex = 2;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 88);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 121);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 4;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 151);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Soyad:";
            // 
            // cmbTur
            // 
            cmbTur.BackColor = Color.Cornsilk;
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(233, 85);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 6;
            cmbTur.SelectedIndexChanged += cmbTur_SelectedIndexChanged;
            // 
            // cmbBagli
            // 
            cmbBagli.BackColor = Color.Cornsilk;
            cmbBagli.FormattingEnabled = true;
            cmbBagli.Location = new Point(233, 184);
            cmbBagli.Name = "cmbBagli";
            cmbBagli.Size = new Size(151, 28);
            cmbBagli.TabIndex = 7;
            cmbBagli.SelectedIndexChanged += cmbBagli_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(6, 184);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstOturanlar
            // 
            lstOturanlar.BackColor = Color.Cornsilk;
            lstOturanlar.FormattingEnabled = true;
            lstOturanlar.Location = new Point(388, 88);
            lstOturanlar.Name = "lstOturanlar";
            lstOturanlar.Size = new Size(307, 144);
            lstOturanlar.TabIndex = 9;
            lstOturanlar.SelectedIndexChanged += lstOturanlar_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(72, 219);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9F);
            btnGuncelle.Location = new Point(133, 184);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTur.ForeColor = Color.MediumBlue;
            lblTur.Location = new Point(233, 60);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(149, 23);
            lblTur.TabIndex = 12;
            lblTur.Text = "KAYIT TURU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(388, 60);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 13;
            label4.Text = "KISILER:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(348, 26);
            label5.TabIndex = 14;
            label5.Text = "KISI OLUSTURMA SAYFASI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(38, 60);
            label6.Name = "label6";
            label6.Size = new Size(171, 23);
            label6.TabIndex = 15;
            label6.Text = "KISI BILGILERI";
            // 
            // OturanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(723, 289);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTur);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lstOturanlar);
            Controls.Add(btnEkle);
            Controls.Add(cmbBagli);
            Controls.Add(cmbTur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtId);
            Name = "OturanForm";
            Text = "OturanForm";
            Load += OturanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTur;
        private ComboBox cmbBagli;
        private Button btnEkle;
        private ListBox lstOturanlar;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblTur;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}