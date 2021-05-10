using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;

namespace ToastSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnToast_Clicked(object sender, EventArgs e)
        {
            char ch = (char)0x2714;
            var messageOptions = new MessageOptions
            {
                Foreground = Color.White,
                Font = Font.SystemFontOfSize(16),
                Message = ch + "  Success message with tick"
            };
            var options = new ToastOptions
            {
                BackgroundColor = Color.Green,
                MessageOptions = messageOptions,
                Duration = TimeSpan.FromMilliseconds(3000)
            };

            await this.DisplayToastAsync(options);
            //kcawait this.DisplayToastAsync("ok", 500);
        }

        private async void BtnFail_Clicked(object sender, EventArgs e)
        {
            char ch = (char)0x26A0;
            var messageOptions = new MessageOptions
            {
                Foreground = Color.White,
                Font = Font.SystemFontOfSize(16),
                Padding = 100,
                Message = ch + "  Error Message "
            };
            var options = new ToastOptions
            {
                BackgroundColor = Color.FromHex("#f3a447"),
                MessageOptions = messageOptions,
                Duration = TimeSpan.FromMilliseconds(3000)
            };

            await this.DisplayToastAsync(options);
        }
    }
}
