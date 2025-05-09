namespace Act_6._Promedio_de_calificaciones
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
                double materia1 = double.Parse(textBox1.Text);
                double materia2 = double.Parse(textBox2.Text);
                double materia3 = double.Parse(textBox3.Text);
                double materia4 = double.Parse(textBox4.Text);
                double materia5 = double.Parse(textBox5.Text);
                double materia6 = double.Parse(textBox6.Text);

                double promedio = (materia1 + materia2 + materia3 + materia4 + materia5 + materia6) / 6.0;

                //FELICITACION 
                string felicitacion;
                if (promedio >= 6 && promedio < 10.1)
                {
                    felicitacion = "Felicidades estas aprobado";
                }
                else if (promedio > 0 && promedio < 6)
                {
                    felicitacion = "Nimodo, estas reprobado";
                }
                else
                {
                    felicitacion = "Promedio invalido";
                }

                label8.Text = $"El promedio es: {promedio:F2}\n{felicitacion}"; //Use el :F2 para que solo haya 2 decimales
            }
            catch
            {
                label8.Text = "Ingresa numeros validos";
            }
        }
    }
}
