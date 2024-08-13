using System.Collections.ObjectModel;
using RestSharp;
using System.ComponentModel;
using System.Net;
using System.Text.Json;
using System.Threading;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace PageNotClosingDemo
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public void DoSomethingButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page2());
        }

        public void ShowAnErrorButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new ErrorPage("An error.")));
        }
    }
}
