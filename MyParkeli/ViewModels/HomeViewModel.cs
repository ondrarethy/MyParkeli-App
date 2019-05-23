using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyParkeli.ViewModels.Abstract;
using MyParkeli.ViewModels.ItemList;
using Xamarin.Forms;

namespace MyParkeli.ViewModels
{
    class HomeViewModel : ViewModel
    {
        public HomeViewModel()
        {
            this.viewPoints = new List<ItemViewModel>
            {
                new ItemViewModel {Title = "parkoviste1", Address = "adresa1", Free = 24, MaxCap = 100, Live = "true"},
                new ItemViewModel {Title = "parkoviste2", Address = "adresa2", Free = 109, MaxCap = 250},
                new ItemViewModel {Title = "parkoviste3", Address = "adresa3", Free = 14, MaxCap = 75},
                new ItemViewModel {Title = "parkoviste4", Address = "adresa4", Free = 62, MaxCap = 125},
                new ItemViewModel {Title = "parkoviste5", Address = "adresa5", Free = 192, MaxCap = 320},
                new ItemViewModel {Title = "parkoviste6", Address = "adresa6", Free = 2, MaxCap = 18},
                new ItemViewModel {Title = "parkoviste7", Address = "adresa7", Free = 101, MaxCap = 115},
            };
        }

        private List<ItemViewModel> viewPoints;
        public List<ItemViewModel> ViewPoints
        {
            get
            {
                return this.viewPoints;
            }
            set
            {
                this.viewPoints = value;
                this.OnPropertyChanged();
            }
        }
    }
}
