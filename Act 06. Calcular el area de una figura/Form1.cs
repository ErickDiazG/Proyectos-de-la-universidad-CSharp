namespace Act_6._Calcular_el_area_de_una_figura
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
                MessageBox.Show("No dejes el espacio en blanco");
            }

            try
            {
                double lado = double.Parse(textBox1.Text);

                double areaCuadrado = lado * lado;

                label5.Text = $"Area: {areaCuadrado} ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Pon un valor valido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("No dejes el espacio en blanco");
            }

            try
            {
                double radio = double.Parse(textBox1.Text);
                double pi = 3.1416;

                double areaCirculo = pi * (radio * radio);

                label5.Text = $"Area: {areaCirculo} ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Pon un valor valido");
            }
        }
    }
}
