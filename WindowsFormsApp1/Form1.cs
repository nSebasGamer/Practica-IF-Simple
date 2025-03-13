using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un Numero (Ya sea negativo o Positivo)"));

            if (input > 0)
            {
                MessageBox.Show("El numero es positivo");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un Numero (Ya sea negativo o Positivo)"));
            if (input < 0)
            {
                MessageBox.Show("El numero es negativo");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un Numero:"));
            if (input > 112)
            {
                MessageBox.Show("El numero es mayor que 112");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un Numero:"));
            if (input <= 25 && input >= 13)
            {
                MessageBox.Show("El numero esta en El Rango de 13-25");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un Numero:"));
            if (input < 11 | input > 17)
            {
                MessageBox.Show("El numero esta Fuera del Rango de 11-17");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe un El Costo del Primer Producto:"));
            double input2 = Convert.ToDouble(Interaction.InputBox("Escribe un El Costo del Segundo Producto:"));
            double input3 = Convert.ToDouble(Interaction.InputBox("Escribe un El Costo del Tercer Producto:"));
            double input4 = Convert.ToDouble(Interaction.InputBox("Escribe un El Costo del Cuarto Producto:"));
            double total = input + input2 + input3 + input4;
            if (total >= 500)
            {
                double descuento = total * 0.15;
                double costofinal = total - descuento;
                MessageBox.Show(" El Total es de:" + total.ToString("C") + "\n El Total Con Descuento Aplicado del 15% Es:" + costofinal.ToString("C"));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Interaction.InputBox("Escribe la Calificacion en el Primer Parcial de Programacion::"));
            double input2 = Convert.ToDouble(Interaction.InputBox("Escribe la Calificacion en el Segundo Parcial de Programacion:"));
            double input3 = Convert.ToDouble(Interaction.InputBox("Escribe la Calificacion en el Tercer Parcial de Programacion:"));
           
            double total = (input + input2 + input3) / 3;
            if (total >= 6)
            {

                MessageBox.Show("la Calificacion es Aprovatoria" +"\nCon Un Promedio de:"+ total.ToString("F2"));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(Interaction.InputBox("Escribe la Calificacion de Quimica en Numeros del 0-10 (Solo Enteros):"));

            if (input == 0)
            {

                MessageBox.Show("la Calificacion es CERO");
            }

            if (input == 1)
            {

                MessageBox.Show("la Calificacion es UNO");
            }

            if (input == 2)
            {

                MessageBox.Show("la Calificacion es DOS");
            }

            if (input == 3)
            {

                MessageBox.Show("la Calificacion es TRES");
            }

            if (input == 4)
            {

                MessageBox.Show("la Calificacion es CUATRO");
            }

            if (input == 5)
            {

                MessageBox.Show("la Calificacion es CINCO");
            }

            if (input == 6)
            {

                MessageBox.Show("la Calificacion es SEIS");
            }
            if (input == 7)
            {

                MessageBox.Show("la Calificacion es SIETE");
            }


            if (input == 8)
            {

                MessageBox.Show("la Calificacion es OCHO");
            }

            if (input == 9)
            {

                MessageBox.Show("la Calificacion es NUEVE");
            }

            if (input == 10)
            {

                MessageBox.Show("la Calificacion es DIEZ");
            }
            
            if (input >= 11 | input < 0)
            {

                MessageBox.Show("El Numero Ingresado esta Fuera de Rango");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(Interaction.InputBox("Escribe un Numero de Mes del 1-12 (Solo Enteros):"));



            if (input == 1)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Enero");
            }

            if (input == 2)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Febrero");
            }

            if (input == 3)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Marzo");
            }

            if (input == 4)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Abril");
            }

            if (input == 5)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Mayo");
            }

            if (input == 6)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Junio");
            }
            if (input == 7)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Julio");
            }


            if (input == 8)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Agosto");
            }

            if (input == 9)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Septiembre");
            }

            if (input == 10)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Octubre");
            }

            if (input == 11)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Noviembre");
            }
            if (input == 12)
            {

                MessageBox.Show("el Mes Numero " + input.ToString() + " Es Diciembre!!");
            }
            if (input > 13 | input <= 0)
            {

                MessageBox.Show("El Numero Ingresado Esta Fuera e Rango");
            }
        }
    }
    
    
    
 
}
