namespace Formulario2
{
    public partial class frmIngresoYMuestraDeDatos : Form
    {
        public frmIngresoYMuestraDeDatos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dato1 = txtDato1.Text;
            string dato2 = txtDato2.Text;

            MessageBox.Show(dato1 + " " + dato2, "DATOS CAPTURADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptarCuadroTexto_Click(object sender, EventArgs e)
        {
            string datos;
            datos = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el dato requerido","DATOS A INGRESAR","Ingrese aquí el dato");
            MessageBox.Show(datos);
        }
    }
}
