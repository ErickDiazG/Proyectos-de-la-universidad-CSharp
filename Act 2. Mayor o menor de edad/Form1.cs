namespace Mayor_o_menor_de_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = Int32.Parse(textBox1.Text);
            bool esMayorDeEdad = edad >= 18;
            bool esMenorDeCero = edad < 0;
            bool masDeCien = edad > 100;

            if (masDeCien)
            {
                MessageBox.Show("Ya te vas a morir");
            }
            else if (esMenorDeCero)
            {
                MessageBox.Show("Pon bien tu edad");
            }
            else if (esMayorDeEdad)
            {
                MessageBox.Show("Eres mayor de edad");
            }
            else
            {
                MessageBox.Show("Eres menor de edad");
            }

        }

    }
}
