

using Microsoft.Extensions.Logging;

namespace Planable
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Navigation.PushAsync(new LoginPage());
        }

       private async void main_Button(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync(nameof(PageBudget));
        }
        private async void button2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageBudget()); //Basically creates a new instance of the class

        }
        private async void button3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FinanceCalculator()); //Basically creates a new instance of the class
        }
        private async void button4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs()); //Basically creates a new instance of the class
        }
        private async void button5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyFinancePage()); //Basically creates a new instance of the class
        }
    }

}
