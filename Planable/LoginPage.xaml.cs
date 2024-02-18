//using System.IO;
using System.Text;

namespace Planable;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Sign_In_pressed(object sender, EventArgs e)
    {
		string Password_to_hash = Password_Entry.Text;
        Console.WriteLine("Input Username");
        Console.WriteLine(Username_Entry.Text);
        Console.WriteLine("Input password");
		Console.WriteLine(Password_to_hash);
		//Add hashing algorithm here later




        using var stream = await FileSystem.OpenAppPackageFileAsync("Login_details.txt");
        using var reader = new StreamReader(stream);
		var contents = reader.ReadToEnd();
		var lines = contents.Split("#");
		for(int i = 0; i < lines.Length; i++)
		{
			var temp = lines[i].Split(",");
            string username = temp[0];
			string password = temp[1];
			Console.WriteLine(username);
            Console.WriteLine(password);
            if (username == Username_Entry.Text)
			{

                if (password == Password_to_hash)
				{
                    await DisplayAlert("Success", "You have successfully logged in", "OK");
                    
					Logged_in log = new Logged_in();
					log.logged_in(true);

					break;
                }
                else
				{
                    await DisplayAlert("Error", "Incorrect password", "OK");
					break;
                }
            }
			else if (i == lines.Length - 1)
			{
                await DisplayAlert("Error", "Username not found", "OK");
            }
			
		}
		
    }
}