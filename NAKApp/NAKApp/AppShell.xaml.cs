using NAKApp.Views;
using Xamarin.Forms;

namespace NAKApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddMyCoffeePage),
                typeof(AddMyCoffeePage));

            Routing.RegisterRoute(nameof(MyCoffeeDetailsPage),
                typeof(MyCoffeeDetailsPage));

            Routing.RegisterRoute(nameof(RegistrationPage),
                typeof(RegistrationPage));
        }
    }
}
