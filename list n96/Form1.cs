using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_n96
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("nurseeeeaaaaaaavim");
            kisiler.Add("ravza sancheeez");
            kisiler.Add("hilal de souzaaaaaaa");
            kisiler.Add("yezna");

            lbKisiler.DataSource = kisiler.ToList();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtAd.Text);

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtAd.Text);

            if (durum)
            {
                MessageBox.Show("Aradığınız kişi mevcut.");
            }
            else
            {
                MessageBox.Show("Benim telefon çalıyor bi dakika nirürürü (yoooookk)");
            }
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtAd.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtAd.Text + " " + sira + " sırasındadır.");
            }
            else
            {
                MessageBox.Show(txtAd.Text + "yooooooooooook");
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtAd.Text);
            if (sira > -1)
            {
                kisiler.RemoveAt(sira); //Remove --> belirtilen index sırasındaki kişiyi siler

                lbKisiler.DataSource = kisiler.ToList(); //Listboxu güncelle
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtAd.Text);

            if (durum)
            {
                kisiler.Remove(txtAd.Text); //kişi adı ile silme

            }
            lbKisiler.DataSource = kisiler.ToList(); //Listboxu güncelle
        }

        private void lbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAd.Text = lbKisiler.SelectedValue.ToString();
            indexSira = lbKisiler.SelectedIndex; // Listbox içerisideki sırayı verir.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(indexSira.ToString());
            kisiler[indexSira] = txtAd.Text;

            lbKisiler.DataSource = kisiler.ToList(); //Listboxu güncelle
        }

        private void btnArtan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            lbKisiler.DataSource = kisiler.ToList(); //Listboxu güncelle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();

            lbKisiler.DataSource = kisiler.ToList(); //Listboxu güncelle
        }

        private void btnBesHarf_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for(int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
            }

            MessageBox.Show("5 Karakterli " + sayac + "kişi mevcut");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i][0] == 'M')
                {
                    sayac++;
                }
            }

            MessageBox.Show("M Karakterli " + sayac + "kişi mevcut");
        }

        private void btnBosalt_Click(object sender, EventArgs e)
        {
            kisiler.Clear();

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                string kisi = kisiler[i];
                if (kisi[kisi.Length-1] == 'a')
                {
                    sayac++;
                }

                MessageBox.Show("Son harfi'a' ile biten " + sayac + "kişi mevcut");
            }
        }
    }
}

