namespace Act_5._Hacer_un_listado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>(); // La declare aqui para que sea visible para los 2 botones

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Add(textBox1.Text);

            textBox1.Clear(); //Lo limpiara despues de agregar

            label4.Text = "Agregado correctamente";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                label5.Text = "Lista Vacia";
            }

            DatosDelListado.Items.Clear();

            foreach (string str in lista)
            {
                DatosDelListado.Items.Add(str);
            }
        }
    }
}
