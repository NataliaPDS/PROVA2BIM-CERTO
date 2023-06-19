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
            string computador = this.textBox1.Text;
            string cliente = this.textBox2.Text;
            double opção1 = Convert.ToDouble(this.comboBox1.Text);
            double opção2 = Convert.ToDouble(this.comboBox2.Text);
          

           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double formatação = 100.00;
            double limpeza = 50.00;
            double trocaPeca = 200.00;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
