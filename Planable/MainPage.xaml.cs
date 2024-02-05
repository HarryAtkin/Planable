

namespace Planable
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

       private async void main_Button(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("PageBudget");
        }
        private async void button2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageBudget());

        }
        private async void button3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FinanceCalculator());
        }
        private async void button4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs());
        }
        private async void button5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyFinancePage());
        }
    }

}
