// See https://aka.ms/new-console-template for more information

/*Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e número de horas rabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de oras exceder a 50 calcule o excesso de pagamento armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento, exibir o salário total e o salário excedente do operário.*/

int codigo;
float quantHorasTrabalhadas = 0F;
int cargaHorariaCLT = 50;
float valorHora = 10.00F;
float valorHorasExtras = 20.00F;
float salarioNormalsemExtra = 0F;
float valorExtrasRecebido = 0F;

Console.Clear();

Console.Write("\nDigite o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("\nDigite a quantidade de horas trabalhadas: ");
quantHorasTrabalhadas = int.Parse(Console.ReadLine());


if (quantHorasTrabalhadas > cargaHorariaCLT)
{
    valorExtrasRecebido = (quantHorasTrabalhadas - cargaHorariaCLT) * valorHorasExtras;
    salarioNormalsemExtra = (quantHorasTrabalhadas - (quantHorasTrabalhadas - cargaHorariaCLT)) * valorHora; // Tiro extras.
}
else
{
    salarioNormalsemExtra = quantHorasTrabalhadas * valorHora; // Calculo direto.
}


Console.Write("\nO valor do salário total com inclusão das horas extras, se o caso, é de: R$ " + (salarioNormalsemExtra + valorExtrasRecebido).ToString("f") + "\n");


Console.Write("\nO valor das horas extras recebidas é de: R$ " + (valorExtrasRecebido).ToString("f") + "\n");
