using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionesGrupales
{
    public partial class Calificaciones : Form
    {
        ClassCalificacionesGrupales objCalificaciones = new ClassCalificacionesGrupales();
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "Aprobados: " + objCalificaciones.Aprobados.ToString();
            label6.Text = "Reporobados: " + objCalificaciones.Reprobados.ToString();
            label7.Text = "Promedio Grupal: " + objCalificaciones.PromedioGrupal.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
            errorProvider1.SetError(textBox1, "Introduce una calificacaion");
            textBox1.Focus();
            return;
            }
            errorProvider1.SetError(textBox1, "");


            objCalificaciones.CalifCapturada = int.Parse(textBox1.Text.ToString());
            objCalificaciones.ContarAprobados();
            textBox1.Text = "";
            MessageBox.Show("Debe introducir una calificacion");
            textBox1.Clear();
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
