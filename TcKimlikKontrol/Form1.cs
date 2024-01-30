using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tcno.KPSPublicSoapClient t = new tcno.KPSPublicSoapClient();
           bool answer = t.TCKimlikNoDogrula(Convert.ToInt64(txt_tckimlik.Text), txt_isim.Text.ToUpper(), txt_soyisim.Text.ToUpper(), Convert.ToInt32(txt_dogum_tarihi.Text));

            if (answer)
            {
                MessageBox.Show("BİLGİLER DOĞRU");
            }
            else
            {
                MessageBox.Show("İsim, Soyisim, Doğumyılı ve Tc Kimlik alanlarını tekrar kontrol ediniz...");
            }
        }
    }
}
