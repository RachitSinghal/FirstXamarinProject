using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listItem.ItemsSource = new List<Team>
                {
                    new Team
                    {
                        Name="Aman",
                        Prog="Xamarin",
                        Age=20
                    },
                    new Team
                    {
                        Name="Avisha",
                        Prog="Xamarin",
                        Age=20
                    },
                    new Team
                    {
                        Name="Rachit",
                        Prog="Xmarin + Cloud",
                        Age=20
                    },
                    new Team
                    {
                        Name="Devesh",
                        Prog="Xamarin",
                        Age=22
                    },
                    new Team
                    {
                        Name="Manu",
                        Prog="Java Script",
                        Age=23
                    }
                };
        }
    }
}