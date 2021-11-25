using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arb_Bal
{
    public partial class Form1 : Form
    {
        ArbolBalanceado Arbol;

        public Form1()
        {
            InitializeComponent();
            Arbol = new ArbolBalanceado(this);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Arbol.Insertar(Convert.ToInt32(textBoxNumero.Text), textBoxNombre.Text);

                textBoxNumero.Clear();
                textBoxNombre.Clear();
                textBoxNumero.Focus();

                dataGridView.Rows.Clear();
                Arbol.Preorden(Arbol.Raiz, dataGridView);

                labelAltura.Text = "Altura: " + Convert.ToString(Arbol.CalcularAltura(Arbol.Raiz));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try 
            { 
                Arbol.Eliminacion(ref Arbol.Raiz, Convert.ToInt32(textBoxEliminar.Text));

                dataGridView.Rows.Clear();
                Arbol.Preorden(Arbol.Raiz, dataGridView);

                labelAltura.Text = "Altura: " + Convert.ToString(Arbol.CalcularAltura(Arbol.Raiz));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void buttonPreorden_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Arbol.Preorden(Arbol.Raiz, dataGridView);
        }

        private void buttonInorden_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Arbol.Inorden(Arbol.Raiz, dataGridView);
        }

        private void buttonPosorden_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Arbol.Posorden(Arbol.Raiz, dataGridView);
        }
    }
}
