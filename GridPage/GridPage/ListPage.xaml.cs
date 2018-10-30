using System.Collections.ObjectModel;
using GridPage.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            Players = new ObservableCollection<Player>
            {
                new Player {Name = "Falzu", ArmorClass = 15, HitPoints = 30, Initiative = 7, Perception = 11},
                new Player {Name = "Trelledar", ArmorClass = 18, HitPoints = 35, Initiative = 14, Perception = 13}
            };

            MyListView.ItemsSource = Players;
        }

        public ObservableCollection<Player> Players { get; set; }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;

            var player = e.Item as Player;        
            //await DisplayAlert("Item Tapped", "You tapped " + player?.Name, "OK");

            await Navigation.PushAsync(new MainPage(player));

            //Deselect Item
            ((ListView) sender).SelectedItem = null;
        }
    }
}