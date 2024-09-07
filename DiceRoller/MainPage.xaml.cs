using System.Xml.Serialization;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    Random random = new Random();


    private void RollButton_Clicked(object sender, EventArgs e)
    {
        int numeroSelecionado = Convert.ToInt32(SidesPicker.SelectedItem);
        int numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
        ResultLabel.Text = numeroSorteado.ToString();
    }



    // Primeira etapa
    // Sortear um número aleatório através do clique do botão

    // Conseguir selecionar a quantidade de lados a partir do Picker
    // 1 equivale ao menor número que o dado é capaz de sortear
    // Numero selecionado é o valor de lados que o dado tem
    // Devolver o número sorteado para a interface
    // O maior numero sorteavel pelo dado é dado por Numero Sorteado + 1

    // Devolver o número sorteado para a interface

}

