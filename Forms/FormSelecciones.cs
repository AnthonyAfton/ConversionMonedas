using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConversorDeMonedas
{
    public partial class FormSelecciones : Form
    {
        private int monSeleccion;
        public FormSelecciones(int monedaSelec)
        {
            InitializeComponent();
            monSeleccion = monedaSelec;
            InicializarMonedaListBox();
        }
        private void InicializarMonedaListBox()
        {
            switch (monSeleccion + 1)
            {
                //Dolar Estadounidense
                case 1:
                    monedasListBox.Items.Add("MXN - Peso Mexicano");
                    monedasListBox.Items.Add("CAD - Dolar Canadience");
                    monedasListBox.Items.Add("EUR - Euro");
                    monedasListBox.Items.Add("JPY - Yen Japones");
                    break;
                //Peso Mexicano
                case 2:
                    monedasListBox.Items.Add("USD - Dolar Estadounidense");
                    monedasListBox.Items.Add("CAD - Dolar Canadience");
                    monedasListBox.Items.Add("EUR - Euro");
                    monedasListBox.Items.Add("JPY - Yen Japones");
                    break;
                //Dolar Canadiense
                case 3:
                    monedasListBox.Items.Add("USD - Dolar Estadounidense");
                    monedasListBox.Items.Add("MXN - Peso Mexicano");
                    monedasListBox.Items.Add("EUR - Euro");
                    monedasListBox.Items.Add("JPY - Yen Japones");
                    break;
                    //Euro
                case 4:
                    monedasListBox.Items.Add("USD - Dolar Estadounidense");
                    monedasListBox.Items.Add("MXN - Peso Mexicano");
                    monedasListBox.Items.Add("CAD - Dolar Canadience");
                    monedasListBox.Items.Add("JPY - Yen Japones");
                    break;
                    //Yen Japones
                case 5:
                    monedasListBox.Items.Add("USD - Dolar Estadounidense");
                    monedasListBox.Items.Add("MXN - Peso Mexicano");
                    monedasListBox.Items.Add("CAD - Dolar Canadience");
                    monedasListBox.Items.Add("EUR - Euro");
                    break;
            }
        }
        private void acceptBtnClick(object sender, EventArgs e)
        {
            List<string> monSeleccionadas = [];

            foreach (object itemChecked in monedasListBox.CheckedItems)
            {
                monSeleccionadas.Add(itemChecked.ToString());
            }

            DatosGlobales.convMoneda.Clear();
            DatosGlobales.convMoneda.AddRange(monSeleccionadas);

            this.Close();
        }
        private void cancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
