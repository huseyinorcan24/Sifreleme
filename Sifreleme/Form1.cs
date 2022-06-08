using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifre_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpg|EXE Files (*.exe)|*.exe|GIF Files (*.gif)|*.gif";
            dialog.Title = "Lütfen şifrelemek için bir resim dosyası seçin.";
            byte[] ImageBytes;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageBytes = File.ReadAllBytes(dialog.FileName);

                for (int i = 0; i < ImageBytes.Length; i++)
                {
                    ImageBytes[i] = (byte)(ImageBytes[i] + 5);
                }

                File.WriteAllBytes(dialog.FileName, ImageBytes);
            }

                      //Resim Bulunduğu Yere Şifreleniyor...
        }

        private void btn_coz_Click(object sender, EventArgs e)
        {
         OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpg|EXE Files (*.exe)|*.exe|GIF Files (*.gif)|*.gif";
            dialog.Title = "Lütfen şifresi çözülecek bir resim dosyası seçin.";
            byte[] ImageBytes;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageBytes = File.ReadAllBytes(dialog.FileName);

                for (int i = 0; i < ImageBytes.Length; i++)
                {
                    ImageBytes[i] = (byte)(ImageBytes[i] - 5);
                }

                File.WriteAllBytes(dialog.FileName, ImageBytes);
            }
                         //Resim Bulunduğu Yerden Şifresi Çözülüyor...
        }
    }
}
