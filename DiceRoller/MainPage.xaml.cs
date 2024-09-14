
using Microsoft.Extensions.Options;
using System.Diagnostics;
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

        double qtdDados = Convert.ToDouble(DiceEntry.Text);
        double dadoModificador = Convert.ToDouble(ModifierPicker.SelectedItem);
        
        int soma = 0;
        string resultados = "";
        int numeroSelecionado = 0;
        int numeroSorteado = 0;

        for (int i = 0; i < qtdDados; i++)
        {
            numeroSelecionado = Convert.ToInt32(SidesPicker.SelectedItem);
            numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
            soma = soma + numeroSorteado;
            
            
        }

        ResultLabel.Text = "Você tirou " + soma.ToString();
   


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

