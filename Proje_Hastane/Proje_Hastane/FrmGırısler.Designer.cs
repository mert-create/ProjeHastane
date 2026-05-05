namespace Proje_Hastane
{
    partial class FrmGırısler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGırısler));
            this.BtnHastaGırısı = new System.Windows.Forms.Button();
            this.BtnDoktorGırısı = new System.Windows.Forms.Button();
            this.BtnSekreterGırısı = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHastaGırısı
            // 
            this.BtnHastaGırısı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnHastaGırısı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGırısı.BackgroundImage")));
            this.BtnHastaGırısı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGırısı.Location = new System.Drawing.Point(45, 186);
            this.BtnHastaGırısı.Name = "BtnHastaGırısı";
            this.BtnHastaGırısı.Size = new System.Drawing.Size(209, 158);
            this.BtnHastaGırısı.TabIndex = 0;
            this.BtnHastaGırısı.Text = "ㅤㅤㅤ";
            this.BtnHastaGırısı.UseVisualStyleBackColor = false;
            this.BtnHastaGırısı.Click += new System.EventHandler(this.BtnHastaGırısı_Click);
            // 
            // BtnDoktorGırısı
            // 
            this.BtnDoktorGırısı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnDoktorGırısı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGırısı.BackgroundImage")));
            this.BtnDoktorGırısı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGırısı.Location = new System.Drawing.Point(310, 186);
            this.BtnDoktorGırısı.Name = "BtnDoktorGırısı";
            this.BtnDoktorGırısı.Size = new System.Drawing.Size(209, 158);
            this.BtnDoktorGırısı.TabIndex = 1;
            this.BtnDoktorGırısı.Text = "ㅤㅤㅤ";
            this.BtnDoktorGırısı.UseVisualStyleBackColor = false;
            this.BtnDoktorGırısı.Click += new System.EventHandler(this.BtnDoktorGırısı_Click);
            // 
            // BtnSekreterGırısı
            // 
            this.BtnSekreterGırısı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSekreterGırısı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGırısı.BackgroundImage")));
            this.BtnSekreterGırısı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGırısı.Location = new System.Drawing.Point(575, 186);
            this.BtnSekreterGırısı.Name = "BtnSekreterGırısı";
            this.BtnSekreterGırısı.Size = new System.Drawing.Size(209, 158);
            this.BtnSekreterGırısı.TabIndex = 2;
            this.BtnSekreterGırısı.Text = "ㅤㅤㅤ";
            this.BtnSekreterGırısı.UseVisualStyleBackColor = false;
            this.BtnSekreterGırısı.Click += new System.EventHandler(this.BtnSekreterGırısı_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 141);
            this.label4.TabIndex = 6;
            this.label4.Text = "My Hospital";
            // 
            // FrmGırısler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(832, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGırısı);
            this.Controls.Add(this.BtnDoktorGırısı);
            this.Controls.Add(this.BtnHastaGırısı);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGırısler";
            this.Text = "BlueHospıtalgırıs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGırısı;
        private System.Windows.Forms.Button BtnDoktorGırısı;
        private System.Windows.Forms.Button BtnSekreterGırısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

