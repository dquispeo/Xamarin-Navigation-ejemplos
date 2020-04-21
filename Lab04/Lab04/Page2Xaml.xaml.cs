using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2Xaml : ContentPage
    {
        public Page2Xaml()
        {
            InitializeComponent();
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}