using Microsoft.Maui.Storage;
using System;


namespace Planable;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	private async void sign_up_button_pressed(object sender, EventArgs e)
    {
        string email = email_entry.Text;
        string username = username_entry.Text;
        string password = password_entry.Text;
        string dob = dob_entry.Text;
        

        //using var stream = await FileSystem.OpenAppPackageFileAsync("emails.txt");

        //using var reader = new StreamReader(stream);
        //var contents = reader.ReadToEnd();
        //var lines = contents.Split("#");



        /*for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(email))
            {
                await DisplayAlert("Error", "Email already in use", "OK");
                stream.Close();
            }
            else
            {


                









                /*
                int n = i++;
                FileInfo file = new FileInfo("emails.txt");
                file.IsReadOnly = false;
                File.WriteAllText("emails.txt", email + "," + n + "#");
                /*using FileStream outputStream = System.IO.File.OpenWrite("Resources\\Raw\\emails.txt");
                using StreamWriter streamWriter = new StreamWriter(outputStream);
                await streamWriter.WriteAsync(email + "," + n + "#"); */

                /*using var writer = new StreamWriter("emails.txt");
                await writer.WriteLineAsync(email + "," + n + "#");
                stream.Close();
                writer.Close();*/
                /*FileInfo file2 = new FileInfo("login_details.txt");
                file2.IsReadOnly = false;
                File.WriteAllText("login_details.txt", n + "," + username + "," + password + "," + dob + "#");

                /*using FileStream outputStream2 = System.IO.File.OpenWrite("Resources\\Raw\\login_details.txt");
                using StreamWriter streamWriter2 = new StreamWriter(outputStream2);
                await streamWriter.WriteAsync(n + "," + username + "," + password + "," + dob + "#");*/

                /*using var writer2 = new StreamWriter("login_details.txt");
                await writer2.WriteLineAsync(n + "," + username + "," + password + "," + dob + "#");*/

                /*
                User user = new User();
                user.user(email, username, password, dob); */

                /*
                await DisplayAlert("Success", "You have successfully signed up", "OK");
                using var To_write = await FileSystem.OpenAppPackageFileAsync("emails.txt");

                using var writer = new StreamWriter(To_write);
                //await writer.WriteLineAsync(email + "," + );

                User user = new User();
                user.user(email, username, password, dob);
                */

        //    }
        //}
        
    }

}