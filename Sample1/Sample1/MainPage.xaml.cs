using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace Sample1
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ShutdownButton_Click(object sender, RoutedEventArgs e)
        {
            var ShutdownKind =Windows.System.ShutdownKind.Shutdown;
            ShutdownManager.BeginShutdown(ShutdownKind,TimeSpan.Zero);
        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            var ShutdownKind = Windows.System.ShutdownKind.Restart;
            ShutdownManager.BeginShutdown(ShutdownKind, TimeSpan.FromMinutes(3));
        }
    }
}
