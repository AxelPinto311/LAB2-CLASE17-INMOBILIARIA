using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        

        private void btnCrPiso_Click(object sender, EventArgs e)
        {
           
            lbldgtpiso.Visible = true;
            lblPiso.Visible = true;
            lblMetroCuadrados.Visible = true;
            lblIngrDatos.Visible = true;
            txtNumPiso.Visible = true;
            lblDireccion.Visible = true;
            txtDireccion.Visible = true;
            txtMetrosCuad.Visible = true;
            btnCrearPiso.Visible = true;
            btnLocal.Visible = false;
            btnPiso.Visible = false;
            lblInmobiliaria.Visible = false;
            lblSeleccion.Visible = false;
            lblAntiguedad.Visible = true;
            txtAntiguedad.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPiso_Click(object sender, EventArgs e)
        {
            double MetroCuadrado = Convert.ToDouble(txtMetrosCuad.Text);
            string Direccion = txtDireccion.Text;
            int NumPiso = Convert.ToInt32(txtNumPiso.Text);
            int antiguedad = Convert.ToInt32(txtAntiguedad.Text);
            double total;
            Piso p1 = new Piso(NumPiso, Direccion, MetroCuadrado,antiguedad);
            total=p1.Resultado(antiguedad, NumPiso);

            lblInmobiliaria.Visible = false;
            lblSeleccion.Visible = false;
            btnPiso.Visible = false;
            btnLocal.Visible = false;
            lblTotalP.Text = "El total a pagar es: $ " + total.ToString();
            lblTotalP.Visible = true;

            lbldgtpiso.Text = "Piso numero: "+p1.getNropiso();
            lblPiso.Visible = false;
            lblMetroCuadrados.Text = "Metros cuadrados: "+p1.getMetrosCuadrados();
            lblIngrDatos.Visible = false;
            txtNumPiso.Visible = false;
            lblDireccion.Text =  "La direccion es: "+p1.getDireccion();
            txtDireccion.Visible = false;
            txtMetrosCuad.Visible = false;
            btnCrearPiso.Visible = false;
            lblPiso.Visible = true;
            
            lblAntiguedad.Text = "Años de antiguedad: "+p1.getAntiguedad();
            txtAntiguedad.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccionL.Text;
            double MetroCuadrado = Convert.ToDouble(txtMetroCuadL.Text);
            int antiguedad = Convert.ToInt32(txtAntiguedadL.Text);
            int nroVentanas = Convert.ToInt32(txtNroVentanasL.Text);
            double total;
            Local l1 = new Local(MetroCuadrado, direccion, nroVentanas, antiguedad);
            total=l1.Resultado(antiguedad, nroVentanas, MetroCuadrado);
            


            lblDireccionL.Text="Direccion: "+l1.getDireccion();
            txtDireccionL.Visible = false;
            lblMetrosCuadradosL.Text="Metros cuadrados: "+l1.getMetrosCuadrados();
            txtMetroCuadL.Visible = false;
            lblNumeroVentanasL.Text="Cantidad de ventanas: "+l1.getNroVentanas();
            txtNroVentanasL.Visible = false;
            lblAntiguedadL.Text="Años de antiguedad: "+l1.getAntiguedad();
            txtAntiguedadL.Visible = false;
            btnCrearLocal.Visible = false; ;
            lblLOCAL.Visible = true;
            lblTotalL.Visible = true;
            lblTotalL.Text = "El total es: $" + total.ToString();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocal_Click(object sender, EventArgs e)
        {


            lblSeleccion.Visible = false;
            btnPiso.Visible = false;
            btnLocal.Visible = false;
            lblInmobiliaria.Visible = false;
            lblDireccionL.Visible = true;
            txtDireccionL.Visible = true;
            lblMetrosCuadradosL.Visible = true;
            txtMetroCuadL.Visible = true;
            lblNumeroVentanasL.Visible = true;
            txtNroVentanasL.Visible = true;
            lblAntiguedadL.Visible = true;
            txtAntiguedadL.Visible = true;
            btnCrearLocal.Visible = true;
            lblLOCAL.Visible = true;
        }
    }
}
