using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace lfrigodesouza.app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            webView.Source = @"https://www.lfrigodesouza.net/?utm_medium=app&utm_source=android";

            webView.Navigating += (s, e) =>
            {
                
                if (!e.Url.StartsWith("https://www.lfrigodesouza.net")) {
                    Launcher.OpenAsync(new Uri(e.Url));
                    e.Cancel=true;
                }
                else
                {
                    loadinLabel.IsVisible = true;
                }
            };

            webView.Navigated += (s, e) =>
            {
                loadinLabel.IsVisible = false;
            };

        }
    }
}
