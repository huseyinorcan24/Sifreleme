
namespace Sifreleme
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
            this.btn_sifre = new System.Windows.Forms.Button();
            this.btn_coz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sifre
            // 
            this.btn_sifre.Location = new System.Drawing.Point(12, 45);
            this.btn_sifre.Name = "btn_sifre";
            this.btn_sifre.Size = new System.Drawing.Size(223, 46);
            this.btn_sifre.TabIndex = 8;
            this.btn_sifre.Text = "Şifrele";
            this.btn_sifre.UseVisualStyleBackColor = true;
            this.btn_sifre.Click += new System.EventHandler(this.btn_sifre_Click);
            // 
            // btn_coz
            // 
            this.btn_coz.Location = new System.Drawing.Point(321, 45);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(222, 46);
            this.btn_coz.TabIndex = 9;
            this.btn_coz.Text = "Şifre Çöz";
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 131);
            this.Controls.Add(this.btn_coz);
            this.Controls.Add(this.btn_sifre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sifre;
        private System.Windows.Forms.Button btn_coz;
    }
}

