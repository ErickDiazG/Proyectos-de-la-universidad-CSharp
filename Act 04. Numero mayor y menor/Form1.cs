namespace _4.__Numero_mayor_y_menor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener los numeros
                int numero1 = Int32.Parse(textBox1.Text); //Int32.Parse solo sirve para numeros enteros, si pondre decimales poner double.Parse
                int numero2 = Int32.Parse(textBox2.Text);
                int numero3 = Int32.Parse(textBox3.Text);

                //Encontrar el mayor
                int mayor = numero1;

                if (numero2 > mayor)
                {
                    mayor = numero2;
                }
                if (numero3 > mayor)
                {
                    mayor = numero3;
                }

                //Encontrar el menor
                int menor = numero1;

                if (numero2 < menor)
                {
                    menor = numero2;
                }
                if (numero3 < menor)
                {
                    menor = numero3;
                }

                MessageBox.Show($"El numero mayor es: {mayor}\nEl numero menor es: {menor}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese numeros enteros validos");
            }
        }
    }
}
