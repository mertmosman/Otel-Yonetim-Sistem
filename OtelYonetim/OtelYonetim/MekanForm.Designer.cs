namespace OtelYonetim
{
    partial class MekanForm
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
            txtKonum = new TextBox();
            txtAd = new TextBox();
            txtId = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            lstMekanlar = new ListBox();
            cmbTur = new ComboBox();
            lblId = new Label();
            lblAd = new Label();
            lblKonum = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtKonum
            // 
            txtKonum.Location = new Point(95, 157);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(125, 27);
            txtKonum.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(95, 124);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(95, 92);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(9, 192);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(126, 192);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(65, 227);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lstMekanlar
            // 
            lstMekanlar.FormattingEnabled = true;
            lstMekanlar.Location = new Point(424, 92);
            lstMekanlar.Name = "lstMekanlar";
            lstMekanlar.Size = new Size(302, 224);
            lstMekanlar.TabIndex = 6;
            lstMekanlar.SelectedIndexChanged += lstMekanlar_SelectedIndexChanged;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(248, 90);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(65, 101);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 20);
            lblId.TabIndex = 9;
            lblId.Text = "ID:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAd.Location = new Point(2, 127);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(92, 20);
            lblAd.TabIndex = 10;
            lblAd.Text = "Mekan Adı: ";
            // 
            // lblKonum
            // 
            lblKonum.AutoSize = true;
            lblKonum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKonum.Location = new Point(30, 164);
            lblKonum.Name = "lblKonum";
            lblKonum.Size = new Size(64, 20);
            lblKonum.TabIndex = 11;
            lblKonum.Text = "Konum:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(424, 65);
            label1.Name = "label1";
            label1.Size = new Size(311, 23);
            label1.TabIndex = 12;
            label1.Text = "OLUSTURULAN MEKANLAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(248, 66);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 13;
            label2.Text = "MEKAN TURU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(387, 26);
            label3.TabIndex = 14;
            label3.Text = "MEKAN OLUSTURMA SAYFASI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(208, 23);
            label4.TabIndex = 15;
            label4.Text = "MEKAN BILGILERI";
            // 
            // MekanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(757, 345);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblKonum);
            Controls.Add(lblAd);
            Controls.Add(lblId);
            Controls.Add(cmbTur);
            Controls.Add(lstMekanlar);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtId);
            Controls.Add(txtAd);
            Controls.Add(txtKonum);
            Name = "MekanForm";
            Text = "MekanForm";
            Load += MekanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKonum;
        private TextBox txtAd;
        private TextBox txtId;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private ListBox lstMekanlar;
        private ComboBox cmbTur;
        private Label lblId;
        private Label lblAd;
        private Label lblKonum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}