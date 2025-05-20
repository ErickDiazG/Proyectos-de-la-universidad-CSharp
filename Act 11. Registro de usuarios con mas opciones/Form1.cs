namespace practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstudios.Items.AddRange(new string[] { "Primaria", "Secundaria", "Preparatorio", "Universidad" });
            pnlResumen.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text)
                || cmbEstudios.SelectedIndex == -1 || (!rbdFemenino.Checked && !rbdMasculino.Checked && !rbdOtro.Checked)) //lo que se refiere con == -1 es que si no hay ningun elemento seleccionado. Recordemos que el primer elemento es 0 y el segundo 1 y asi. 
            {
                MessageBox.Show("Llena todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Digita un num valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Warning es el icono que apaecera pero podemos poner Error (una x roja), o mas como el signo de interrogacion.
                return;
            }

            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string estudios = cmbEstudios.SelectedItem.ToString();
            string genero = rbdMasculino.Checked ? "Masculino" :
                            rbdFemenino.Checked ? "Femenino" : "Otro";

            string intereses = "";
            if (chkDeportes.Checked) intereses += "Deportes";
            if (chkArte.Checked) intereses += "Arte";
            if (chkTecnologia.Checked) intereses += "Tecnologia";
            if (chkMusica.Checked) intereses += "Musica";

            lblResume.Text = $"Nombre:{nombre} \nEdad:{edad}\nCorreo:{correo}\nGenero:{genero}\nEstudios:{estudios}\nIntereses:{intereses}";

            pnlResumen.Visible = true;

            LimpiarCampos();
        } 

        private void LimpiarCampos()
        {
            //Limpiar TextBox
            txtNombre.Clear();
            txtEdad.Clear(); 
            txtCorreo.Clear();

            //Resetear comboBox
            cmbEstudios.SelectedIndex = -1; //Recorddemos que -1 significa ningun elemento seleccionado

            //Desmarcar RadioButtons
            rbdFemenino.Checked = false;
            rbdMasculino.Checked = false;
            rbdOtro.Checked = false;

            //Desmarcar CheckBoxs
            chkDeportes.Checked = false;
            chkArte.Checked = false;
            chkTecnologia.Checked = false ;
            chkMusica.Checked = false;

        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
