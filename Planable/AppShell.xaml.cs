namespace Planable
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PageBudget), typeof(ContentPage));
            Routing.RegisterRoute(nameof(AboutUs), typeof(ContentPage));
            Routing.RegisterRoute(nameof(FinanceCalculator), typeof(ContentPage));
            Routing.RegisterRoute(nameof(MyFinancePage), typeof(ContentPage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(ContentPage));

        }
    }
}
