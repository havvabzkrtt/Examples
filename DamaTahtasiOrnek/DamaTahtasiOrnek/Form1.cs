using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 8'E 8'LİK BİR DAMA TAHTASI
namespace DamaTahtasiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// buton oluşturduk
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //this.Controls.Add(button);  // Butonu ekrana ekledik

            // 8 e 8 lik bir array oluşturduk 

            Button[,] buttons = new Button[8, 8];

            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // butonun konumunun sol taraftan uzaklığı
                    buttons[i, j].Top = top;  // butonun konumunun yukarıdan uzaklığı
                    left += 50;

                    if ((i+j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 50;
            }
      }
    }
}
