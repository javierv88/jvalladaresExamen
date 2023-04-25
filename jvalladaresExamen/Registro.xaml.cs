using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jvalladaresExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private object usuario;

        public Registro(string usuario)
        {
            InitializeComponent();
           // DisplayAlert("Mensaje", "El usuario es " + usuario +  "cerrar");
            lblUser.Text = usuario;
            
        }

       

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            double valorInicial = Double.Parse(txtVinicial.Text);
           

            if (valorInicial <=2999)
            {
                //double porcentaje = (double)valorInicial / 3000 * 100;
                
                
                double valorCurso = 3000;
                double rectaValor = (valorCurso - valorInicial);
                double valorCuota = (rectaValor / 3);
                double valorPorcentaje = 0.05;
                double resultadoPorcentaje = (valorCurso * valorPorcentaje);
                double restadoFinal = (valorCuota + resultadoPorcentaje);

                txtPmensual.Text = restadoFinal.ToString();
               // lblResultado.Text = restadoFinal.ToString();

                //var pagoMensual = decimal.Parse(txtPmensual.Text);

                //Navigation.PushAsync(new Registro());

            }
            else
            {
                DisplayAlert("ALERTA", "Valor ingresado incorrecto", "Cerrar");
            
            }
        }

        public  void btnGuardar_Clicked(object sender, EventArgs e)
        {
            ///string usuario = txtUsuario.Text;
           Navigation.PushAsync(new Resumen ());
        }
    }
}