namespace _233302071SelcukDİNC
{
    partial class Form1
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
            this.tbCihazIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbCihazId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBaglantiSifre = new System.Windows.Forms.TextBox();
            this.clbKulList = new System.Windows.Forms.CheckedListBox();
            this.cbBagTip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCihazIsim
            // 
            this.tbCihazIsim.Location = new System.Drawing.Point(250, 22);
            this.tbCihazIsim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCihazIsim.Name = "tbCihazIsim";
            this.tbCihazIsim.Size = new System.Drawing.Size(149, 22);
            this.tbCihazIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cihaz İsmi*:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(324, 231);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbCihazId
            // 
            this.tbCihazId.Location = new System.Drawing.Point(250, 54);
            this.tbCihazId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCihazId.Name = "tbCihazId";
            this.tbCihazId.Size = new System.Drawing.Size(149, 22);
            this.tbCihazId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cihaz Id*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cihaz Şifre*:";
            // 
            // tbBaglantiSifre
            // 
            this.tbBaglantiSifre.Location = new System.Drawing.Point(250, 86);
            this.tbBaglantiSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBaglantiSifre.Name = "tbBaglantiSifre";
            this.tbBaglantiSifre.Size = new System.Drawing.Size(149, 22);
            this.tbBaglantiSifre.TabIndex = 5;
            this.tbBaglantiSifre.TextChanged += new System.EventHandler(this.tbBaglantiSifre_TextChanged);
            // 
            // clbKulList
            // 
            this.clbKulList.FormattingEnabled = true;
            this.clbKulList.Items.AddRange(new object[] {
            "Kullanıcı 1",
            "Kullanıcı 2",
            "Kullanıcı 3"});
            this.clbKulList.Location = new System.Drawing.Point(250, 147);
            this.clbKulList.Name = "clbKulList";
            this.clbKulList.Size = new System.Drawing.Size(149, 55);
            this.clbKulList.TabIndex = 7;
            // 
            // cbBagTip
            // 
            this.cbBagTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBagTip.FormattingEnabled = true;
            this.cbBagTip.Location = new System.Drawing.Point(250, 118);
            this.cbBagTip.Name = "cbBagTip";
            this.cbBagTip.Size = new System.Drawing.Size(149, 22);
            this.cbBagTip.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bağlantı Tipi*:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(11, 323);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(56, 14);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Text = "Sonuç: ";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(108, 231);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kullanıcı Listesi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBagTip);
            this.Controls.Add(this.clbKulList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBaglantiSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCihazId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCihazIsim);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cihaz Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCihazIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbCihazId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBaglantiSifre;
        private System.Windows.Forms.CheckedListBox clbKulList;
        private System.Windows.Forms.ComboBox cbBagTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label5;
    }
}

