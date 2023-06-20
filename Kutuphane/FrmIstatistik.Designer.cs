
namespace Kutuphane
{
    partial class FrmIstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKitapSayı = new System.Windows.Forms.Label();
            this.lblRoman = new System.Windows.Forms.Label();
            this.lblHikaye = new System.Windows.Forms.Label();
            this.lblAnsiklopedi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roman Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hikaye sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ansiklopedi sayısı";
            // 
            // lblKitapSayı
            // 
            this.lblKitapSayı.AutoSize = true;
            this.lblKitapSayı.Location = new System.Drawing.Point(166, 93);
            this.lblKitapSayı.Name = "lblKitapSayı";
            this.lblKitapSayı.Size = new System.Drawing.Size(24, 17);
            this.lblKitapSayı.TabIndex = 4;
            this.lblKitapSayı.Text = "00";
            // 
            // lblRoman
            // 
            this.lblRoman.AutoSize = true;
            this.lblRoman.Location = new System.Drawing.Point(166, 158);
            this.lblRoman.Name = "lblRoman";
            this.lblRoman.Size = new System.Drawing.Size(24, 17);
            this.lblRoman.TabIndex = 5;
            this.lblRoman.Text = "00";
            // 
            // lblHikaye
            // 
            this.lblHikaye.AutoSize = true;
            this.lblHikaye.Location = new System.Drawing.Point(166, 222);
            this.lblHikaye.Name = "lblHikaye";
            this.lblHikaye.Size = new System.Drawing.Size(24, 17);
            this.lblHikaye.TabIndex = 6;
            this.lblHikaye.Text = "00";
            // 
            // lblAnsiklopedi
            // 
            this.lblAnsiklopedi.AutoSize = true;
            this.lblAnsiklopedi.Location = new System.Drawing.Point(166, 281);
            this.lblAnsiklopedi.Name = "lblAnsiklopedi";
            this.lblAnsiklopedi.Size = new System.Drawing.Size(24, 17);
            this.lblAnsiklopedi.TabIndex = 7;
            this.lblAnsiklopedi.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "İstatistikler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane.Properties.Resources.pie_chart;
            this.pictureBox1.Location = new System.Drawing.Point(246, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAnsiklopedi);
            this.Controls.Add(this.lblHikaye);
            this.Controls.Add(this.lblRoman);
            this.Controls.Add(this.lblKitapSayı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIstatistik";
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKitapSayı;
        private System.Windows.Forms.Label lblRoman;
        private System.Windows.Forms.Label lblHikaye;
        private System.Windows.Forms.Label lblAnsiklopedi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}