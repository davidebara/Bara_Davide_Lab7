namespace Bara_Davide_Lab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Meowed {count} time";
            else
                CounterBtn.Text = $"Meowed {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
