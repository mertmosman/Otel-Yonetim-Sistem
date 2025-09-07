namespace OtelYonetim
{
    partial class HavuzForm
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
            btnHavuzKullan = new Button();
            lblKisi = new Label();
            SuspendLayout();
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.Location = new Point(12, 44);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(354, 224);
            lstKisiler.TabIndex = 0;
            // 
            // btnHavuzKullan
            // 
            btnHavuzKullan.Location = new Point(12, 274);
            btnHavuzKullan.Name = "btnHavuzKullan";
            btnHavuzKullan.Size = new Size(150, 29);
            btnHavuzKullan.TabIndex = 1;
            btnHavuzKullan.Text = "Havuzu Kullandır";
            btnHavuzKullan.UseVisualStyleBackColor = true;
            btnHavuzKullan.Click += btnHavuzKullan_Click;
            // 
            // lblKisi
            // 
            lblKisi.AutoSize = true;
            lblKisi.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKisi.Location = new Point(12, 14);
            lblKisi.Name = "lblKisi";
            lblKisi.Size = new Size(354, 27);
            lblKisi.TabIndex = 2;
            lblKisi.Text = "KAYITLI HAVUZ KULLANICILARI";
            // 
            // HavuzForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(383, 317);
            Controls.Add(lblKisi);
            Controls.Add(btnHavuzKullan);
            Controls.Add(lstKisiler);
            Name = "HavuzForm";
            Text = "HavuzForm";
            Load += HavuzForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKisiler;
        private Button btnHavuzKullan;
        private Label lblKisi;
    }
}