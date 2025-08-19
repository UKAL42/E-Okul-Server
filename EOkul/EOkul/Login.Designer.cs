namespace EOkul
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.GirisMiKayıtMı = new System.Windows.Forms.RadioButton();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // txtKAdi
            // 
            this.txtKAdi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtKAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKAdi.Location = new System.Drawing.Point(117, 77);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(157, 26);
            this.txtKAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(117, 109);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.Size = new System.Drawing.Size(157, 26);
            this.txtSifre.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(3, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(271, 33);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Giriş";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.GirisMiKayıtMı);
            this.pnlMain.Controls.Add(this.lblBaslik);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnSubmit);
            this.pnlMain.Controls.Add(this.txtKAdi);
            this.pnlMain.Controls.Add(this.txtSifre);
            this.pnlMain.Location = new System.Drawing.Point(73, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(279, 483);
            this.pnlMain.TabIndex = 5;
            // 
            // GirisMiKayıtMı
            // 
            this.GirisMiKayıtMı.AutoSize = true;
            this.GirisMiKayıtMı.BackColor = System.Drawing.Color.Transparent;
            this.GirisMiKayıtMı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisMiKayıtMı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisMiKayıtMı.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GirisMiKayıtMı.Location = new System.Drawing.Point(72, 232);
            this.GirisMiKayıtMı.Name = "GirisMiKayıtMı";
            this.GirisMiKayıtMı.Size = new System.Drawing.Size(123, 24);
            this.GirisMiKayıtMı.TabIndex = 7;
            this.GirisMiKayıtMı.Text = "Kayıtlı Değilim";
            this.GirisMiKayıtMı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GirisMiKayıtMı.UseVisualStyleBackColor = false;
            this.GirisMiKayıtMı.Click += new System.EventHandler(this.GirisMiKayıtMı_CheckedChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBaslik.Location = new System.Drawing.Point(100, 17);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(75, 31);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Giriş";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EOkul.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 507);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Okul Giriş / Kayıt";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.RadioButton GirisMiKayıtMı;
    }
}

