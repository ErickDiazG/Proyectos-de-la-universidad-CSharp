using System.Web;

namespace Act_papeleria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Lapiz");
            comboBox1.Items.Add("Borrador");
            comboBox1.Items.Add("Tijeras");
            comboBox1.Items.Add("Cuaderno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa tu nombre.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto.");
                return;
            }

            string carrito = comboBox1.SelectedItem.ToString();

            label1.Text = $"Hola {nombre} BIENVENIDO A LA PAPELERIA\nHas seleccionado: {carrito}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string seleccion = comboBox1.SelectedItem.ToString();

                    switch(seleccion)
                    {
                        case "Lapiz":
                            pictureBox1.Image = Properties.Resources.Lapiz;
                            break;
                        case "Borrador":
                            pictureBox1.Image = Properties.Resources.Borrador; 
                            break;
                        case "Tijeras":
                            pictureBox1.Image = Properties.Resources.Tijeras;
                            break;
                        case "Cuaderno":
                            pictureBox1.Image = Properties.Resources.Libro;
                            break;
                        default:
                            pictureBox1.Image = null;
                            break;
                    }

                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar la imagen:" + ex.Message);
            }
        }
    }
}
