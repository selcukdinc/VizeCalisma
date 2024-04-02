namespace VizeCalisma
{
    partial class KayitFormu
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUni = new System.Windows.Forms.ComboBox();
            this.clbHobi = new System.Windows.Forms.CheckedListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.mtbOgNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(130, 6);
            this.tbAdSoyad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(220, 27);
            this.tbAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad*:";
            // 
            // cbUni
            // 
            this.cbUni.FormattingEnabled = true;
            this.cbUni.Items.AddRange(new object[] {
            "Selçuk Üniversitesi",
            "Konya Teknik Üniversitesi",
            "KTO KaratayÜniversitesi"});
            this.cbUni.Location = new System.Drawing.Point(130, 109);
            this.cbUni.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbUni.Name = "cbUni";
            this.cbUni.Size = new System.Drawing.Size(220, 26);
            this.cbUni.TabIndex = 3;
            // 
            // clbHobi
            // 
            this.clbHobi.FormattingEnabled = true;
            this.clbHobi.Items.AddRange(new object[] {
            "Okçuluk",
            "BackEnd",
            "FrontEnd",
            "Full Stack Dev",
            "RPG",
            "Side Scroll",
            "Adventure",
            "Open World",
            "Violance",
            "Family-Friend",
            "Competitive",
            "Story"});
            this.clbHobi.Location = new System.Drawing.Point(130, 212);
            this.clbHobi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clbHobi.Name = "clbHobi";
            this.clbHobi.Size = new System.Drawing.Size(220, 114);
            this.clbHobi.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(20, 356);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 44);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Temizle";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğrenci No*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon No*:";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(130, 177);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(220, 27);
            this.tbAdres.TabIndex = 8;
            // 
            // mtbTelNo
            // 
            this.mtbTelNo.Location = new System.Drawing.Point(130, 75);
            this.mtbTelNo.Mask = "(999) 000-0000";
            this.mtbTelNo.Name = "mtbTelNo";
            this.mtbTelNo.Size = new System.Drawing.Size(139, 27);
            this.mtbTelNo.TabIndex = 10;
            // 
            // mtbOgNo
            // 
            this.mtbOgNo.Location = new System.Drawing.Point(130, 41);
            this.mtbOgNo.Mask = "000000000";
            this.mtbOgNo.Name = "mtbOgNo";
            this.mtbOgNo.Size = new System.Drawing.Size(99, 27);
            this.mtbOgNo.TabIndex = 11;
            this.mtbOgNo.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Üniversite*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bölüm*:";
            // 
            // cbBolum
            // 
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik - Elektronik Mühendisliği",
            "Makine MÜhendisliği",
            "Endüstri Mühendisliği"});
            this.cbBolum.Location = new System.Drawing.Point(130, 143);
            this.cbBolum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(220, 26);
            this.cbBolum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hobi(ler):";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(267, 356);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(102, 44);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 424);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbOgNo);
            this.Controls.Add(this.mtbTelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.clbHobi);
            this.Controls.Add(this.cbUni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdSoyad);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "KayitFormu";
            this.Text = "KayitFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUni;
        private System.Windows.Forms.CheckedListBox clbHobi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.MaskedTextBox mtbOgNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnkaydet;
    }
}