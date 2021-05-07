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
    public partial class Formulario3 : ContentPage
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String estado = txtEstado.Text;
            String ocupacion = txtOcupacion.Text;
            String dinero = txtDinero.Text;

            if ((estado == null) && (ocupacion == null) && (dinero == null))
            {
                lbl.Text = "Rellene todos los campos";
            }

            else
            {
                Navigation.PushAsync(new Formulario4());
                DisplayAlert("Mensaje", "Datos Guardados", "OK");
            }
        }
    }
}