namespace Act_7.__Numero_impar_o_par
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
                double numero = double.Parse(textBox1.Text);
                bool esPar = (numero % 2 == 0);

                if (esPar)
                {
                    label3.Text = $"El numero {numero} es par";
                }
                else
                {
                    label3.Text = $"El numero {numero} es impar";
                }
            }
            catch
            {
                label3.Text = "Ingresa numeros validos";
            }
        }
    }
}
