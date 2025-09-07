namespace OtelYonetim
{
    partial class FitnessForm
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
            lstFitnessKullanicilar = new ListBox();
            btnFitnessKullan = new Button();
            lblkisi = new Label();
            SuspendLayout();
            // 
            // lstFitnessKullanicilar
            // 
            lstFitnessKullanicilar.FormattingEnabled = true;
            lstFitnessKullanicilar.Location = new Point(12, 38);
            lstFitnessKullanicilar.Name = "lstFitnessKullanicilar";
            lstFitnessKullanicilar.Size = new Size(371, 164);
            lstFitnessKullanicilar.TabIndex = 0;
            // 
            // btnFitnessKullan
            // 
            btnFitnessKullan.Location = new Point(12, 208);
            btnFitnessKullan.Name = "btnFitnessKullan";
            btnFitnessKullan.Size = new Size(129, 29);
            btnFitnessKullan.TabIndex = 1;
            btnFitnessKullan.Text = "Fitness Kullandır";
            btnFitnessKullan.UseVisualStyleBackColor = true;
            btnFitnessKullan.Click += btnFitnessKullan_Click;
            // 
            // lblkisi
            // 
            lblkisi.AutoSize = true;
            lblkisi.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblkisi.Location = new Point(12, 9);
            lblkisi.Name = "lblkisi";
            lblkisi.Size = new Size(371, 27);
            lblkisi.TabIndex = 2;
            lblkisi.Text = "KAYITLI FITNESS KULLANICILARI";
            // 
            // FitnessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(404, 253);
            Controls.Add(lblkisi);
            Controls.Add(btnFitnessKullan);
            Controls.Add(lstFitnessKullanicilar);
            Name = "FitnessForm";
            Text = "FitnessForm";
            Load += FitnessForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstFitnessKullanicilar;
        private Button btnFitnessKullan;
        private Label lblkisi;
    }
}