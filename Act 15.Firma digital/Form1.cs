using System; //Estas librerias vamos a usar para el dibujo
using System.Drawing; //Estas librerias vamos a usar para el dibujo
using System.Windows.Forms; //Estas librerias vamos a usar para el dibujo
using System.IO; //Estas librerias vamos a usar para el dibujo

namespace Firma_digital
{
    public partial class Form1 : Form
    {
        private bool dibujando = false; //Estas variables vamos a usar para el dibujo
        private Point puntoAnterior; //Estas variables vamos a usar para el dibujo, es para el puntero
        private Bitmap firmaBitmap; //Estas variables vamos a usar para el dibujo
        public Form1()
        {
            InitializeComponent();
            panelFirma.MouseDown += panelFirma_MouseDown;
            panelFirma.MouseMove += panelFirma_MouseMove;
            panelFirma.MouseUp += panelFirma_MouseUp;
            panelFirma.Paint += panelFirma_Paint;
            firmaBitmap = new Bitmap(panelFirma.Width, panelFirma.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Imagen PNG | *.png"; //Archivo csv.csv
                sfd.Title = "Guardar Firma"; //
                sfd.FileName = "firma.png"; //El tipo de formato
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    firmaBitmap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Firma Guardada exitosamente", "Exito");
                }
            }
        }
        private void panelFirma_MouseDown(object sender, MouseEventArgs e) //Es para declarar los movimientos
        {
            dibujando = true; //Cuando mueva el mouse hacia abajo va a dibujar una linea y va continuar
            puntoAnterior = e.Location;
        }
        private void panelFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando) // Las acciones del mouse se hacen en el codigo
            {
                using (Graphics g = Graphics.FromImage(firmaBitmap))
                {
                    g.DrawLine(Pens.Black, puntoAnterior, e.Location);
                }
                panelFirma.Invalidate();
                puntoAnterior = e.Location;
            }
        }
        private void panelFirma_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false; //Cuando lo mueve hacia arriba no dibujara, solo cuando vaya hacia abajo
        }

        private void panelFirma_Paint(object sender, PaintEventArgs e)
        {
            if (firmaBitmap != null)
            {
                e.Graphics.DrawImage(firmaBitmap, Point.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firmaBitmap = new Bitmap(panelFirma.Width, panelFirma.Height);
            panelFirma.BackgroundImage = firmaBitmap;
            panelFirma.Invalidate();
        }
    }
}
