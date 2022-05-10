using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeUygulama
{
    public partial class HareketEtme : Form
    {

        private Label lbl;
        private Random rnd = new Random();
        public HareketEtme()
        {
            InitializeComponent();
        }

        private void HareketEtme_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;  // bu true olmassa bazen klavye girişlerini algılayamayabilir.
            pictureBox1.Focus(); // odaklanma için lazım olabiliyor.

            lbl = new Label();
            lbl.Size = new Size(30, 30);
            lbl.Location = new Point(60, 60);
            lbl.BackColor = Color.Yellow;
            panel1.Controls.Add(lbl); // labeli panele eklemek için
                                      // this.Controls.Add(lbl); //labeli forma eklemek isteseydik


        }

        private void HareketEtme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' || e.KeyChar == 'S') // aşağı hareket.
                pictureBox1.Top += 30; // y ekseninde yeri değişecek.
            if (e.KeyChar == 'w' || e.KeyChar == 'W') // yukarı hareket.
                pictureBox1.Top -= 30;
            if (e.KeyChar == 'a' || e.KeyChar == 'A') // sola hareket.
                pictureBox1.Left -= 30; // x ekseninde yeri değişecek.
            if (e.KeyChar == 'd' || e.KeyChar == 'D') // sağa hareket.
                pictureBox1.Left += 30;

            HareketKontrol(); // herhangi bir tuşa bastığımız zamanlar hareket kontrol fonksiyonunu çağırdık.
            YerDegistir();
        }

        #region fonksiyonlar

        private bool YemYediMi()
        {
            if (pictureBox1.Location == lbl.Location)
                return true;
            return false;
        }

        public int RastgeleSayi()
        {
            return rnd.Next(0, 11) * 30; // 0 la 330 arası 30 un katları sayı
        }

        private void HareketKontrol()
        {
            if (YemYediMi())
                lbl.Location = new Point(RastgeleSayi(), RastgeleSayi());
        }

        private void YerDegistir()
        {
            if (pictureBox1.Left > panel1.Width - 30)
                pictureBox1.Left = 0;
            else if (pictureBox1.Left < 0)
                pictureBox1.Left = panel1.Width;
            else if (pictureBox1.Top > panel1.Height - 30)
                pictureBox1.Top = 0;
            else if (pictureBox1.Top < 0)
                pictureBox1.Top = panel1.Height;
        }

        #endregion
    }
}
