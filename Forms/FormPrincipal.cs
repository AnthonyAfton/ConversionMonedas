using System.Windows.Forms.VisualStyles;

namespace ConversorDeMonedas
{
    public partial class FormPrincipal : Form
    {
        private List<string> monConvertir = new List<string>();
        private int cantidadDinero;
        public FormPrincipal(List<string> monedaConvertir)
        {
            InitializeComponent();
            monConvertir.AddRange(monedaConvertir);
            InicializarOpcionesMoneda();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*Las cosas de arriba fueron errores por darle doble click, aqui empieza el codigo*/

        private void InicializarOpcionesMoneda()
        {
            monedasCbox.Items.Add("USD - Dolar Estadounidense");
            monedasCbox.Items.Add("MXN - Peso Mexicano");
            monedasCbox.Items.Add("CAD - Dolar Canadience");
            monedasCbox.Items.Add("EUR - Euro");
            monedasCbox.Items.Add("JPY - Yen Japones");
        }

       /*private void monedaCbox_SeleccionarItem(object sender, EventArgs e)
        {
            string seleccion = monedasCbox.SelectedItem.ToString();
        }*/

        private void calcularBtn_Click(object sender, EventArgs e)
        {   
            if(monedasCbox.SelectedItem == null)
            {
                return;
            }

            if(montoBox.Text == "")
            {
                return;
            }

            cantidadDinero = int.Parse(montoBox.Text);

            FormSelecciones fSelecciones = new FormSelecciones(monedasCbox.SelectedIndex);
            fSelecciones.ShowDialog();

            /*switch (monedasCbox.SelectedIndex + 1)
            {
                case 1:
                    dolarCovert();
                    return;
            }*/
            foreach (var item in monConvertir)
            {
                MessageBox.Show(item);
            }

        }
        private void dolarCovert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "MXN - Peso Mexicano":
                        resultadosBox.AppendText($"MXN - Peso Mexicanos              ${cantidadDinero * 17.38}");
                        break;
                    case "CAD - Dolar Canadience":
                        resultadosBox.AppendText($"CAD - Dolar Canadience            ${cantidadDinero * 1.36}");
                        break;
                }
            }
        }
    }
}
