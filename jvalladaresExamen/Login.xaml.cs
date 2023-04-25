using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jvalladaresExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                //Navigation.PushAsync(new Registro());
                await Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
    }
}