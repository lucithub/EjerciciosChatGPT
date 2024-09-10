using Ejercicio6._2ChatGPT.Dominio;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio6._2ChatGPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(txtLegajo.Text);
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            char sexo = Convert.ToChar(cboSexo);
            
        }

        private void btnMostrarInfoEstudiante_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
