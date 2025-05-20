namespace Act_12_Formulario_de_encuesta_interactiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Transporte publico");
            comboBox1.Items.Add("Servicios de salud");
            comboBox1.Items.Add("Servicios financieros");
            comboBox1.Items.Add("Servicios gubernamentales");
        }
    }
}
