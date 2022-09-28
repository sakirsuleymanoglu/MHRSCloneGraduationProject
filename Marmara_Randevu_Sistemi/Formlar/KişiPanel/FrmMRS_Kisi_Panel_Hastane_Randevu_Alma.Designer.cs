
namespace Marmara_Randevu_Sistemi
{
    partial class FrmMRS_Kisi_Panel_Hastane_Randevu_Alma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMRS_Kisi_Panel_Hastane_Randevu_Alma));
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxHastane = new System.Windows.Forms.ComboBox();
            this.cbxKlinik = new System.Windows.Forms.ComboBox();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.dgwRandevu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbxKapat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRandevuAlimTarihi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIl
            // 
            this.cbxIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxIl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxIl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxIl.FormattingEnabled = true;
            this.cbxIl.Location = new System.Drawing.Point(514, 80);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Size = new System.Drawing.Size(322, 22);
            this.cbxIl.TabIndex = 0;
            this.cbxIl.SelectedIndexChanged += new System.EventHandler(this.cbxIl_SelectedIndexChanged);
            // 
            // cbxIlce
            // 
            this.cbxIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIlce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxIlce.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxIlce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxIlce.FormattingEnabled = true;
            this.cbxIlce.Location = new System.Drawing.Point(514, 130);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Size = new System.Drawing.Size(322, 22);
            this.cbxIlce.TabIndex = 1;
            this.cbxIlce.SelectedIndexChanged += new System.EventHandler(this.cbxIlce_SelectedIndexChanged);
            // 
            // cbxHastane
            // 
            this.cbxHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHastane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxHastane.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxHastane.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxHastane.FormattingEnabled = true;
            this.cbxHastane.Location = new System.Drawing.Point(514, 180);
            this.cbxHastane.Name = "cbxHastane";
            this.cbxHastane.Size = new System.Drawing.Size(322, 22);
            this.cbxHastane.TabIndex = 2;
            this.cbxHastane.SelectedIndexChanged += new System.EventHandler(this.cbxHastane_SelectedIndexChanged);
            // 
            // cbxKlinik
            // 
            this.cbxKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKlinik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxKlinik.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxKlinik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxKlinik.FormattingEnabled = true;
            this.cbxKlinik.Location = new System.Drawing.Point(514, 230);
            this.cbxKlinik.Name = "cbxKlinik";
            this.cbxKlinik.Size = new System.Drawing.Size(322, 22);
            this.cbxKlinik.TabIndex = 3;
            this.cbxKlinik.SelectedIndexChanged += new System.EventHandler(this.cbxKlinik_SelectedIndexChanged);
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxDoktor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDoktor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Location = new System.Drawing.Point(514, 280);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(322, 22);
            this.cbxDoktor.TabIndex = 4;
            this.cbxDoktor.SelectedIndexChanged += new System.EventHandler(this.cbxDoktor_SelectedIndexChanged);
            // 
            // dgwRandevu
            // 
            this.dgwRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRandevu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgwRandevu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRandevu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRandevu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwRandevu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwRandevu.EnableHeadersVisualStyles = false;
            this.dgwRandevu.GridColor = System.Drawing.Color.Silver;
            this.dgwRandevu.Location = new System.Drawing.Point(52, 345);
            this.dgwRandevu.Name = "dgwRandevu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRandevu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwRandevu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwRandevu.Size = new System.Drawing.Size(1146, 293);
            this.dgwRandevu.TabIndex = 16;
            this.dgwRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRandevu_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1237, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 660);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 660);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 671);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1225, 1);
            this.panel4.TabIndex = 20;
            // 
            // pbxKapat
            // 
            this.pbxKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxKapat.Image = ((System.Drawing.Image)(resources.GetObject("pbxKapat.Image")));
            this.pbxKapat.Location = new System.Drawing.Point(1202, 18);
            this.pbxKapat.Name = "pbxKapat";
            this.pbxKapat.Size = new System.Drawing.Size(32, 32);
            this.pbxKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKapat.TabIndex = 21;
            this.pbxKapat.TabStop = false;
            this.pbxKapat.Click += new System.EventHandler(this.pbxKapat_Click);
            this.pbxKapat.MouseLeave += new System.EventHandler(this.pbxKapat_MouseLeave);
            this.pbxKapat.MouseHover += new System.EventHandler(this.pbxKapat_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Randevu Alım Tarihi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(514, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 1);
            this.panel5.TabIndex = 23;
            // 
            // lblRandevuAlimTarihi
            // 
            this.lblRandevuAlimTarihi.AutoSize = true;
            this.lblRandevuAlimTarihi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuAlimTarihi.ForeColor = System.Drawing.Color.Silver;
            this.lblRandevuAlimTarihi.Location = new System.Drawing.Point(511, 51);
            this.lblRandevuAlimTarihi.Name = "lblRandevuAlimTarihi";
            this.lblRandevuAlimTarihi.Size = new System.Drawing.Size(0, 14);
            this.lblRandevuAlimTarihi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "İl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(381, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(381, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hastane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(381, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Klinik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(381, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Doktor";
            // 
            // FrmMRS_Kisi_Panel_Hastane_Randevu_Alma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1250, 684);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRandevuAlimTarihi);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxKapat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwRandevu);
            this.Controls.Add(this.cbxDoktor);
            this.Controls.Add(this.cbxKlinik);
            this.Controls.Add(this.cbxHastane);
            this.Controls.Add(this.cbxIlce);
            this.Controls.Add(this.cbxIl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMRS_Kisi_Panel_Hastane_Randevu_Alma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMRS_Person_Panel_Appointmet_Get_Hospital";
            this.Load += new System.EventHandler(this.FrmMRS_Kisi_Panel_Hastane_Randevu_Alma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxHastane;
        private System.Windows.Forms.ComboBox cbxKlinik;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.DataGridView dgwRandevu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbxKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRandevuAlimTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}