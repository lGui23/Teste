using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(tb_Nota1.Text);
            double nota2 = Convert.ToDouble(tb_Nota2.Text);
            double nota3 = Convert.ToDouble(tb_Nota3.Text);
            double nota4 = Convert.ToDouble(tb_Nota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            lb_Resultado.Text = $"A média é de {media:N2}";
        }
    }
}
