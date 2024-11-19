using System;
using System.Windows.Forms;

namespace Polinomios
{
    public partial class FrmPolinomios : Form
    {
        public FrmPolinomios()
        {
            InitializeComponent();
        }

        Polinomio p1 = new Polinomio();
        Polinomio p2 = new Polinomio();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double coef = double.Parse(txtCoeficiente.Text);
            int expo = int.Parse(txtExponente.Text);
            Monomio monomio = new Monomio(coef, expo);
            switch (cmbPolinomio.SelectedIndex)
            {
                case 0:
                    p1.Agregar(monomio);
                    p1.Mostrar(lblPolinomio1);
                    break;
                case 1:
                    p2.Agregar(monomio);
                    p2.Mostrar(lblPolinomio2);
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblPolinomioR.Text = "";
            lblPolinomioRR.Text = ""; // Limpiar resultados anteriores

            if (cmbOperacion.SelectedIndex >= 0)
            {
                Polinomio cociente, residuo;
                switch (cmbOperacion.SelectedIndex)
                {
                    case 0: // Suma
                        Polinomio.Sumar(p1, p2).Mostrar(lblPolinomioR);
                        break;
                    case 1: // Resta
                        Polinomio.Restar(p1, p2).Mostrar(lblPolinomioR);
                        break;
                    case 2: // Multiplicación
                        Polinomio.Multiplicar(p1, p2).Mostrar(lblPolinomioR);
                        break;
                    case 3: // División
                        p1.Dividir(p2, out cociente, out residuo);
                        cociente.Mostrar(lblPolinomioR);
                        residuo.Mostrar(lblPolinomioRR);
                        break;
                    case 4: // Derivada
                        p1.Derivar().Mostrar(lblPolinomioR);
                        break;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            switch (cmbPolinomio.SelectedIndex)
            {
                case 0:
                    p1 = new Polinomio();
                    lblPolinomio1.Text = "";
                    break;
                case 1:
                    p2 = new Polinomio();
                    lblPolinomio2.Text = "";
                    break;
            }
            lblPolinomioR.Text = "";
            lblPolinomioRR.Text = "";
        }
    }
}