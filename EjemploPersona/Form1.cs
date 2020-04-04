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
    public partial class FPrincipal : Form
    {
        Persona jose = new Persona();
        Persona javier = new Persona(2.0, 95.0);
        Persona luis = new Persona(1.5, 57.0);

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Limpiamos el errorProvider
            errorProvider.Clear();

            // Miramos a ver qué persona está seleccionada en el ComboBox
            switch (cbPersona.SelectedIndex)
            {
                case 0 :
                    Procesar(javier);
                    break;

                case 1:
                    Procesar(jose);
                    break;

                case 2 : 
                    Procesar(luis);
                    break;
            }
        }

        private void Procesar(Persona persona)
        {
            // De entrada no hay error.
            bool error = false;

            // Si la altura no es correcta.
            if (!persona.setAltura(txtAltura.Text))
            {
                // Asignamos errorPovider al TextBox altura, le damos el foco al TextBox altura
                // e indicamos que hay un error.
                errorProvider.SetError(txtAltura, "La altura es incorrecta.");
                txtAltura.Focus();
                error = true;
            }

            try
            {
                persona.setPeso(txtPeso.Text);
            }
            catch (Exception ex)
            {
                // Si se produce una excepción, asignamos errorPovider al TextBox peso, 
                // le damos el foco, si previamente no se lo hemos dado a la altura, e
                // indicamos que hay un error.
                errorProvider.SetError(txtPeso, ex.Message);

                if (!error)
                {
                    txtPeso.Focus();
                    error = true;
                }
            }

            // En principio asumimos que todo es correcto.
            String msg = "¡Todo correcto!";

            // Si se produjo un error, cambiamos el mensaje.
            if (error)
                msg = "Revise los errores.";

            // Mostramos el mensaje.
            MessageBox.Show(msg);
        }


        private void FPrincipal_Load(object sender, EventArgs e)
        {
            cbPersona.SelectedIndex = 0;

            txtAltura.Focus();
        }
    }

    public class Persona
    {
        private double altura = 0.0;
        private double peso = 0.0;

        public Persona(double altura, double peso)
        {
            setAltura(altura);
            setPeso(peso);
        }

        public Persona()
        {
            altura = 1.75;
            peso = 70.0;
        }

        private bool AlturaCta(double altura)
        {
            if (altura > 0.1)
                return true;

            return false;
        }

        public double getAltura()
        {
            return altura;
        }

        public bool setAltura(double altura)
        {
            if (!AlturaCta(altura))
                return false;

            this.altura = altura;

            return true;
        }
        public bool setAltura(String altura)
        {
            double al = 0.0;

            if (altura == "")
                return false;

            try
            {
                al = Convert.ToDouble(altura);
            }
            catch (Exception)
            {
                return false;
            }

            return setAltura(al);
        }

        public double getPeso()
        {
            return peso;
        }

        public void setPeso(double peso)
        {
            if (peso < 0.1)
                throw new Exception("Peso incorrecto. No puede ser menor de 100 gr.");

            this.peso = peso;
        }

        public void setPeso(String peso)
        {
            double ps = 0.0;

            if (peso == "")
                throw new Exception("Peso incorrecto. No puede estar vacío.");

            try
            {
                ps = Convert.ToDouble(peso);
            }
            catch (Exception)
            {
                throw new Exception("Peso incorrecto. No es un valor numérico.");
            }

            setPeso(ps);
        }
    }
}