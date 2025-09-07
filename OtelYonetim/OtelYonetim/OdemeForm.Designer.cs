namespace OtelYonetim
{
    partial class OdemeForm
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
            lstOdemeBekleyenler = new ListBox();
            btnOdemeYap = new Button();
            txtOdemeMiktari = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstOdemeBekleyenler
            // 
            lstOdemeBekleyenler.BackColor = Color.OldLace;
            lstOdemeBekleyenler.FormattingEnabled = true;
            lstOdemeBekleyenler.Location = new Point(12, 61);
            lstOdemeBekleyenler.Name = "lstOdemeBekleyenler";
            lstOdemeBekleyenler.Size = new Size(729, 144);
            lstOdemeBekleyenler.TabIndex = 0;
            lstOdemeBekleyenler.SelectedIndexChanged += lstOdemeBekleyenler_SelectedIndexChanged;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(408, 211);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(94, 29);
            btnOdemeYap.TabIndex = 1;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // txtOdemeMiktari
            // 
            txtOdemeMiktari.BackColor = Color.OldLace;
            txtOdemeMiktari.Location = new Point(277, 213);
            txtOdemeMiktari.Name = "txtOdemeMiktari";
            txtOdemeMiktari.Size = new Size(125, 27);
            txtOdemeMiktari.TabIndex = 2;
            txtOdemeMiktari.TextChanged += txtOdemeMiktari_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 3;
            label1.Text = "ÖDEME ALMA SAYFASI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(12, 216);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 4;
            label2.Text = "ÖDEME YAPILACAK TUTAR:";
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(800, 300);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOdemeMiktari);
            Controls.Add(btnOdemeYap);
            Controls.Add(lstOdemeBekleyenler);
            Name = "OdemeForm";
            Text = "OdemeForm";
            Load += OdemeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOdemeBekleyenler;
        private Button btnOdemeYap;
        private TextBox txtOdemeMiktari;
        private Label label1;
        private Label label2;
    }
}