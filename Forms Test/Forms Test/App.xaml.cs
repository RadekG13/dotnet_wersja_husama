
using FormsTest;
using FormsTest.Data;
using FormsTest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Forms_Test
{
    public partial class App : Application
    {
        public App(IUsersRepository usersRepository)
        {
            InitializeComponent();

            //MainPage = new LoginPage();
            //MainPage = new NavigationPage(new MainPage());
            //  MainPage = new NavigationPage(new LoginPage());
            /* MainPage = new RegisterPage()
             {
                 BindingContext= new UsersViewModel(usersRepository),

             };  */
            var registerPage = new RegisterPage()
            {
                BindingContext=new UsersViewModel(usersRepository)
            };
            MainPage = new NavigationPage(registerPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
