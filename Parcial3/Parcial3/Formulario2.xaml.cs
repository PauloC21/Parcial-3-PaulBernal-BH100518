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
    public partial class Formulario2 : ContentPage
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String dui = txtDUI.Text;
            String nit = txtNIT.Text;

            if((dui == null) && (nit == null))
            {
                lbl.Text = "Rellene todos los campos";
            }
            
            else
            {
                Navigation.PushAsync(new Formulario3());
                DisplayAlert("Mensaje", "Datos Guardados", "OK");
            }
        }
    }
}