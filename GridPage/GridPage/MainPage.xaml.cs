using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridPage.Models;
using Xamarin.Forms;

namespace GridPage
{
    public partial class MainPage : ContentPage
    {
        public PlayerMVVM mvvm { get; }

        public MainPage(Player p)
        {
            mvvm = new PlayerMVVM
            {
                PlayerName = p.Name,
                AC = p.ArmorClass,
                HP = p.HitPoints,
                Percep = p.Perception,
                Init = p.Initiative
            };

            InitializeComponent();
            BindingContext = mvvm;
        }
    }
}
