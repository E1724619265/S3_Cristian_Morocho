using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3_Cristian_Morocho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }
        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "cmorocho";
            string password = "12345678";

            if(usuario == txtusuario.Text && password == txtpassword.Text)
            {
                Navigation.PushAsync(new registro(usuario));
            }else
            {
                DisplayAlert("ALERTA", "USUARIO O CONTRASEÑA INCORRECTOS", "CERRAR");
            }
        }
    }
}