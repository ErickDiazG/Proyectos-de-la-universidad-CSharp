namespace Registro_de_usuarios_con_vaidaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") //  || Significa O
            {
                MessageBox.Show("Error: Debes llenar todos los campos.");
                return;
            }

            try
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                int edad = Int32.Parse(textBox3.Text);
                textBox1.Clear(); //Aqui lo que hice es que con el boton de agregar info igual sirva para borrar la info del textbox
                textBox2.Clear();
                textBox3.Clear();

                if (edad <= 0)
                {
                    MessageBox.Show("Ingresa Edad Valida");
                    return;
                }
                if (edad > 110)
                {
                    MessageBox.Show("Ingresa Edad Valida");
                    return ;
                }


                // Aqui lo que hare es para verificar lo del genero
                string genero;  // Solo declare

                if (radioButton1.Checked) //El Checked sirve para verificar si se selecciono eso es un tru (propiedad booleana)
                {
                    genero = "Masculino";
                }
                else if (radioButton2.Checked)
                {
                    genero = "Femenino";
                }
                else if (radioButton3.Checked)
                {
                    genero = "Otro";
                }
                else
                {
                    genero = "No seleccionado";
                }

                label5.Text = $"Informacion agregada:\n{nombre}\n{apellido}\n{edad} años\n{genero}\n{DateTime.Now}"; //DateTime.Now sirve para la fecha y hora
            }
            catch (FormatException)
            {
                MessageBox.Show("Agrega una Edad valida");
            }
        }
    }
}
