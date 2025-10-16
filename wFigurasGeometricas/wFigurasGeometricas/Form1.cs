using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wFigurasGeometricas
{
    public partial class Form1 : Form
    {
        private Color colorSeleccionado = Color.White;
        private int contador = 0;
        List<Figura> figuras = new List<Figura>();
        public Form1()
        {
            InitializeComponent();
            cmbTipoFigura.Items.Add("Rectangulo");
            cmbTipoFigura.Items.Add("Circulo");
            cmbTipoFigura.Items.Add("Triangulo");
            cmbTipoFigura.Items.Add("Linea");
            this.Paint += Form1_Paint;
            cmbTipoFigura.SelectedIndex = 0;
            pictureBox1.BackColor = colorSeleccionado;
        }
        
     
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var f in figuras)
            {
                f.Dibujar(e.Graphics);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = dlg.Color;
                pictureBox1.BackColor = colorSeleccionado;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPosicionX.Text, out int x) || !int.TryParse(txtPosicionY.Text, out int y))
                {
                    MessageBox.Show("Ingrese coordenadas válidas (números).");
                    return;
                }

                string tipo = cmbTipoFigura.SelectedItem.ToString();
                Figura nuevaFigura = FiguraFactory.CrearFigura(tipo, colorSeleccionado, new Point(x, y));
                figuras.Add(nuevaFigura);
                contador++;
                txtContador.Text = contador.ToString();
                this.Invalidate();
                this.Update();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
