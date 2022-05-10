
/*Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte: Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia. Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia. Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que 150, avisá-lo que será necessário adicionar 2 unidades de insulina.*/

int medicao1;
int medicao2;
int medicao3;
int mediaMedicao;


Console.Clear();


Console.Write("\nDigite a 1ª medição: ");
medicao1 = int.Parse(Console.ReadLine());
    if (medicao1 < 65)
    {
        Console.Write("\nSua média é menor que 65: Risco de Hipoglicemia! Procure ajuda médica.\n");
    }
    if (medicao1 > 250)
    {
        Console.Write("\nSua média é maior que 250: Risco de Hiperglicemia! Procure ajuda médica.\n");
    }

Console.Write("\nDigite a 2ª medição: ");
medicao2 = int.Parse(Console.ReadLine());
    if (medicao2 < 65)
    {
        Console.Write("\nSua média é menor que 65: Risco de Hipoglicemia! Procure ajuda médica.\n");
    }
    if (medicao2 > 250)
    {
        Console.Write("\nSua média é maior que 250: Risco de Hiperglicemia! Procure ajuda médica.\n");
    }

Console.Write("\nDigite a 3ª medição: ");
medicao3 = int.Parse(Console.ReadLine());
    if (medicao2 < 65)
    {
        Console.Write("\nSua média é menor que 65: Risco de Hipoglicemia! Procure ajuda médica.\n");
    }
    if (medicao2 > 250)
    {
        Console.Write("\nSua média é maior que 250: Risco de Hiperglicemia! Procure ajuda médica.\n");
    }



mediaMedicao = ((medicao1 + medicao2 + medicao3) / 3);
Console.Write("\nA média das medicões informadas é de: " + mediaMedicao + "\n");

    if (mediaMedicao >= 65 && mediaMedicao < 80)
    {
        Console.Write("\nSua média foi maior ou igual a 65 e menor que 80 por isso: diminua 02 unidades de insulina.\n");
    }
        else if (mediaMedicao >= 150 && mediaMedicao <= 250)
        {
            Console.Write("\nSua média foi maior que 150 por isso: adicione 02 unidades de insulina.\n");
        }
    else
    {
        Console.Write("\nSua média está normal.\n");
    }
