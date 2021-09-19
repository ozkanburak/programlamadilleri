
namespace pd
{
    partial class koklu4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(koklu4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl41 = new System.Windows.Forms.Label();
            this.tbxQ4BoyaliSAyi = new System.Windows.Forms.TextBox();
            this.tbxQ4Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 409);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(31, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam B. kare sayısı: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.button1.Location = new System.Drawing.Point(545, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(31, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boyalı kare sayısı: ";
            // 
            // lbl41
            // 
            this.lbl41.AutoSize = true;
            this.lbl41.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl41.Location = new System.Drawing.Point(361, 453);
            this.lbl41.Name = "lbl41";
            this.lbl41.Size = new System.Drawing.Size(75, 28);
            this.lbl41.TabIndex = 4;
            this.lbl41.Text = "Sonuç: ";
            // 
            // tbxQ4BoyaliSAyi
            // 
            this.tbxQ4BoyaliSAyi.Location = new System.Drawing.Point(235, 443);
            this.tbxQ4BoyaliSAyi.Name = "tbxQ4BoyaliSAyi";
            this.tbxQ4BoyaliSAyi.Size = new System.Drawing.Size(100, 20);
            this.tbxQ4BoyaliSAyi.TabIndex = 5;
            // 
            // tbxQ4Total
            // 
            this.tbxQ4Total.Location = new System.Drawing.Point(235, 485);
            this.tbxQ4Total.Name = "tbxQ4Total";
            this.tbxQ4Total.Size = new System.Drawing.Size(100, 20);
            this.tbxQ4Total.TabIndex = 6;
            // 
            // koklu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 581);
            this.Controls.Add(this.tbxQ4Total);
            this.Controls.Add(this.tbxQ4BoyaliSAyi);
            this.Controls.Add(this.lbl41);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "koklu4";
            this.Text = "koklu4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl41;
        private System.Windows.Forms.TextBox tbxQ4BoyaliSAyi;
        private System.Windows.Forms.TextBox tbxQ4Total;
    }
}