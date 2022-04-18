using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumaNumeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(valor1.Text);
                float b = float.Parse(valor2.Text);
                float c = a + b;
                resultado.Text = a + "+" + b + "=" + c;

            }
            catch (Exception)
            {
                resultado.Text = "Datos Invalidos";
            }
        }
    }
}
