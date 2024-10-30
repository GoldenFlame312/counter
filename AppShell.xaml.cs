﻿namespace Licznik
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        public void AddNewShellContent(string counterName)
        {
            var contentTemplate = new DataTemplate(() =>
            {
                var counterPage = new Counter(counterName);
                return counterPage;
            });

            var newShellContent = new ShellContent
            {
                ContentTemplate = contentTemplate,
                Title = counterName,
                Route = "MainPage"
            };


            if (Items[0] is TabBar tabBar)
            {
                tabBar.Items.Add(newShellContent);
            }
        }
    }
}
