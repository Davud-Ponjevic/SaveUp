// ViewModels/ItemViewModel.cs
using System.Collections.ObjectModel;
using System.Windows.Input;
using SaveUp.Models;

namespace SaveUp.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        public ObservableCollection<SavedItem> Items { get; set; } = new ObservableCollection<SavedItem>();

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public ICommand AddItemCommand { get; }

        public ItemViewModel()
        {
            AddItemCommand = new Command(OnAddItem);
        }

        private void OnAddItem()
        {
            Items.Add(new SavedItem { Description = Description, Price = Price });
            Description = string.Empty;
            Price = 0;
        }
    }
}
