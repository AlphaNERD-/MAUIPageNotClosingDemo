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
    public partial class ErrorPage : ContentPage, INotifyPropertyChanged
    {
        public bool Retry = false;

        private Timer _outOfOrderTimer = null;

        private bool _outOfOrderMode = false;
        public bool OutOfOrderMode
        {
            get
            {
                return _outOfOrderMode;
            }
            set
            {
                _outOfOrderMode = value;
                OnPropertyChanged();
            }
        }

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        private double _errorIconHeight = 0;
        public double ErrorIconHeight
        {
            get
            {
                return _errorIconHeight;
            }
            set
            {
                _errorIconHeight = value;
                OnPropertyChanged();
            }
        }

        private string _imagePath;
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public ErrorPage(string message) : base()
        {
            InitializeComponent();

            BindingContext = this;

            Message = message;
        }
    }
}
