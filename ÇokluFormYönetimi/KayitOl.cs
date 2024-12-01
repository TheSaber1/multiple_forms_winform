namespace ÇokluFormYönetimi
{
    public partial class KayitOl : Form
    {

        public KayitOl()
        {
            InitializeComponent();
        }

        private void girisformadonmebutton_Click(object sender, EventArgs e)
        {
            GirisYap GirisYap = new GirisYap();
            GirisYap.Show();
            this.Hide();

        }

        public void kayitbutton_Click(object sender, EventArgs e)
        {

            string kullaniciadi = kullaniciaditextbox.Text;
            string sifre = sifretextbox.Text;
            string sifretekrar = sifretekrartextbox.Text;


            bool mevcutmu = false;

            for (int i = 0; i < Kayitlar.userIndex; i++)
            {
                if (Kayitlar.username[i] == kullaniciadi)
                {
                    mevcutmu = true;
                    break;
                }
            }


            if (mevcutmu)
            {
                errorProvider1.SetError(kullaniciaditextbox, "Bu Kullanıcı Adı Zaten Mevcut!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrWhiteSpace(kullaniciaditextbox.Text) ||
               string.IsNullOrWhiteSpace(sifretextbox.Text) ||
               string.IsNullOrWhiteSpace(sifretekrartextbox.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
            else
            {


                if (sifretekrar != sifre)
                {
                    errorProvider1.SetError(sifretekrartextbox, "Şifreniz İle Doğrulamanız Aynı Olmalı!");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }

                Kayitlar Kayitlar = new Kayitlar();

                Kayitlar.username[Kayitlar.userIndex] = kullaniciadi;
                Kayitlar.password[Kayitlar.userIndex] = sifre;
                Kayitlar.userIndex++;


                
                Kayitlar.hesabiekle();
                MessageBox.Show("Başarıyla Kayıt Oldunuz, Giriş Sayfasına Yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisYap GirisYap = new GirisYap();
                GirisYap.Show();
                this.Hide();
            }
        }
    }
}




