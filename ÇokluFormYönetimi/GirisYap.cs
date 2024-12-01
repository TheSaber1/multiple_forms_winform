using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇokluFormYönetimi
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void kayitolmasayfasibutton_Click(object sender, EventArgs e)
        {
            KayitOl KayitOl = new KayitOl();
            KayitOl.Show();
            this.Hide();
        }

        private void girisyapbutton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = usernametextbox.Text;
            string sifre = passwordtextbox.Text;

            Kayitlar form4 = new Kayitlar();

            if (form4.KullaniciVarMi(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

