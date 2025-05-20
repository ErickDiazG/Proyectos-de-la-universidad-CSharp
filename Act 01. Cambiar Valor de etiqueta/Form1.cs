namespace Cambiar_Valor_de_etiqueta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = "Valor";
            int num1 = 1;
            double num2 = .1;

            double suma = num1 + num2;


            label2.Text = valor + " " + suma.ToString();

        }
    }
}
