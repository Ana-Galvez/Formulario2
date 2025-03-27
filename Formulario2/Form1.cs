using static System.Runtime.InteropServices.JavaScript.JSType;

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
            datos = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el dato requerido", "DATOS A INGRESAR", "Ingrese aquí el dato");
            MessageBox.Show(datos);
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            num1 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el primer número", "DATOS A INGRESAR", "Ingrese aquí el número"));
            num2 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el segundo número", "DATOS A INGRESAR", "Ingrese aquí el número"));

            if(num1 > num2) MessageBox.Show($"El número mayor es: {num1}");
            else if(num1 < num2) MessageBox.Show($"El número mayor es: {num2}");
            else MessageBox.Show("Los números son iguales");
        }
    }
}
