namespace ConsumoWSDLForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void btnSomar_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient cliente = new();
            Double n1 = Convert.ToDouble(txbN1.Text);
            Double n2 = Convert.ToDouble(txbN2.Text);
            Double res = await cliente.CalcularAsync(n1, n2, "+");
            lblResultado.Text = res.ToString();
        }
    }
}