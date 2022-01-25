
namespace DiceGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Oyuncu1 = new System.Windows.Forms.Button();
            this.button_oyuncu2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_oyuncu1 = new System.Windows.Forms.Label();
            this.label_oyuncu2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Tekrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Kaç Puanda Bitsin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 32);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(295, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button_Oyuncu1
            // 
            this.button_Oyuncu1.Location = new System.Drawing.Point(34, 297);
            this.button_Oyuncu1.Name = "button_Oyuncu1";
            this.button_Oyuncu1.Size = new System.Drawing.Size(175, 40);
            this.button_Oyuncu1.TabIndex = 4;
            this.button_Oyuncu1.Text = "Oyuncu 1";
            this.button_Oyuncu1.UseVisualStyleBackColor = true;
            this.button_Oyuncu1.Click += new System.EventHandler(this.button_Oyuncu1_Click);
            // 
            // button_oyuncu2
            // 
            this.button_oyuncu2.Location = new System.Drawing.Point(295, 297);
            this.button_oyuncu2.Name = "button_oyuncu2";
            this.button_oyuncu2.Size = new System.Drawing.Size(180, 40);
            this.button_oyuncu2.TabIndex = 5;
            this.button_oyuncu2.Text = "Oyuncu 2";
            this.button_oyuncu2.UseVisualStyleBackColor = true;
            this.button_oyuncu2.Click += new System.EventHandler(this.button_oyuncu2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oyuncu 1:";
            // 
            // label_oyuncu1
            // 
            this.label_oyuncu1.AutoSize = true;
            this.label_oyuncu1.Location = new System.Drawing.Point(193, 255);
            this.label_oyuncu1.Name = "label_oyuncu1";
            this.label_oyuncu1.Size = new System.Drawing.Size(20, 24);
            this.label_oyuncu1.TabIndex = 7;
            this.label_oyuncu1.Text = "0";
            // 
            // label_oyuncu2
            // 
            this.label_oyuncu2.AutoSize = true;
            this.label_oyuncu2.Location = new System.Drawing.Point(455, 255);
            this.label_oyuncu2.Name = "label_oyuncu2";
            this.label_oyuncu2.Size = new System.Drawing.Size(20, 24);
            this.label_oyuncu2.TabIndex = 9;
            this.label_oyuncu2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oyuncu 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = ".";
            // 
            // button_Tekrar
            // 
            this.button_Tekrar.Location = new System.Drawing.Point(140, 432);
            this.button_Tekrar.Name = "button_Tekrar";
            this.button_Tekrar.Size = new System.Drawing.Size(209, 40);
            this.button_Tekrar.TabIndex = 11;
            this.button_Tekrar.Text = "Oyuna Tekrar Başla";
            this.button_Tekrar.UseVisualStyleBackColor = true;
            this.button_Tekrar.Click += new System.EventHandler(this.button_Tekrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 533);
            this.Controls.Add(this.button_Tekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_oyuncu2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_oyuncu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_oyuncu2);
            this.Controls.Add(this.button_Oyuncu1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Oyuncu1;
        private System.Windows.Forms.Button button_oyuncu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_oyuncu1;
        private System.Windows.Forms.Label label_oyuncu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Tekrar;
    }
}

