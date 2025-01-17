using ListViewHulk.IOC;
using ListViewHulk.Views;
using Xamarin.Forms;

namespace ListViewHulk
{
    public partial class App
    {
        public App(BootstrapBase bootstrap)
        {
            InitializeComponent();

            bootstrap.Start();

            // MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
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