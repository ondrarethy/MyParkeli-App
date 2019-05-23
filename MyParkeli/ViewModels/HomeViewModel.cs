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
                new ItemViewModel {Title = "title1", Subtitle = "subtitle1"},
                new ItemViewModel {Title = "title2", Subtitle = "subtitle2"},
                new ItemViewModel {Title = "title3", Subtitle = "subtitle3"},
                new ItemViewModel {Title = "title4", Subtitle = "subtitle4"},
                new ItemViewModel {Title = "title5", Subtitle = "subtitle5"},
                new ItemViewModel {Title = "title6", Subtitle = "subtitle6"},
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
