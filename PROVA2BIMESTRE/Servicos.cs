using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA2BIMESTRE
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string computador = this.textBox1.Text;
            string cliente = this.textBox2.Text;
            double opção1 = Convert.ToDouble(this.comboBox1.Text);
            double opção2 = Convert.ToDouble(this.comboBox2.Text);*/

            double formatacao = 100.00;
            double limpeza = 50.00;
            double trocaPeca = 200.00;

            
            double formDinheiro1 = (formatacao * 20) / 100;
            double formPix1 = (formatacao * 10) / 100;
            double formCartao1 = (formatacao * 0) / 100;

            double formDinheiro2 = (limpeza * 20) / 100;
            double formPix2 = (limpeza * 10) / 100;
            double formCartao2 = (limpeza * 0) / 100;

            double formDinheiro3 = (trocaPeca * 20) / 100;
            double formPix3 = (trocaPeca * 10) / 100;
            double formCartao3 = (trocaPeca * 0) / 100;

            label5.Text = formDinheiro1.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
