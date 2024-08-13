using System.Collections.ObjectModel;
using RestSharp;
using System.ComponentModel;
using System.Net;
using System.Text.Json;
using System.Threading;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;
using System.Runtime.CompilerServices;

namespace PageNotClosingDemo
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public void DoSomethingButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Page3()));
        }

        public void ShowAnErrorButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new ErrorPage("An error.")));
        }
    }
}
