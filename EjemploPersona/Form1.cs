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
            bool error = false;

            // Limpiamos el errorProvider
            errorProvider.Clear();

            // Miramos a ver qué persona está seleccionada en el ComboBox
            switch (cbPersona.SelectedIndex)
            {
                // Javier
                case 0 : 
                    // Si no es correcta la altura
                    if (!javier.setAltura(txtAltura.Text))
                    {
                        // Mensaje de error, asignamos errorPovider al TextBox altura y le damos el foco.
                        errorProvider.SetError(txtAltura, "La altura es incorrecta.");
                        txtAltura.Focus();
                        error = true;
                    }

                    try
                    {
                        javier.setPeso(txtPeso.Text);
                    }
                    catch (Exception ex)
                    {
                        // Si se produce una excepción, mensaje de error, asignamos errorPovider al TextBox altura y 
                        // le damos el foco si previamente no se lo hemos dado a la altura.
                        errorProvider.SetError(txtPeso, ex.Message);

                        if (!error)
                        {
                            txtPeso.Focus();
                            error = true;
                        }
                    }
                    break;

                // Jose
                case 1:
                    // Si no es correcta la altura
                    if (!jose.setAltura(txtAltura.Text))
                    {
                        // Mensaje de error, asignamos errorPovider al TextBox altura y le damos el foco.
                        errorProvider.SetError(txtAltura, "La altura es incorrecta.");
                        txtAltura.Focus();
                        error = true;
                    }

                    try
                    {
                        jose.setPeso(txtPeso.Text);
                    }
                    catch (Exception ex)
                    {
                        // Si se produce una excepción, mensaje de error, asignamos errorPovider al TextBox altura y 
                        // le damos el foco si previamente no se lo hemos dado a la altura.
                        errorProvider.SetError(txtPeso, ex.Message);

                        if (!error)
                        {
                            txtPeso.Focus();
                            error = true;
                        }
                    }

                    break;

                // Luís
                case 2 :
                    // Si no es correcta la altura
                    if (!luis.setAltura(txtAltura.Text))
                    {
                        // Mensaje de error, asignamos errorPovider al TextBox altura y le damos el foco.
                        errorProvider.SetError(txtAltura, "La altura es incorrecta.");
                        txtAltura.Focus();
                        error = true;
                    }

                    try
                    {
                        luis.setPeso(txtPeso.Text);
                    }
                    catch (Exception ex)
                    {
                        // Si se produce una excepción, mensaje de error, asignamos errorPovider al TextBox altura y 
                        // le damos el foco si previamente no se lo hemos dado a la altura.
                        errorProvider.SetError(txtPeso, ex.Message);

                        if (!error)
                        {
                            txtPeso.Focus();
                            error = true;
                        }
                    }
                    break;
            }

            String msg = "¡Todo correcto!";

            if (error)
                msg = "Revise los errores.";
            
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