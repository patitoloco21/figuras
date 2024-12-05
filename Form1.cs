using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figuras2funcionando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2) // Pestaña "Cilindro"
            {
                CalcularCilindro();
            }
            else if (tabControl1.SelectedIndex == 1) // Pestaña "Pirámide"
            {
                CalcularPiramide();
            }
            else if (tabControl1.SelectedIndex == 0) // Pestaña "Cubo"
            {
                CalcularCubo();
            }
            else
            {
                MessageBox.Show("Selecciona una pestaña válida para realizar el cálculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularCilindro()
        {
            try
            {
                double radio = Convert.ToDouble(RadioC.Text);
                double altura = Convert.ToDouble(AlturaC.Text);

                if (radio <= 0 || altura <= 0)
                {
                    MessageBox.Show("Ingresa valores positivos para el cilindro.");
                    return;
                }

                double volumen = Math.PI * Math.Pow(radio, 2) * altura;
                MessageBox.Show($"El volumen del cilindro es {volumen:F2} unidades cúbicas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa números válidos en los campos de radio y altura del cilindro.");
            }
        }

        private void CalcularPiramide()
        {
            try
            {
                double lado = Convert.ToDouble(LadoP.Text);
                double altura = Convert.ToDouble(AlturaP.Text);

                if (lado <= 0 || altura <= 0)
                {
                    MessageBox.Show("Ingresa valores positivos para la pirámide.");
                    return;
                }

                double volumen = (1.0 / 3.0) * Math.Pow(lado, 2) * altura;
                MessageBox.Show($"El volumen de la pirámide es {volumen:F2} unidades cúbicas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa números válidos en los campos de lado y altura de la pirámide.");
            }
        }

        private void CalcularCubo()
        {
            try
            {
                double lado = Convert.ToDouble(LadoCubo.Text);

                if (lado <= 0)
                {
                    MessageBox.Show("Ingresa valores positivos para el cubo.");
                    return;
                }

                double volumen = Math.Pow(lado, 3);
                MessageBox.Show($"El volumen del cubo es {volumen:F2} unidades cúbicas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número válido en el campo de lado del cubo.");
            }
        }

    }
}
