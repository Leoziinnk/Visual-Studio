using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        bool cor = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            float v1, v2, res;
            try
            {
                v1 = Convert.ToSingle(ValorA.Text);
                v2 = Convert.ToSingle(ValorB.Text);
                if (v1 < 0 && v2 < 0)
                {
                    MessageBox.Show("digite valores acima de 0", "Valor inválido");
                    if (v1 < 0)
                        ValorA.Focus();
                    else
                        ValorB.Focus();
                }

                if (rbArea.Checked)
                {
                    res = v1 * v2;
                    if (res >= 500)
                    {
                        lbTamcor.ForeColor = Color.Red;
                        lbTamcor.Text = "Alta";
                    }
                    else if (res > 100 && res < 500)
                    {
                        lbTamcor.ForeColor = Color.Blue;
                        lbTamcor.Text = "Media";
                    }
                    else if (res <= 100)
                    {
                        lbTamcor.ForeColor = Color.Green;
                        lbTamcor.Text = "Baixa";
                    }
                    lbArea.Text = "Área: " + Convert.ToString(res) + "m²";

                }
                else if (rbPerímetro.Checked)
                {

                    res = 2 * (v1 + v2);
                    lbArea.Text = "Perímetro: " + Convert.ToString(res) + "m";
                }

            }
            catch
            {
                MessageBox.Show("Insira um número valido nas caixas de texto", "ERRO");
                ValorA.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbArea.Text = "";
            lbTamcor.Text = "";
            ValorA.Clear();
            ValorB.Clear();
            ValorA.Focus();
        }

        private void rbPerímetro_CheckedChanged(object sender, EventArgs e)
        {
            lbTamcor.Text = "";
        }

        private void rbArea_CheckedChanged(object sender, EventArgs e)
        {
            lbTamcor.Text = "???";
        }

        private void btCor_Click(object sender, EventArgs e)
        {
            
            cor = !cor;
            if(cor == true)
            {
                lbArea.ForeColor = Color.Blue;
                lbCALCULADORA.ForeColor = Color.Blue;
                lbLadoA.ForeColor = Color.Blue;
                lbLadoB.ForeColor = Color.Blue;
                lbM.ForeColor = Color.Blue;
                lbM2.ForeColor = Color.Blue;
                lbRetangulo.ForeColor = Color.Blue;
            }
            else if (cor == false) 
            {
                lbArea.ForeColor = Color.Black;
                lbCALCULADORA.ForeColor = Color.Black;
                lbLadoA.ForeColor = Color.Black;
                lbLadoB.ForeColor = Color.Black;
                lbM.ForeColor = Color.Black;
                lbM2.ForeColor = Color.Black;
                lbRetangulo.ForeColor = Color.Black;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
