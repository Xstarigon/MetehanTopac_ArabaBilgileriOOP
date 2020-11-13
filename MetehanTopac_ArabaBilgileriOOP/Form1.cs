using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetehanTopac_ArabaBilgileriOOP.Classes;

namespace MetehanTopac_ArabaBilgileriOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Araba araba = new Araba();

        private void button1_Click(object sender, EventArgs e)
        {
            araba.ID = Convert.ToInt32(textBox1.Text);
            araba.Marka = textBox2.Text;
            araba.Model = textBox3.Text;
            araba.KapiSayisi = comboBox1.Text;
            araba.BeygirGucu = (int)numericUpDown1.Value;
            araba.ArabaTuru = comboBox2.Text;
            araba.MaksimumHiz = (int)numericUpDown2.Value;
            araba.Cekis = comboBox3.Text;
            araba.SifirYüzHizlanma = (double)numericUpDown3.Value;
            araba.Agirlik = (double)numericUpDown4.Value;
            araba.MotorHacmi = (int)numericUpDown5.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2 Kapılı");
            comboBox1.Items.Add("4 Kapılı");
            comboBox1.Items.Add("5 Kapılı");

            comboBox2.Items.Add("Binek");
            comboBox2.Items.Add("Ticari");

            comboBox3.Items.Add("Önden Çekişli");
            comboBox3.Items.Add("Arkadan İtişli");
            comboBox3.Items.Add("Dört Çeker");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID: " + araba.ID);
            listBox1.Items.Add("Marka: " + araba.Marka);
            listBox1.Items.Add("Model: " + araba.Model);
            listBox1.Items.Add("Kapı Sayısı: " + araba.KapiSayisi);
            listBox1.Items.Add("Beygir Gücü: " + araba.BeygirGucu);
            listBox1.Items.Add("Araba Türü: " + araba.ArabaTuru);
            listBox1.Items.Add("Maksimum Hız: " + araba.MaksimumHiz);
            listBox1.Items.Add("Çekiş: " + araba.Cekis);
            listBox1.Items.Add("0-100 Hızlanma: " + araba.SifirYüzHizlanma);
            listBox1.Items.Add("Ağırlık: " + araba.Agirlik);
            listBox1.Items.Add("Motor Hacmi: " + araba.MotorHacmi);
        }
    }
}
