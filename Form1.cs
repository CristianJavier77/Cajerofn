using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajerofn
{
    public partial class Cajerobi : Form
    {
        public Cajerobi()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            try
            {
                int b1, b2, b3, b4, pesos;
                int monto, cien, docientos, quiniento, mil;
                pesos = int.Parse(txtCantidad.Text);
                b1 = pesos / 1000;
                pesos = pesos % 1000;
                b2 = pesos / 500;
                pesos = pesos % 500;
                b3 = pesos / 200;
                pesos = pesos % 200;
                b4 = pesos / 100;
                pesos = pesos % 100;

                txtmil.Text = "  " + b1 + "  ";
                txtquiniento.Text = "  " + b2 + "  ";
                txtdociento.Text = "  " + b3 + "  ";
                txtcien.Text = "  " + b4 + "  ";

                if (pesos % 100 == 0)
                {
                    b1 = pesos / 1000;
                    pesos = pesos % 1000;
                    b2 = pesos / 500;
                    pesos = pesos % 500;
                    b3 = pesos / 200;
                    pesos = pesos % 200;
                    b4 = pesos / 100;
                    pesos = pesos % 100;
                    


                }
                else
                {

                    Console.Write("!!! Monto no valido!!! ");
                }

            }
            catch (Exception ex)
            {

                
               Console.Write ( 100 == 0);
                MessageBox.Show(ex.Message);
                Console.Write("!!! Monto no valido!!! ");

            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtcien.Clear();
            txtquiniento.Clear();
            txtdociento.Clear();
            txtmil.Clear();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
