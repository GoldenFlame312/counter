using System.Diagnostics.Metrics;

namespace Licznik
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is AppShell shell)
            {
                shell.AddNewShellContent(entry.Text);
            }
        }
      
    }


}
