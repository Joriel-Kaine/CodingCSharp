namespace Tarea01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Tamano = 12;
        int[] numeros = new int[Tamano];

        private void btnLeerVector_Click(object sender, EventArgs e)
        {
            FuncionesVector.LeerVector(numeros);
        }

        private void btnMostrarVector_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FuncionesVector.GenerarTextoVector(numeros));
        }

        private void btnSumaVector_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La suma del vector es: {FuncionesVector.SumarVector(numeros)}");
        }

        private void btnMostrarPares_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FuncionesVector.GenerarTextoParesVector(numeros));
        }

        private void btnMostrarPrimeraPosicion_Click(object sender, EventArgs e)
        {
            int posicion, valor;

            valor = FuncionesVector.LeerEntero("Introduce un valor: ");
            posicion = FuncionesVector.BuscarPrimeraPosicionVector(numeros, valor);

            if (posicion != -1)
            {
                MessageBox.Show($"La primera posición del valor es: {posicion}");
            }
            else
            {
                MessageBox.Show("El valor no está en el vector.");
            }
        }
    }
}
