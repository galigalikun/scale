using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scale.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            fingerprint();
        }
        async void fingerprint()
        {
            var result = await Plugin.Fingerprint.CrossFingerprint.Current.AuthenticateAsync("Prove you have fingers!");
            if (result.Authenticated)
            {
                Console.WriteLine("Authenticated ok");
            }
            else
            {
                Console.WriteLine("Authenticated ng");
            }
        }
    }
}