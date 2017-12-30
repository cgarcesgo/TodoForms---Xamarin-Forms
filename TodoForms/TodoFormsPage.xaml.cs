using Xamarin.Forms;

namespace TodoForms
{
    public partial class TodoFormsPage : ContentPage
    {
        public TodoFormsPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text)){
                resultadoLabel.Text = "Debe escribir usuario y contraseña";
            } else {
                resultadoLabel.Text = "Inicio de sesión exitoso";
                await Navigation.PushAsync(new NuevoItem(), true);
            }
        }
    }
}
