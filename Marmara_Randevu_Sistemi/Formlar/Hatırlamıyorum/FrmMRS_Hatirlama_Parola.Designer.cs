
namespace Marmara_Randevu_Sistemi
{
    partial class FrmMRS_Hatirlama_Parola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMRS_Hatirlama_Parola));
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtParolaOnay = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbxKapat = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParolaKaydet = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParola.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.ForeColor = System.Drawing.Color.White;
            this.txtParola.Location = new System.Drawing.Point(173, 144);
            this.txtParola.MaxLength = 32;
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(212, 13);
            this.txtParola.TabIndex = 96;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 100;
            this.label4.Text = "Parola Onay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 99;
            this.label3.Text = "Parola";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(173, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 1);
            this.panel5.TabIndex = 98;
            // 
            // txtParolaOnay
            // 
            this.txtParolaOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtParolaOnay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParolaOnay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParolaOnay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParolaOnay.ForeColor = System.Drawing.Color.White;
            this.txtParolaOnay.Location = new System.Drawing.Point(173, 196);
            this.txtParolaOnay.MaxLength = 32;
            this.txtParolaOnay.Name = "txtParolaOnay";
            this.txtParolaOnay.Size = new System.Drawing.Size(212, 13);
            this.txtParolaOnay.TabIndex = 97;
            this.txtParolaOnay.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(173, 163);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 1);
            this.panel6.TabIndex = 96;
            // 
            // pbxKapat
            // 
            this.pbxKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxKapat.Image = ((System.Drawing.Image)(resources.GetObject("pbxKapat.Image")));
            this.pbxKapat.Location = new System.Drawing.Point(402, 16);
            this.pbxKapat.Name = "pbxKapat";
            this.pbxKapat.Size = new System.Drawing.Size(32, 32);
            this.pbxKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKapat.TabIndex = 95;
            this.pbxKapat.TabStop = false;
            this.toolTip.SetToolTip(this.pbxKapat, "Kapat");
            this.pbxKapat.Click += new System.EventHandler(this.pbxKapat_Click);
            this.pbxKapat.MouseLeave += new System.EventHandler(this.pbxKapat_MouseLeave);
            this.pbxKapat.MouseHover += new System.EventHandler(this.pbxKapat_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 1);
            this.panel4.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 1);
            this.panel3.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(437, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 342);
            this.panel2.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 342);
            this.panel1.TabIndex = 91;
            // 
            // btnParolaKaydet
            // 
            this.btnParolaKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnParolaKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParolaKaydet.FlatAppearance.BorderSize = 0;
            this.btnParolaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParolaKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParolaKaydet.ForeColor = System.Drawing.Color.White;
            this.btnParolaKaydet.Location = new System.Drawing.Point(185, 259);
            this.btnParolaKaydet.Name = "btnParolaKaydet";
            this.btnParolaKaydet.Size = new System.Drawing.Size(89, 28);
            this.btnParolaKaydet.TabIndex = 102;
            this.btnParolaKaydet.Text = "Kaydet";
            this.toolTip.SetToolTip(this.btnParolaKaydet, "Kaydet");
            this.btnParolaKaydet.UseVisualStyleBackColor = false;
            this.btnParolaKaydet.Click += new System.EventHandler(this.btnParolaKaydet_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            // 
            // FrmMRS_Hatirlama_Parola
            // 
            this.AcceptButton = this.btnParolaKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(450, 366);
            this.Controls.Add(this.btnParolaKaydet);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtParolaOnay);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pbxKapat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMRS_Hatirlama_Parola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMRS_Remember_Password";
            this.Load += new System.EventHandler(this.FrmMRS_Hatirlama_Parola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtParolaOnay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbxKapat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnParolaKaydet;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}