namespace VizeCalisma
{
    partial class CilginButon
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
            this.btnEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHayir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvet
            // 
            this.btnEvet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEvet.FlatAppearance.BorderSize = 0;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvet.Location = new System.Drawing.Point(281, 283);
            this.btnEvet.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(124, 48);
            this.btnEvet.TabIndex = 0;
            this.btnEvet.Text = "Evet!";
            this.btnEvet.UseVisualStyleBackColor = false;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            this.btnEvet.MouseEnter += new System.EventHandler(this.btnEvet_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyun oynayalım mı?";
            // 
            // btnHayir
            // 
            this.btnHayir.BackColor = System.Drawing.Color.LightCoral;
            this.btnHayir.FlatAppearance.BorderSize = 0;
            this.btnHayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayir.Location = new System.Drawing.Point(555, 283);
            this.btnHayir.Margin = new System.Windows.Forms.Padding(4);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(124, 48);
            this.btnHayir.TabIndex = 2;
            this.btnHayir.Text = "Hayır!";
            this.btnHayir.UseVisualStyleBackColor = false;
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = " (Yalnızca fare ile basın)";
            // 
            // CilginButon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1054, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvet);
            this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CilginButon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CilginButon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHayir;
        private System.Windows.Forms.Label label2;
    }
}