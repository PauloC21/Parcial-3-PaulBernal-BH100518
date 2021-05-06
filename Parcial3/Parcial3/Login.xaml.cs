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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if(sUsuario == "Admin" && (sPassword== "Admin"))
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                lblResultado.Text = "El usuario o password son incorrectos!";
            }
        }
    }
}