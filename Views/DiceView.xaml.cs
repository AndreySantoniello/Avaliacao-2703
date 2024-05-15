using System;
using avaliacao2703.Models;

namespace avaliacao2703.Views;

public partial class DiceView : ContentPage
{
    public int index;
    public DiceView()
	{
		InitializeComponent();
        pickerDado.SelectedIndex = 0;
	}
    private void BNTRolar_Clicked(object sender, EventArgs e)
    {
        Random rand = new Random();
        Dado dado = new Dado();

        if (index != -1 && pickerDado.SelectedItem != null)
        {
            int max = (int)pickerDado.SelectedItem;

            dadoValue.Text = dado.Rolar(max);
        }
    }
}