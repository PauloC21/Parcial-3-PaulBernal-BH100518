using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario4 : ContentPage
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String Numero = txtNumero.Text;
            String direccion = txtDireccion.Text;

            if ((Numero == null) && (direccion == null))
            {
                lbl.Text = "Rellene todos los campos";
            }

            else
            {
                Navigation.PushAsync(new MainPage());
                DisplayAlert("Mensaje", "Completado", "OK");
            }
        }
    }
}