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
        Persona jose = new Persona();             // Creamos el objeto jose de la clase Persona. Contructor por defecto.
        Persona javier = new Persona(2.0, 95.0);  // Creamos el objeto javier de la clase Persona.
        Persona luis = new Persona(1.5, 57.0);    // Creamos el objeto luis de la clase Persona.

        Atleta pedro = new Atleta(2.15, 105.0, 19.0); // Creamos el objeto pedro de la clase Atleta.

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

            // Si la altura no es correcta (Controlado por booleanos)
            if (!persona.setAltura(txtAltura.Text))
            {
                // Asignamos errorPovider al TextBox altura, le damos el foco al TextBox altura
                // e indicamos que hay un error.
                errorProvider.SetError(txtAltura, "La altura es incorrecta.");
                txtAltura.Focus();
                error = true;
            }

            // Si el peso es correcto (Contolado con excepciones)
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
            // Seleccionamos el primer elemento del ComboBox persona.
            cbPersona.SelectedIndex = 0;

            // Damos el foco al TextBox altura
            txtAltura.Focus();
        }

        private void btnPedro_Click(object sender, EventArgs e)
        {
            // Ponemos la altura de pedro. 
            pedro.setAltura(10.0);

            // Mostramos la altura de pedro.
            MessageBox.Show("Altura de Pedro: " + Convert.ToString(pedro.getAltura()));

            // Ponemos la marca de pedro a través de la propiedad.
            // No se modificará porque es negativa y mostrará la excepción.
            try
            {
                pedro.Marca = -100.0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Mostramos la marca de pedro a través de la propiedad.
            MessageBox.Show("Marca de Pedro: " + Convert.ToString(pedro.Marca));

            // Ponemos la marca de pedro a través del setter.
            pedro.setMarca(100.0);

            // Mostramos la marca de pedro a través del getter.
            MessageBox.Show("Marca de Pedro: " + Convert.ToString(pedro.getMarca()));
        }
    }

    public class Persona
    {
        private double altura = 0.0;
        private double peso = 0.0;

        // Constructor con parámetros "altura" y "peso"
        public Persona(double altura, double peso)
        {
            setAltura(altura);
            setPeso(peso);
        }

        // Constuctor sin parámetros.
        public Persona()
        {
            altura = 1.75;
            peso = 70.0;
        }

        // Para verificar que es correcta la altura.
        private bool AlturaCta(double altura)
        {
            // Si es mayor de 100 cm...
            if (altura > 0.1)
                return true;

            // En caso cotrario error.
            return false;
        }

        // Getter para obtener la altura.
        public double getAltura()
        {
            return altura;
        }

        // Setter para poner la altura mediante un parámetro double "altura".
        public bool setAltura(double altura)
        {
            // Si la altura no es correcta, error.
            if (!AlturaCta(altura))
                return false;

            // Ponemos la altura. 
            // Observar la utilización de la palabra reservada "this" para 
            // indicar que es la propiedad, no el parámetro "altura".
            this.altura = altura;

            // Todo correcto.
            return true;
        }

        // Setter para poner la altura mediante un parámetro string "altura".
        public bool setAltura(String altura)
        {
            // Si me pasan una cadena vacío, error.
            if (altura == "")
                return false;


            // Variable para intentar la conversión.
            double ps;

            try
            {
                // Intento convertir la "altura"
                // Aprovechamos el método setAltura.
                ps = Convert.ToDouble(altura);
            }
            catch (Exception)
            {
                // Si no se pudiese convertir "altura" a double capturamos la excepción
                // y devolvemos error.
                return false;
            }

            // Aprovechamos el método setAltura, pasándole el valor convertido a double.
            return setAltura(ps);
        }

        // Getter para obtener el peso.
        public double getPeso()
        {
            return peso;
        }

        // Setter para poner el peso mediante un parámetro double "peso".
        public void setPeso(double peso)
        {
            // Si es menor que 100 gr, lanzamos una excepción.
            if (peso < 0.1)
                throw new Exception("Peso incorrecto. No puede ser menor de 100 gr.");

            // En caso contrario asignamos el "peso"
            // De nuevo observar el uso de la palabra reservada "this"
            this.peso = peso;
        }

        // Setter para poner el peso mediante un parámetro string "peso".
        public void setPeso(String peso)
        {
            // Si el peso está vacío, lanzamos una excepción.
            if (peso == "")
                throw new Exception("Peso incorrecto. No puede estar vacío.");

            // Variable para intentar la conversión.
            double ps;
            
            try
            {
                // Intento convertir el "peso"
                // Aprovechamos el método setPedo.
                ps = Convert.ToDouble(peso);
            }
            catch (Exception)
            {
                // Si no se pudiese convertir "peso" a double capturamos la excepción
                // y devolvemos error.
                throw new Exception("Peso incorrecto. No es un valor numérico.");
            }

            // Aprovechamos el método setPeso, pasándole el valor convertido a double.
            setPeso(ps);
        }
    }

    public class Atleta : Persona
    {
        private double marca = 0.0;

        // Constructor de la clase.
        // Observar que debemos llamar al contructor de la clase Persona.
        // En este caso le pasamos, la altura y el peso.
        public Atleta(double altura, double peso, double marca) : base(altura, peso)
        {
            this.marca = marca;
        }

        // Accedemos a la propiedad marca.
        public double Marca
        {
            get => marca;

            set
            {
                // No permitimos que no introduzcan valores negativos.
                if (value < 0)
                    throw new Exception("La marca no puede ser negativa.");
                
                // Todo correcto asignamos la marca.
                marca = value;
            }
        }

        // Accedemos a la propiedad marca mediante getter
        public double getMarca()
        {
            return marca;
        }

        // Damos valor a la propuiedad marca mediante setter
        public void setMarca(double marca)
        {
            this.marca = marca;
        }
    }
}