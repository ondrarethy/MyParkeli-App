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
        public string address;
        public string Address
        {
            get { return address; }
            set { address = value; this.OnPropertyChanged(); }
        }
        public int free;
        public int Free
        {
            get { return free; }
            set { free = value; this.OnPropertyChanged(); }
        }
        public int maxcap;
        public int MaxCap
        {
            get { return maxcap; }
            set { maxcap = value; this.OnPropertyChanged(); }
        }
        public int lon;
        public int Lon
        {
            get { return lon; }
            set { lon = value; this.OnPropertyChanged(); }
        }
        public int lat;
        public int Lat
        {
            get { return lat; }
            set { lat = value; this.OnPropertyChanged(); }
        }
        public string live;
        public string Live
        {
            get { if (live == "true") { return "red"; }; return live; }
            set { live = value; this.OnPropertyChanged(); }
        }
    }
}
