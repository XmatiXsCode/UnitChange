namespace UnitChange
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var wartosc = Convert.ToDouble(stopnie.Text);
            var typ = rodzaj.SelectedIndex;
            var start = wartosc;
            if (typ == 0)
            {
                wartosc = wartosc * 9 / 5 + 32;
                wynik.Text = $"{start} ° Celcjusza to {wartosc} ° Faranhaita.";
            }
            if (typ == 1)
            {
                wartosc = (wartosc - 32) * 5 / 9;
                wynik.Text = $"{start} ° Faranhaita to {wartosc} ° Celcjusza.";
            }
        }
    }
}