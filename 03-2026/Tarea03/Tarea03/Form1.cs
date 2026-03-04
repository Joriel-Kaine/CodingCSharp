namespace Tarea03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Tamano = 15;
        int[] valores = new int[Tamano];

        private void btnLeerVector(object sender, EventArgs e)
        {
            FuncionesVector.LeerVector(valores);
        }

        private void btnMostrarVector(object sender, EventArgs e)
        {
            MessageBox.Show(FuncionesVector.MostrarVector(valores));
        }

        private void btnCalcularMaximoYPrimeraPosicion(object sender, EventArgs e)
        {
            int mayor, posicion;

            FuncionesVector.PosicionMayorValor(valores, out mayor, out posicion);

            MessageBox.Show($"Valor mayor: {mayor}\n" +
                            $"Primera posición: {posicion}");
        }

        private void VectorNegativos(object sender, EventArgs e)
        {
            int[] valoresNegativos = FuncionesVector.ValoresNegativos(valores);

            MessageBox.Show(FuncionesVector.MostrarVector(valoresNegativos));
        }

        private void ContarValores(object sender, EventArgs e)
        {
            FuncionesVector.ContarValores(valores);

            MessageBox.Show($"Número valores entre 0 y 50: {valores}");
        }
    }
}
