using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace Licznik
{
    public partial class Counter : ContentPage
    {
        int count = 0;

        public Counter()
        {
            InitializeComponent();
            LoadCounterState(); // stan licznika przy uruchomieniu
        }

        public Counter(string name)
        {
            InitializeComponent();
            LoadCounterState(); //stan licznika przy uruchomieniu
        }

       
        private void ClickedBtn(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = count.ToString();
            SaveCounterState(); // Zapisanie licznika po zmianie
        }

        
        private void ClickedBtnMin(object sender, EventArgs e)
        {
            count--;
            CounterLabel.Text = count.ToString();
            SaveCounterState(); // Zapisanie  licznika po zmianie
        }

        // zapisywanie stanu licznika
        private void SaveCounterState()
        {
            Preferences.Set("SavedCounterValue", count);
        }

        // wczytywanie stanu licznika
        private void LoadCounterState()
        {
            // Odczytanie zapisanej wartoœci z Preferences albo jak brak to 0
            count = Preferences.Get("SavedCounterValue", 0);

            CounterLabel.Text = count.ToString();
        }
    }
}
