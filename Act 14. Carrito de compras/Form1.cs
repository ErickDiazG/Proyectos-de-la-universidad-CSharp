namespace Act_8._Carrito_de_compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pantalon");
            comboBox1.Items.Add("Camisa");
            comboBox1.Items.Add("Zapatos");
            comboBox1.Items.Add("Sombrero");
            comboBox1.Items.Add("Corbata");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = comboBox1.SelectedItem.ToString();
            Carrito.Items.Add(productoSeleccionado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            int totalProductosCargados = Carrito.Items.Count;

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = Carrito.Items[i].ToString();
                if (productoElegido == "Pantalon")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                else if (productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
                else if (productoElegido == "Sombrero")
                {
                    precioFinal += 15;
                }
                else if (productoElegido == "Corbata")
                {
                    precioFinal += 10;
                }
            }

            if (textBox1.Text == "NAVIDAD")
            {
                precioFinal *= 0.9;
            }

            label3.Text = $"El precio final es: {precioFinal}";
        }
    }
}
