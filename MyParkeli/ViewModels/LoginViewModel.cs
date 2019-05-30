using System;
using System.ComponentModel;
using System.Windows.Input;
using MyParkeli.Views;
using MyParkeli.Models;
using Xamarin.Forms;
using System.Data.SQLite;
using System.Text;
using System.Runtime.CompilerServices;

namespace MyParkeli.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        string loginTxt = "Login";
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
        public async void OnSubmit()
        {
            loginTxt = "Loading...";
            OnPropertyChanged(nameof(LoginTxt));
            //Console.WriteLine("##############################################################################################################################");
            //Console.WriteLine("Email is: " + email);
            //Console.WriteLine(await Auth.GetHashFromDB(email));
            //Console.WriteLine("Pass is: " + password);
            //Console.WriteLine(Auth.GetHashString(password));
            var hash_db = await Auth.GetHashFromDB(email);
            hash_db = hash_db.Trim('"');
            var hash = Auth.GetHashString(password);
            if (email == null || password == null)
            {
                DisplayInvalidLoginPrompt(); 
                loginTxt = "Login";
                OnPropertyChanged(nameof(LoginTxt));
            }
            else if (hash_db != hash)
            {
                DisplayInvalidLoginPrompt();
                loginTxt = "Login";
                OnPropertyChanged(nameof(LoginTxt));
            } 
            else if (hash_db == hash)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                DisplayInvalidLoginPrompt();
                loginTxt = "Login";
                OnPropertyChanged(nameof(LoginTxt));
            }
        }
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string LoginTxt
        {
            get
            {
                return $"{loginTxt}";
            }
        }

    }
}