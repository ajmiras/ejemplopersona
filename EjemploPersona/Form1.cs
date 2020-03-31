using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPersona
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Persona jose = new Persona();
            Persona javier = new Persona();

            jose.SetAltura(-1.75);

            javier.SetAltura(2.00);

            txtAltura.Text = Convert.ToString(jose.GetAltura());
            
            
        }

        private void txtAltura_MouseClick(object sender, MouseEventArgs e)
        {
            //
        }
    }


    public class Persona
    {
        private double altura = 0.1;

        private bool AlturaCta(double alt)
        {
            if (alt > 0.1)
                return true;

            return false;
        }

        public double GetAltura()
        {
            return altura;
        }

        public void SetAltura(double alt)
        {
            if (AlturaCta(alt))
                altura = alt;
        }


    }

}
