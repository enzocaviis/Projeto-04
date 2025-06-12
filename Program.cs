int index, nrq, nex;
string? msg1 = "Informe o indice da opção que você quer executar:\n1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Raiz quadrada\n6-Potencia\n7-Maior entre dois numeros\n8-Menor entre dois numeros\nOpção: ";
double n1, n2, nb;

try
{
    do
    {
        Console.Clear();
        Console.Write(msg1);
        index = int.Parse(Console.ReadLine());

        while (index > 8)
        {
            Console.Clear();
            Console.Write($"Obs: não existem {index} opções.\n{msg1}");
            index = int.Parse(Console.ReadLine());
        }

        switch (index)
        {
            case 1:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"{n1} + {n2} = {n1 + n2}");
                break;

            case 2:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"{n1} - {n2} = {n1 - n2}");
                break;

            case 3:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"{n1} / {n2} = {n1 / n2}");
                break;

            case 4:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"{n1} x {n2} = {n1 * n2}");
                break;

            case 5:
                Console.Write("\nQual é a raiz quadrada que você quer obter: ");
                nrq = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.WriteLine($"Raiz quandrada de {nrq}: {Math.Sqrt(nrq)}");
                break;

            case 6:
                Console.Write("\nQual é a base da potencia: ");
                nb = double.Parse(Console.ReadLine());

                Console.Write("Qual é o expoente da potencia: ");
                nex = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.WriteLine($"{nb} elevado a {nex}: {Math.Pow(nb, nex)}");
                break;

            case 7:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"Maior: {Math.Max(n1, n2)}");
                break;

            case 8:
                Console.Write("\nInforme o numero 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero 2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Resultado:");
                Console.Write($"Menor: {Math.Min(n1, n2)}");
                break;

        }

        Console.Write($"\n\nPara fazer uma nova execução digite 1, para finalizar digite 2:\n1-Nova execução\n2-Finalizar\nOpção: ");
        index = int.Parse(Console.ReadLine());

        while (index < 1 || index > 2)
        {
            Console.Clear();
            Console.Write($"\nO numero {index} não corresponde a 1 ou a 2.\nPara fazer uma nova execução digite 1, para finalizar digite 2:\n1-Nova execução\n2-Finalizar\nOpção: ");
            index = int.Parse(Console.ReadLine());
        }

    } while (index == 1);

    Console.Clear();
    Console.WriteLine("\nTudo bem, até a proxima!");

}
catch (Exception ex)
{
    Console.WriteLine($"Informação invalida.\nErro: {ex.Message}");
}

