using System.Windows.Forms.VisualStyles;

namespace ConversorDeMonedas
{
    public partial class FormPrincipal : Form
    {
        private List<string> monConvertir = new List<string>();
        private int cantidadDinero;
        public FormPrincipal()
        {
            InitializeComponent();
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
            resultadosBox.Clear();

            cantidadDinero = int.Parse(montoBox.Text);

            FormSelecciones fSelecciones = new FormSelecciones(monedasCbox.SelectedIndex);
            fSelecciones.ShowDialog();

            monConvertir.Clear();
            monConvertir.AddRange(DatosGlobales.convMoneda);

            switch (monedasCbox.SelectedIndex + 1)
            {
                case 1:
                    dolarCovert();
                    return;
                case 2:
                    pesoConvert();
                    return;
                case 3:
                    candConvert();
                    return;
                case 4:
                    euroConvert();
                    return;
                case 5:
                    yenConvert();
                    return;
            }

        }
        private void dolarCovert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "MXN - Peso Mexicano":
                        resultadosBox.AppendText($"MXN - Peso Mexicanos      ${cantidadDinero * 17.38}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "CAD - Dolar Canadience":
                        resultadosBox.AppendText($"CAD - Dolar Canadience    ${cantidadDinero * 1.36}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "EUR - Euro":
                        resultadosBox.AppendText($"EUR - Euro    €{ cantidadDinero * 0.86}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "JPY - Yen Japones":
                        resultadosBox.AppendText($"JPY - Yen Japones    ¥{cantidadDinero * 157.92}" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
        }
        private void pesoConvert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "USD - Dolar Estadounidense":
                        resultadosBox.AppendText($"USD - Dolar Estadounidense      ${cantidadDinero * 0.06}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "CAD - Dolar Canadience":
                        resultadosBox.AppendText($"CAD - Dolar Canadience    ${cantidadDinero * 0.08}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "EUR - Euro":
                        resultadosBox.AppendText($"EUR - Euro    €{ cantidadDinero * 0.05}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "JPY - Yen Japones":
                        resultadosBox.AppendText($"JPY - Yen Japones    ¥{cantidadDinero * 9.09}" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
        }
        private void candConvert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "USD - Dolar Estadounidense":
                        resultadosBox.AppendText($"USD - Dolar Estadounidense      ${cantidadDinero * 0.73}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "MXN - Peso Mexicano":
                        resultadosBox.AppendText($"MXN - Peso Mexicano    ${cantidadDinero * 12.76}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "EUR - Euro":
                        resultadosBox.AppendText($"EUR - Euro    €{ cantidadDinero * 0.63}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "JPY - Yen Japones":
                        resultadosBox.AppendText($"JPY - Yen Japones    ¥{cantidadDinero * 115.88}" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
        }
        private void euroConvert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "USD - Dolar Estadounidense":
                        resultadosBox.AppendText($"USD - Dolar Estadounidense      ${cantidadDinero * 1.17}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "MXN - Peso Mexicano":
                        resultadosBox.AppendText($"MXN - Peso Mexicano    ${cantidadDinero * 20.32}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "CAD - Dolar Canadience":
                        resultadosBox.AppendText($"CAD - Dolar Canadience    ${ cantidadDinero * 1.59}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "JPY - Yen Japones":
                        resultadosBox.AppendText($"JPY - Yen Japones    ¥{cantidadDinero * 184.66}" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
        }
        private void yenConvert()
        {   
            foreach (string item in monConvertir)
            {
                switch (item)
                {
                    case "USD - Dolar Estadounidense":
                        resultadosBox.AppendText($"USD - Dolar Estadounidense      ${cantidadDinero * 0.0063}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "MXN - Peso Mexicano":
                        resultadosBox.AppendText($"MXN - Peso Mexicano    ${cantidadDinero * 0.1101}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "CAD - Dolar Canadience":
                        resultadosBox.AppendText($"CAD - Dolar Canadience    ${ cantidadDinero * 0.0086}" + Environment.NewLine + Environment.NewLine);
                        break;
                    case "EUR - Euro":
                        resultadosBox.AppendText($"EUR - Euros    €{cantidadDinero * 0.0054}" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
        }
    }
}
