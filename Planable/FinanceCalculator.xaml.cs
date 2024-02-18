namespace Planable;

public partial class FinanceCalculator : ContentPage
{
	public FinanceCalculator()
	{
		InitializeComponent();
	}

    private async void Calculate_Button_Clicked(object sender, EventArgs e)
    {
        //income
        double Monthly_income =0;
        double income =0;
        income += (double.Parse(maintenanceLoan.Text)/3)/4;
        income += double.Parse(otherFunding.Text)/12;

        Monthly_income += (double.Parse(maintenanceLoan.Text) / 3) / 4;
        Monthly_income += double.Parse(otherFunding.Text) / 12;

        Monthly_income += double.Parse(fromJob.Text);
        Monthly_income += double.Parse(otherIncome.Text);

        //outgoings
        double outgoings =0;
        outgoings += double.Parse(rent.Text);
        outgoings += double.Parse(food.Text);
        outgoings += double.Parse(otherExpenses.Text);

        Monthly_Income.Text = "Your total Monthly Income £" + Monthly_income.ToString("#.##");
        Monthly_Expenses.Text = "Your total Monthly Outgoings £" + outgoings.ToString("#.##");
        double budget = 0;

        budget = double.Parse(rent.Text) + double.Parse(food.Text) + double.Parse(otherExpenses.Text);

        budget += budget * 0.1;

        if (income < budget)
        {
            await DisplayAlert("Uh oh", "You are spending too much", "OK");

            Weekly_Budget.Text = "Your weekly budget is £" + (budget).ToString("#.##") + " You are spending too much!";
        }
        else if (budget < income)
        {
            if (income > income * 0.5)
            {
                await DisplayAlert("Treat yourself", "You have more money than you need, go out for a nice dinner", "OK"); //Add other random messages
                Weekly_Budget.Text = "Your weekly budget is £" + (budget).ToString("#.##") + "Your maintenance loan covers your entire budget";
            }
            else
            {
                await DisplayAlert("Good job", "You have enough money to cover your expenses", "OK");
                Weekly_Budget.Text = "Your weekly budget is £" + (budget).ToString("#.##") + " Your maintenance loan covers your entire budget";
            }
            
        }
        else
        {
            Weekly_Budget.Text = "Your weekly budget is £" + (budget).ToString("#.##");
        }

    }
}