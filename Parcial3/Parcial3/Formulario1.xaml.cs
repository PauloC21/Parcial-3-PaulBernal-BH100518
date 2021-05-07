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
    public partial class Formulario1 : ContentPage
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String uName = txtName.Text;
            String uLastname = txtLastName.Text;
            String edad = txtEdad.Text;

            if ((uName == null) && (uLastname == null) && (edad == null))
            {
                lbl.Text = "Rellene todos los campos";
            }

            else
            {
                Navigation.PushAsync(new Formulario2());
                DisplayAlert("Mensaje", "Datos Guardados", "OK");
            }
        }
    }
}