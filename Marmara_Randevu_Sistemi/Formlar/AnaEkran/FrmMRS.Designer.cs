
namespace Marmara_Randevu_Sistemi
{
    partial class FrmMRS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMRS));
            this.pbxKapat = new System.Windows.Forms.PictureBox();
            this.pbxKimlik = new System.Windows.Forms.PictureBox();
            this.pbxParola = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnHatirlamiyorum = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKimlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxKapat
            // 
            this.pbxKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxKapat.Image = ((System.Drawing.Image)(resources.GetObject("pbxKapat.Image")));
            this.pbxKapat.Location = new System.Drawing.Point(538, 16);
            this.pbxKapat.Name = "pbxKapat";
            this.pbxKapat.Size = new System.Drawing.Size(32, 32);
            this.pbxKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKapat.TabIndex = 0;
            this.pbxKapat.TabStop = false;
            this.toolTip.SetToolTip(this.pbxKapat, "Kapat");
            this.pbxKapat.Click += new System.EventHandler(this.pbxKapat_Click);
            this.pbxKapat.MouseLeave += new System.EventHandler(this.pbxKapat_MouseLeave);
            this.pbxKapat.MouseHover += new System.EventHandler(this.pbxKapat_MouseHover);
            // 
            // pbxKimlik
            // 
            this.pbxKimlik.Image = ((System.Drawing.Image)(resources.GetObject("pbxKimlik.Image")));
            this.pbxKimlik.Location = new System.Drawing.Point(198, 117);
            this.pbxKimlik.Name = "pbxKimlik";
            this.pbxKimlik.Size = new System.Drawing.Size(32, 32);
            this.pbxKimlik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKimlik.TabIndex = 1;
            this.pbxKimlik.TabStop = false;
            this.toolTip.SetToolTip(this.pbxKimlik, "T.C. Kimlik No");
            this.pbxKimlik.Click += new System.EventHandler(this.pbxKimlik_Click);
            // 
            // pbxParola
            // 
            this.pbxParola.Image = ((System.Drawing.Image)(resources.GetObject("pbxParola.Image")));
            this.pbxParola.Location = new System.Drawing.Point(198, 176);
            this.pbxParola.Name = "pbxParola";
            this.pbxParola.Size = new System.Drawing.Size(32, 32);
            this.pbxParola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxParola.TabIndex = 2;
            this.pbxParola.TabStop = false;
            this.toolTip.SetToolTip(this.pbxParola, "Parola");
            this.pbxParola.Click += new System.EventHandler(this.pbxParola_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(198, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParola.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.ForeColor = System.Drawing.Color.White;
            this.txtParola.Location = new System.Drawing.Point(236, 187);
            this.txtParola.MaxLength = 32;
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(162, 18);
            this.txtParola.TabIndex = 5;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(198, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 4;
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtKimlikNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKimlikNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKimlikNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKimlikNo.ForeColor = System.Drawing.Color.White;
            this.txtKimlikNo.Location = new System.Drawing.Point(236, 129);
            this.txtKimlikNo.MaxLength = 11;
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(162, 18);
            this.txtKimlikNo.TabIndex = 4;
            this.txtKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimlikNo_KeyPress);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(198, 232);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(98, 33);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.toolTip.SetToolTip(this.btnGirisYap, "Giriş Yap");
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeOl.FlatAppearance.BorderSize = 0;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUyeOl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.ForeColor = System.Drawing.Color.White;
            this.btnUyeOl.Location = new System.Drawing.Point(300, 232);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(98, 33);
            this.btnUyeOl.TabIndex = 7;
            this.btnUyeOl.Text = "Üye Ol";
            this.toolTip.SetToolTip(this.btnUyeOl, "Üye Ol");
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // btnHatirlamiyorum
            // 
            this.btnHatirlamiyorum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnHatirlamiyorum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHatirlamiyorum.FlatAppearance.BorderSize = 0;
            this.btnHatirlamiyorum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHatirlamiyorum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHatirlamiyorum.ForeColor = System.Drawing.Color.White;
            this.btnHatirlamiyorum.Location = new System.Drawing.Point(198, 271);
            this.btnHatirlamiyorum.Name = "btnHatirlamiyorum";
            this.btnHatirlamiyorum.Size = new System.Drawing.Size(200, 33);
            this.btnHatirlamiyorum.TabIndex = 10;
            this.btnHatirlamiyorum.Text = "Hatırlamıyorum";
            this.toolTip.SetToolTip(this.btnHatirlamiyorum, "Hatırlamıyorum");
            this.btnHatirlamiyorum.UseVisualStyleBackColor = false;
            this.btnHatirlamiyorum.Click += new System.EventHandler(this.btnHatirlamiyorum_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 317);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 1);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(571, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 317);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(12, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(560, 1);
            this.panel7.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(251, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MRS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marmara Randevu Sistemi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMRS
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnHatirlamiyorum);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxParola);
            this.Controls.Add(this.pbxKimlik);
            this.Controls.Add(this.pbxKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marmara Randevu Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKimlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxKapat;
        private System.Windows.Forms.PictureBox pbxKimlik;
        private System.Windows.Forms.PictureBox pbxParola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Button btnHatirlamiyorum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
    }
}

