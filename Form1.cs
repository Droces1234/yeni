using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subor, kolbor, pogacasimit, kurtbor, cikolatali, tllikurun, toplam;
            subor = Convert.ToInt32(textBox1.Text);
            kolbor = Convert.ToInt32(textBox2.Text);
            pogacasimit= Convert.ToInt32(textBox3.Text);
            kurtbor= Convert.ToInt32(textBox4.Text);
            cikolatali= Convert.ToInt32(textBox5.Text);
            tllikurun = Convert.ToInt16(textBox6.Text);
            toplam = subor*10 + kolbor*10+pogacasimit*1.5+kurtbor*8+cikolatali*2.5+tllikurun*1;
            label4.Text = toplam.ToString();
        }

    }
}
