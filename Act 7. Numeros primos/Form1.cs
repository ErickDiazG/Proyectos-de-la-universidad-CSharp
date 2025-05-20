namespace Act_7._Numeros_primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Pon un numero, no dejes espacio en blanco");
            }

            try
            {
                int numero = int.Parse(textBox1.Text);
                bool esNumeroPrimo = true;

                if (numero <= 1) 
                { 
                    esNumeroPrimo = false; 
                }
                else
                {
                    for (int i = 2; i < numero; i++)
                    {
                        if (numero % 2 == 0)
                        {
                            esNumeroPrimo = false;
                            break;
                        }
                    }
                }

                if (esNumeroPrimo)
                {
                    label3.Text = $"El numero {numero} es primo";

                }
                else
                {
                    label3.Text = $"El numero {numero} no es primo";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa un numero entero");
            }
        }
    }
}
