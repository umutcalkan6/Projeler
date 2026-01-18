namespace Atyarışı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAyakBilgisi = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.YarisiBaslat = new System.Windows.Forms.Button();
            this.GecmisYarislar = new System.Windows.Forms.Button();
            this.btnOnSozlesme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAd1 = new System.Windows.Forms.TextBox();
            this.txtAd4 = new System.Windows.Forms.TextBox();
            this.txtAd5 = new System.Windows.Forms.TextBox();
            this.txtAd3 = new System.Windows.Forms.TextBox();
            this.txtAd2 = new System.Windows.Forms.TextBox();
            this.cmbAt1 = new System.Windows.Forms.ComboBox();
            this.cmbAt5 = new System.Windows.Forms.ComboBox();
            this.cmbAt3 = new System.Windows.Forms.ComboBox();
            this.cmbAt4 = new System.Windows.Forms.ComboBox();
            this.cmbAt2 = new System.Windows.Forms.ComboBox();
            this.nudMiktar1 = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar5 = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar4 = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar3 = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar2 = new System.Windows.Forms.NumericUpDown();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.lblAyakBilgisi);
            this.panel1.Controls.Add(this.lblBakiye);
            this.panel1.Controls.Add(this.YarisiBaslat);
            this.panel1.Controls.Add(this.GecmisYarislar);
            this.panel1.Controls.Add(this.btnOnSozlesme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 571);
            this.panel1.TabIndex = 0;
            // 
            // lblAyakBilgisi
            // 
            this.lblAyakBilgisi.BackColor = System.Drawing.Color.Gray;
            this.lblAyakBilgisi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyakBilgisi.ForeColor = System.Drawing.Color.Red;
            this.lblAyakBilgisi.Location = new System.Drawing.Point(0, 372);
            this.lblAyakBilgisi.Name = "lblAyakBilgisi";
            this.lblAyakBilgisi.Size = new System.Drawing.Size(281, 86);
            this.lblAyakBilgisi.TabIndex = 5;
            this.lblAyakBilgisi.Text = "          1. AYAK";
            this.lblAyakBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBakiye
            // 
            this.lblBakiye.BackColor = System.Drawing.Color.SeaGreen;
            this.lblBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBakiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.Yellow;
            this.lblBakiye.Location = new System.Drawing.Point(0, 291);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(281, 81);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "BAKİYE";
            // 
            // YarisiBaslat
            // 
            this.YarisiBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.YarisiBaslat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YarisiBaslat.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YarisiBaslat.ForeColor = System.Drawing.Color.White;
            this.YarisiBaslat.Location = new System.Drawing.Point(0, 484);
            this.YarisiBaslat.Name = "YarisiBaslat";
            this.YarisiBaslat.Size = new System.Drawing.Size(281, 87);
            this.YarisiBaslat.TabIndex = 3;
            this.YarisiBaslat.Text = "YARIŞI BAŞLAT";
            this.YarisiBaslat.UseVisualStyleBackColor = false;
            this.YarisiBaslat.Click += new System.EventHandler(this.btnYarisiBaslat_Click);
            // 
            // GecmisYarislar
            // 
            this.GecmisYarislar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.GecmisYarislar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GecmisYarislar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GecmisYarislar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GecmisYarislar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GecmisYarislar.Location = new System.Drawing.Point(0, 196);
            this.GecmisYarislar.Name = "GecmisYarislar";
            this.GecmisYarislar.Size = new System.Drawing.Size(281, 101);
            this.GecmisYarislar.TabIndex = 2;
            this.GecmisYarislar.Text = "GEÇMİŞ YARIŞLAR";
            this.GecmisYarislar.UseVisualStyleBackColor = false;
            this.GecmisYarislar.Click += new System.EventHandler(this.GecmisYarislar_Click);
            // 
            // btnOnSozlesme
            // 
            this.btnOnSozlesme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnOnSozlesme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOnSozlesme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOnSozlesme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnSozlesme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnSozlesme.Location = new System.Drawing.Point(0, 98);
            this.btnOnSozlesme.Name = "btnOnSozlesme";
            this.btnOnSozlesme.Size = new System.Drawing.Size(281, 98);
            this.btnOnSozlesme.TabIndex = 1;
            this.btnOnSozlesme.Text = "ÖN SÖZLEŞME";
            this.btnOnSozlesme.UseVisualStyleBackColor = false;
            this.btnOnSozlesme.Click += new System.EventHandler(this.btnOnSozlesme_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "fehmiKing.net";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightBlue;
            this.label4.Location = new System.Drawing.Point(428, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Katılımcılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(1118, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(807, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Atlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(320, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "2.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(320, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "1.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(320, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "4.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(320, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "5.";
            // 
            // txtAd1
            // 
            this.txtAd1.Location = new System.Drawing.Point(402, 64);
            this.txtAd1.Name = "txtAd1";
            this.txtAd1.Size = new System.Drawing.Size(174, 22);
            this.txtAd1.TabIndex = 14;
            // 
            // txtAd4
            // 
            this.txtAd4.Location = new System.Drawing.Point(402, 337);
            this.txtAd4.Name = "txtAd4";
            this.txtAd4.Size = new System.Drawing.Size(174, 22);
            this.txtAd4.TabIndex = 17;
            // 
            // txtAd5
            // 
            this.txtAd5.Location = new System.Drawing.Point(402, 436);
            this.txtAd5.Name = "txtAd5";
            this.txtAd5.Size = new System.Drawing.Size(174, 22);
            this.txtAd5.TabIndex = 18;
            // 
            // txtAd3
            // 
            this.txtAd3.Location = new System.Drawing.Point(402, 239);
            this.txtAd3.Name = "txtAd3";
            this.txtAd3.Size = new System.Drawing.Size(174, 22);
            this.txtAd3.TabIndex = 19;
            // 
            // txtAd2
            // 
            this.txtAd2.Location = new System.Drawing.Point(402, 148);
            this.txtAd2.Name = "txtAd2";
            this.txtAd2.Size = new System.Drawing.Size(174, 22);
            this.txtAd2.TabIndex = 20;
            // 
            // cmbAt1
            // 
            this.cmbAt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAt1.FormattingEnabled = true;
            this.cmbAt1.Location = new System.Drawing.Point(769, 64);
            this.cmbAt1.Name = "cmbAt1";
            this.cmbAt1.Size = new System.Drawing.Size(154, 24);
            this.cmbAt1.TabIndex = 21;
            // 
            // cmbAt5
            // 
            this.cmbAt5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAt5.FormattingEnabled = true;
            this.cmbAt5.Location = new System.Drawing.Point(769, 434);
            this.cmbAt5.Name = "cmbAt5";
            this.cmbAt5.Size = new System.Drawing.Size(154, 24);
            this.cmbAt5.TabIndex = 22;
            // 
            // cmbAt3
            // 
            this.cmbAt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAt3.FormattingEnabled = true;
            this.cmbAt3.Location = new System.Drawing.Point(769, 237);
            this.cmbAt3.Name = "cmbAt3";
            this.cmbAt3.Size = new System.Drawing.Size(154, 24);
            this.cmbAt3.TabIndex = 23;
            // 
            // cmbAt4
            // 
            this.cmbAt4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAt4.FormattingEnabled = true;
            this.cmbAt4.Location = new System.Drawing.Point(769, 333);
            this.cmbAt4.Name = "cmbAt4";
            this.cmbAt4.Size = new System.Drawing.Size(154, 24);
            this.cmbAt4.TabIndex = 24;
            // 
            // cmbAt2
            // 
            this.cmbAt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAt2.FormattingEnabled = true;
            this.cmbAt2.Location = new System.Drawing.Point(769, 143);
            this.cmbAt2.Name = "cmbAt2";
            this.cmbAt2.Size = new System.Drawing.Size(154, 24);
            this.cmbAt2.TabIndex = 25;
            // 
            // nudMiktar1
            // 
            this.nudMiktar1.Location = new System.Drawing.Point(1099, 62);
            this.nudMiktar1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudMiktar1.Name = "nudMiktar1";
            this.nudMiktar1.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar1.TabIndex = 26;
            // 
            // nudMiktar5
            // 
            this.nudMiktar5.Location = new System.Drawing.Point(1099, 436);
            this.nudMiktar5.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudMiktar5.Name = "nudMiktar5";
            this.nudMiktar5.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar5.TabIndex = 27;
            // 
            // nudMiktar4
            // 
            this.nudMiktar4.Location = new System.Drawing.Point(1099, 338);
            this.nudMiktar4.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudMiktar4.Name = "nudMiktar4";
            this.nudMiktar4.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar4.TabIndex = 28;
            // 
            // nudMiktar3
            // 
            this.nudMiktar3.Location = new System.Drawing.Point(1099, 244);
            this.nudMiktar3.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudMiktar3.Name = "nudMiktar3";
            this.nudMiktar3.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar3.TabIndex = 29;
            // 
            // nudMiktar2
            // 
            this.nudMiktar2.Location = new System.Drawing.Point(1099, 145);
            this.nudMiktar2.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudMiktar2.Name = "nudMiktar2";
            this.nudMiktar2.Size = new System.Drawing.Size(120, 22);
            this.nudMiktar2.TabIndex = 30;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.ForeColor = System.Drawing.Color.White;
            this.btnIstatistik.Location = new System.Drawing.Point(647, 497);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(376, 51);
            this.btnIstatistik.TabIndex = 6;
            this.btnIstatistik.Text = "At İstatistikleri";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1287, 571);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.nudMiktar2);
            this.Controls.Add(this.nudMiktar3);
            this.Controls.Add(this.nudMiktar4);
            this.Controls.Add(this.nudMiktar5);
            this.Controls.Add(this.nudMiktar1);
            this.Controls.Add(this.cmbAt2);
            this.Controls.Add(this.cmbAt4);
            this.Controls.Add(this.cmbAt3);
            this.Controls.Add(this.cmbAt5);
            this.Controls.Add(this.cmbAt1);
            this.Controls.Add(this.txtAd2);
            this.Controls.Add(this.txtAd3);
            this.Controls.Add(this.txtAd5);
            this.Controls.Add(this.txtAd4);
            this.Controls.Add(this.txtAd1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GecmisYarislar;
        private System.Windows.Forms.Button btnOnSozlesme;
        private System.Windows.Forms.Button YarisiBaslat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAd1;
        private System.Windows.Forms.TextBox txtAd4;
        private System.Windows.Forms.TextBox txtAd5;
        private System.Windows.Forms.TextBox txtAd3;
        private System.Windows.Forms.TextBox txtAd2;
        private System.Windows.Forms.ComboBox cmbAt1;
        private System.Windows.Forms.ComboBox cmbAt5;
        private System.Windows.Forms.ComboBox cmbAt3;
        private System.Windows.Forms.ComboBox cmbAt4;
        private System.Windows.Forms.ComboBox cmbAt2;
        private System.Windows.Forms.NumericUpDown nudMiktar1;
        private System.Windows.Forms.NumericUpDown nudMiktar5;
        private System.Windows.Forms.NumericUpDown nudMiktar4;
        private System.Windows.Forms.NumericUpDown nudMiktar3;
        private System.Windows.Forms.NumericUpDown nudMiktar2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAyakBilgisi;
        private System.Windows.Forms.Button btnIstatistik;
    }
}

