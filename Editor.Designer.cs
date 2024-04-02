namespace VizeCalisma
{
    partial class Editor
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
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnFarkliKaydet = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMetin
            // 
            this.tbMetin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMetin.Location = new System.Drawing.Point(0, 46);
            this.tbMetin.Multiline = true;
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(659, 404);
            this.tbMetin.TabIndex = 0;
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBold.Location = new System.Drawing.Point(12, 12);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(41, 28);
            this.btnBold.TabIndex = 1;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItalic.Location = new System.Drawing.Point(58, 12);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(41, 28);
            this.btnItalic.TabIndex = 2;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFont.Location = new System.Drawing.Point(104, 12);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(64, 28);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(320, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 28);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnFarkliKaydet
            // 
            this.btnFarkliKaydet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFarkliKaydet.Location = new System.Drawing.Point(413, 12);
            this.btnFarkliKaydet.Name = "btnFarkliKaydet";
            this.btnFarkliKaydet.Size = new System.Drawing.Size(126, 28);
            this.btnFarkliKaydet.TabIndex = 5;
            this.btnFarkliKaydet.Text = "Farklı Kaydet";
            this.btnFarkliKaydet.UseVisualStyleBackColor = true;
            this.btnFarkliKaydet.Click += new System.EventHandler(this.btnFarkliKaydet_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenk.Location = new System.Drawing.Point(173, 12);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(64, 28);
            this.btnRenk.TabIndex = 6;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnAc
            // 
            this.btnAc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAc.Location = new System.Drawing.Point(242, 12);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(72, 28);
            this.btnAc.TabIndex = 7;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnFarkliKaydet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.tbMetin);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnFarkliKaydet;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnAc;
    }
}