using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region GİTHUB
//alierguc https://github.com/alierguc
#endregion

namespace EkranCozunurluk
{
    public partial class Anaform : Form
    {
        // İstediğimiz çözünürlük değerleri
        int SimdikiWidth = 1280;
        int SimdikiHeight = 800;

        public Anaform()
        {
            InitializeComponent();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            #region Ekran Çözünürlüğü
            // Formun anasayfasını belirttiğimiz değere göre biçimlendiren kodlardır.
            this.Location = new Point(0, 0); // (0,0) noktasında yeni bir nokta oluşturuldu.
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Boyutu belirlenen alana göre ayarlandı.
            Rectangle ClienCozunurluk = new Rectangle(); // Dikdörtgen biçiminde ClienCozunurluk adında Dikdörtgen Alanı belirlendi.
            ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth); // Oranlar (Büyüklük ve Küçüklük karşılaştırılıp OranWidth değişkenine atıldı.)
            float OranHeight = ((float)ClienCozunurluk.Height / (float)SimdikiHeight); // Oranlar (Büyüklük ve Küçüklük karşılaştırılıp OranHeight değişkenine atıldı.)
            this.Scale(new SizeF(OranWidth, OranHeight));
            #endregion
        }
    }
}
