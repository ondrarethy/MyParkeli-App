using System;
using MyParkeli.ViewModels.Abstract;
namespace MyParkeli.ViewModels.ItemList
{
    public class ItemViewModel : ViewModel
    {
        public string title;
        public string Title
        {
            get { return title; }
            set { title = value; this.OnPropertyChanged(); }
        }
        public string subtitle;
        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; this.OnPropertyChanged(); }
        }
    }
}
