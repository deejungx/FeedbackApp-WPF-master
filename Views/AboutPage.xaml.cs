using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Navigation;

namespace RestaurantFeedbackApp.Views
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            ProcessStartInfo pinfo = new ProcessStartInfo(e.Uri.AbsoluteUri);
            pinfo.UseShellExecute = true;
            Process.Start(pinfo);
            e.Handled = true;
        }
    }
}
