using System.Collections.Generic;
using Xamarin.Forms;

namespace OpacityListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ExampleList.ItemsSource = new List<CellModel>
            {
                new CellModel {Name = "Torremolinos", Photo = "Malaga.jpg", Opacity = 0.4},
                new CellModel {Name = "Benalmadena", Photo = "Malaga01.jpg", Opacity = 0.6},
                new CellModel {Name = "Marbella", Photo = "Malaga02.png", Opacity = 0.8},
                new CellModel {Name = "Nerja", Photo = "Malaga03.jpg", Opacity = 1}
            };
        }
    }

    public class CellModel
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Opacity { get; set; }
    }
}