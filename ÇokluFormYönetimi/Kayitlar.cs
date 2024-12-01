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
    public partial class Kayitlar : Form
    {
        public static string[] username = new string[128];
        public static string[] password = new string[128];
        public static int userIndex = 0;
        public Kayitlar()
        {
            InitializeComponent();
        }

       public void hesabiekle()
        {
            for (int i = 0; i < userIndex; i++)
            {
                dataGridView1.Rows.Add(username[i], password[i]);
            }
        }
        public bool KullaniciVarMi(string GirilenKullaniciAdi, string GirilenSifre)
        {
            for (int i = 0; i < userIndex; i++)
            {
                if (username[i] == GirilenKullaniciAdi && password[i] == GirilenSifre)
                {
                    return true; 
                }
            }
            return false; 
        }


    }

}
