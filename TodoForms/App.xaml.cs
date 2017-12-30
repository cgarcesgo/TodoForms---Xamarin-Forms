using Xamarin.Forms;

namespace TodoForms
{
    public partial class App : Application
    {
        public static string RUTA_BD;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TodoFormsPage());
        }

        public App(string rutaBD)
        {
            InitializeComponent();

            RUTA_BD = rutaBD;

            MainPage = new NavigationPage(new TodoFormsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
