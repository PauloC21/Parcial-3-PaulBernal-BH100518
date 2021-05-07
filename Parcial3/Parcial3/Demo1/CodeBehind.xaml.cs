using Parcial3.Utilities;
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
    public partial class CodeBehind : ContentPage
    {
        public CodeBehind()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            String contra = Password.Text;

            if (RegexUtilities.IsValidEmail(Email.Text) && (contra != null))
            {
                Error.Text = "Email y Contraseña validos";
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                Error.Text = "Email o Contraseña invalido";
            }
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;
            var entry = sender as Entry;

            if (RegexUtilities.IsValidEmail(email))
            {
                Error.Text = "Email valido";
                entry.BackgroundColor = Color.Blue;
                entry.TextColor = Color.Green;
            }
            else
            {
                Error.Text = "Email invalido";
                entry.BackgroundColor = Color.Red;
                entry.TextColor = Color.Orange;
            }
        }
    }
}