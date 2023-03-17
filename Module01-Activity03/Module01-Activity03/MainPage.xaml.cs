using Module01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module01_Activity03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MyViewResources(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyViewResources());
        }

        private async void MyDictionary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDictionary());
        }

        private async void MyPageResources(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyPageResources());
        }

        private async void MyResourceDictionary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyResourceDictionary());
        }

    }
}
