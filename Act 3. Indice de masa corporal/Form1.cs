namespace _3.__Indice_de_masa_corporal
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
                // Obtener el peso y altura
                string textoPeso = textBox1.Text;
                double Peso = double.Parse(textoPeso);

                string textoAltura = textBox2.Text;
                double altura = double.Parse(textoAltura);

                // Calcular el IMC
                double imc = Peso / (altura * altura);


                //Determina la categoria
                string categoria;
                if (imc < 18.5)
                {
                    categoria = "Bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9) // El && sirve para y (si todas las condiciones verdaderas se ejecuta)
                {
                    categoria = "Peso normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    categoria = "Sobrepeso";
                }
                else
                {
                    categoria = "Obesidad";
                }

                // Mostrar Resultado
                label4.Text = $"IMC: {imc:F2}\n Categoria: {categoria}"; // El \n sirve para salto de renglon y el imc:F2 es para que solo haya 2 decimales

            }
            catch
            {
                label4.Text = "Ingrese valores validos";
            }
        }
    }
}
