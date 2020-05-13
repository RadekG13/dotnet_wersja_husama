using Forms_Test;
using FormsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        Init();

    }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s,e);
        }
         void SignInProcedure(object sender, EventArgs e)//PRZEROBIĆ NA ASYNC??
        {
            //User user = new User(Entry_Username.Text, Entry_Password.Text);
            //if(user.CheckInformation())
            //{
            //    DisplayAlert("Login", "Login Success", "Okey");
            //     Navigation.PushAsync(new MainPage());
            //}
            //else
            //{
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Okey");
           // }
        }


        public void ShowPass(object sender, EventArgs args)
        {
            Entry_Password.IsPassword = Entry_Password.IsPassword ? false : true;
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

    }
}