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
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
            InitializeComponent();
            //lblUser.Text = usuario;
        }
        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}