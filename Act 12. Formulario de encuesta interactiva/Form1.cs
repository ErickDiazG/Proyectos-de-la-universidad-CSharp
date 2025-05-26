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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                || comboBox1.SelectedIndex == -1 || (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked))
            {
                MessageBox.Show("No dejes espacios en blanco");
                return;
            }

            try
            {
                string nombre = textBox1.Text;
                int edad = int.Parse(textBox2.Text);
                if (edad <= 18 || edad >= 100)
                {
                    MessageBox.Show("Pon una edad valida");
                }

                string correo = textBox3.Text;
                string servicio = comboBox1.SelectedItem.ToString();
                string mejora = "";
                if (checkBox1.Checked) mejora += "Atencion";
                if (checkBox2.Checked) mejora += "Tiempo de espera";
                if (checkBox3.Checked) mejora += "Costos";
                if (checkBox4.Checked) mejora += "Infraestructura";

                label7.Text = $"Mi nombre es: {nombre} y tengo {edad} años\nMi correo es: {correo}" +
                    $"\nEl servicio que mas uso es el {servicio}\nLos aspectos a mejorar para mi son: {mejora} y mi sugerencias son:" +
                    $" \n{textBox4.Text}";

                panel1.Visible = true;

                Limpiar();

            }
            catch (FormatException)
            {
                MessageBox.Show("Usa valores correctos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
        private void Limpiar()
        {
            //Limpiar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            //Resetear
            comboBox1.SelectedIndex = -1;

            //Desenmarcar
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            //Desenmarcar
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3 .Checked = false;
            checkBox4.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Transporte publico");
            comboBox1.Items.Add("Servicio de salud");
            comboBox1.Items.Add("Servicio financiero");
            comboBox1.Items.Add("Servicio gubernamental");
        }

    }
}
