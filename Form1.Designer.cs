namespace goruntuisleme
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resimSec = new System.Windows.Forms.Button();
            this.gri = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.parlaklik = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.ilkhali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(99, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // resimSec
            // 
            this.resimSec.Location = new System.Drawing.Point(99, 284);
            this.resimSec.Name = "resimSec";
            this.resimSec.Size = new System.Drawing.Size(119, 32);
            this.resimSec.TabIndex = 2;
            this.resimSec.Text = "Resim Seç";
            this.resimSec.UseVisualStyleBackColor = true;
            this.resimSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // gri
            // 
            this.gri.Location = new System.Drawing.Point(397, 108);
            this.gri.Name = "gri";
            this.gri.Size = new System.Drawing.Size(119, 32);
            this.gri.TabIndex = 3;
            this.gri.Text = "Gri Yap";
            this.gri.UseVisualStyleBackColor = true;
            this.gri.Click += new System.EventHandler(this.gri_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 4;
            // 
            // parlaklik
            // 
            this.parlaklik.Location = new System.Drawing.Point(397, 251);
            this.parlaklik.Name = "parlaklik";
            this.parlaklik.Size = new System.Drawing.Size(119, 41);
            this.parlaklik.TabIndex = 5;
            this.parlaklik.Text = "Parlaklığı Ayarla";
            this.parlaklik.UseVisualStyleBackColor = true;
            this.parlaklik.Click += new System.EventHandler(this.parlaklik_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(397, 156);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(119, 32);
            this.histogram.TabIndex = 6;
            this.histogram.Text = "Histogram Eşitle";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // ilkhali
            // 
            this.ilkhali.Location = new System.Drawing.Point(224, 284);
            this.ilkhali.Name = "ilkhali";
            this.ilkhali.Size = new System.Drawing.Size(119, 32);
            this.ilkhali.TabIndex = 7;
            this.ilkhali.Text = "İlk Hali";
            this.ilkhali.UseVisualStyleBackColor = true;
            this.ilkhali.Click += new System.EventHandler(this.ilkhali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 676);
            this.Controls.Add(this.ilkhali);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.parlaklik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gri);
            this.Controls.Add(this.resimSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resimSec;
        private System.Windows.Forms.Button gri;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button parlaklik;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button ilkhali;
    }
}

