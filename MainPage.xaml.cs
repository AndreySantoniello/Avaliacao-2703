namespace avaliacao2703
{
    public partial class MainPage : ContentPage
    {
        public int index;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BNTRolar_Clicked(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (index !=  -1 && pickerDado.SelectedItem != null)
            {
                int min = 1;
                int max = (int)pickerDado.SelectedItem;

                int v = rand.Next(min, max + 1);
                dadoValue.Text = v.ToString();
            }else
            {
                DisplayAlert("Atenção", "Você precisa selecionar um dado primeiro.", "OK");
            }
        }
    }

}
