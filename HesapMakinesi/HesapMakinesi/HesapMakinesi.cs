using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

		bool optDurum = false;

		double sonuc = 0;
		string opt = "";


		// Rakamlar için
		private void RakamOlay(object sender, System.EventArgs e)
		{
			if (txtSonuc.Text == "0" || optDurum)  // Baştaki textboxtaki 0 değeri ve opertörler için
				txtSonuc.Clear();

			optDurum = false;
			Button btn = (Button)sender;
			txtSonuc.Text += btn.Text;
		}

		private void OptHesap(object sender, System.EventArgs e)
		{
			optDurum = true;
			Button btn = (Button)sender;  // hangi butona bastıysak
			string yeniOpt = btn.Text;

			lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
			switch (opt) // eski operator bilgisiyle işlem yapılacak
			{
				case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
				case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
				case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
				case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
			}

			sonuc = double.Parse(txtSonuc.Text);
			txtSonuc.Text = sonuc.ToString();
			opt = yeniOpt;
		}

		// CE / textBoxtaki bütün değeri temizlicek
		private void button5_Click(object sender, System.EventArgs e)
		{
			txtSonuc.Text = "0";
		}

		// C / tüm bilgileri temizlicek
		private void button12_Click(object sender, EventArgs e)
		{
			txtSonuc.Text = "0";
			lbSonuc.Text = "";
			opt = ""; // hafızadaki operatör bilgisini de sıfırlar
			sonuc = 0;
			optDurum = false;
		}


		// nokta için
		private void button16_Click(object sender, EventArgs e)
		{
			if (txtSonuc.Text == "0")
			{
				txtSonuc.Text = "0";
			}
			else if (optDurum)
			{
				txtSonuc.Text = "0";
			}

			if (!txtSonuc.Text.Contains("."))  // nokta içermiyorsa
			{
				txtSonuc.Text += ",";
			}

			optDurum = false;
		}


		// Eşittir işareti için
		private void button17_Click(object sender, EventArgs e)
        {
			lbSonuc.Text = "";
			optDurum = true;

			switch (opt) // eski operator bilgisiyle işlem yapılacak
			{
				case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
				case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
				case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
				case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
			}

			sonuc = double.Parse(txtSonuc.Text);
			txtSonuc.Text = sonuc.ToString();
			opt = "";
		}
    }
}
