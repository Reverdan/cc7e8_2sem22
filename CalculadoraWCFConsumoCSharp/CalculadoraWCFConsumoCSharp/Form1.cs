using ServiceReference1;

namespace CalculadoraWCFConsumoCSharp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calcular(String op)
        {
            Service1Client s1 = new Service1Client();
            lblResultado.Text = s1.CalcularAsync(txbNumero1.Text, txbNumero2.Text, op).Result;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            calcular("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            calcular("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            calcular("/");
        }
    }
}