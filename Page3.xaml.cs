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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Task loadSettingsAndInformation = new Task(() =>
            {
                try
                {
                    throw new Exception("An exception occurred.");
                }
                catch (Exception e)
                {
                    Navigation.PushAsync(new NavigationPage(new ErrorPage(e.Message)));
                }
            });

            loadSettingsAndInformation.Start();
        }
    }
}
