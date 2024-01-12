using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesap_Makinesi
{
    public partial class FrmHesapMakinesi : Form
    {
               
        String opertr;
        float sayı1;
        float sonuc;
        public FrmHesapMakinesi()
        {
            InitializeComponent();
          
        }
        private void FrmHesapMakinesi_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Font = new Font("Oswald", 11f, FontStyle.Bold);
            label1.Text = "";
        }
        
        //Yüzde (%) butonu
        #region
        private void btnyüzde_Click(object sender, EventArgs e)
        {
            sayı1=float.Parse(textBox1.Text);
            opertr = "%";
            textBox1.Text = null;
        }
        #endregion
        //Karekök butonu
        #region
        private void btnkarekök_Click(object sender, EventArgs e)
        {
            sayı1=float.Parse(textBox1.Text);
            float sonuc = (float)Math.Sqrt(sayı1);
            textBox1.Text=sonuc.ToString();
            label1.Text = ("√" + sayı1 + " = " + sonuc.ToString());
            

        }
        #endregion
        //Clean (C) butonu
        #region
        private void btnclean_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text=null;
                       
        }
        #endregion
        //Delete butonu 
        #region
        private void btndelete_Click(object sender, EventArgs e)
        {
            string veri = "";
            int a = textBox1.Text.Length;
            for (int i = 0; i < a-1; i++)
            {
                veri += textBox1.Text[i];
            }
            textBox1.Text=veri;
            
        }
        #endregion
        //Üs kare (x^2) butonu
        #region
        private void btnsqrt_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            float sonuc =(((float)Math.Pow(sayı1,2)));
            textBox1.Text=sonuc.ToString();
            label1.Text=(sayı1+ "² = "+sonuc.ToString());
            
        }
        #endregion
        //Virgül (,) butonu
        #region
        private void btnvirgül_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
        #endregion
        //Çarpma (*) butonu
        #region
        private void btncarpi_Click(object sender, EventArgs e)
        {
          sayı1=float.Parse( textBox1.Text);
            textBox1.Text = null;
            opertr = "*";
        }
        #endregion
        //Çıkarma (-) butonu
        #region
        private void btneksi_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            textBox1.Text = null;
            opertr = "-";
        }
        #endregion
        //Toplama (+) butonu
        #region
        private void btnartı_Click(object sender, EventArgs e)
        {
            
                sayı1 = float.Parse(textBox1.Text);
                textBox1.Text = null;
                opertr = "+";
            
            
        }
        #endregion
        //Bölme (/) butonu
        #region
        private void btndivision_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            textBox1.Text = null;
            opertr = "/";
        }
        #endregion
        //Eşittir (=) butonu
        #region
        private void btnequals_Click(object sender, EventArgs e)
        {
            String op = opertr;
            float sayı2 = float.Parse(textBox1.Text);
            switch(op)
            {
                case "+":
                    sonuc = sayı1+sayı2;
                   
                    break;
                case "-":
                    sonuc = sayı1 - sayı2;
                    
                    break;
                case "*":
                    sonuc = sayı1 * sayı2;
                   
                    break;
                case "%":
                    sonuc = sayı1 * sayı2 / 100;
                    
                    break;

                case "/":
                    if (sayı2 == 0)
                    {
                        textBox1.Text= ("Tanımsız işlem yaptınız");
                    }
                    else 
                    {
                        sonuc = sayı1 / sayı2;
                    }
                    break;
                    

            }
             textBox1.Text = sonuc.ToString();
             label1.Text = (sayı1 + " " + op + " " + sayı2 + " = " + sonuc);
             

        }
        #endregion
        //Rakam (0,1,2,3,4,5,6,7,8,9) butonları
        #region
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }


        #endregion
     
    }
}
