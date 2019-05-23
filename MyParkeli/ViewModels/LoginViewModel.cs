using System;
using System.ComponentModel;
using System.Windows.Input;
using MyParkeli.Views;
using MyParkeli.Models;
using Xamarin.Forms;
using System.Text;

namespace MyParkeli.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
        public void OnSubmit()
        {
            Console.WriteLine("Email is: " + email);
            Console.WriteLine(Auth.GetHashFromDB(email));
            Console.WriteLine("Pass is: " + password);
            Console.WriteLine(Auth.GetHashString(password));
            if (Auth.GetHashFromDB(email) != Auth.GetHashString(password))
            {
                DisplayInvalidLoginPrompt();
            } else
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
        }

    }
}