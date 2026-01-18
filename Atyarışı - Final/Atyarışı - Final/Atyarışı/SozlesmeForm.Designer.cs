namespace Atyarışı
{
    partial class SozlesmeForm
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
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.chkKabul = new System.Windows.Forms.CheckBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMetin
            // 
            this.rtbMetin.BackColor = System.Drawing.Color.AliceBlue;
            this.rtbMetin.Location = new System.Drawing.Point(39, 23);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.ReadOnly = true;
            this.rtbMetin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMetin.Size = new System.Drawing.Size(690, 322);
            this.rtbMetin.TabIndex = 0;
            this.rtbMetin.Text = "";
            // 
            // chkKabul
            // 
            this.chkKabul.AutoSize = true;
            this.chkKabul.Location = new System.Drawing.Point(253, 351);
            this.chkKabul.Name = "chkKabul";
            this.chkKabul.Size = new System.Drawing.Size(308, 20);
            this.chkKabul.TabIndex = 1;
            this.chkKabul.Text = "\"Kuralları okudum, anladım ve kabul ediyorum.\"";
            this.chkKabul.UseVisualStyleBackColor = true;
            this.chkKabul.CheckedChanged += new System.EventHandler(this.chkKabul_CheckedChanged);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Enabled = false;
            this.btnOnayla.Location = new System.Drawing.Point(311, 388);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(158, 50);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "\"SÖZLEŞMEYİ ONAYLA\"";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // SozlesmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.chkKabul);
            this.Controls.Add(this.rtbMetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SozlesmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Sözleşmesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.CheckBox chkKabul;
        private System.Windows.Forms.Button btnOnayla;
    }
}