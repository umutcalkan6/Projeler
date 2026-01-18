namespace Atyarışı
{
    partial class Form3
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
            this.rtbGecmis = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbGecmis
            // 
            this.rtbGecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.rtbGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGecmis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGecmis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(199)))), ((int)(((byte)(90)))));
            this.rtbGecmis.Location = new System.Drawing.Point(0, 0);
            this.rtbGecmis.Name = "rtbGecmis";
            this.rtbGecmis.ReadOnly = true;
            this.rtbGecmis.Size = new System.Drawing.Size(1297, 547);
            this.rtbGecmis.TabIndex = 0;
            this.rtbGecmis.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(1139, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 35);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "GeçmişiTemizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 547);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.rtbGecmis);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGecmis;
        private System.Windows.Forms.Button btnTemizle;
    }
}