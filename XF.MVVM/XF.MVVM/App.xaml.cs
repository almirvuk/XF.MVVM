using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVM.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AddPersonPage());
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
