static double somar(double n1, double n2) => n1 + n2;
static double subtrair(double n1, double n2) => n1 - n2;
static double dividir(double n1, double n2) => n1 / n2;
static double multiplicar(double n1, double n2) => n1 * n2;
static double potencia(double n1, int n2) => Math.Pow(n1, n2);
static double maior(double n1, double n2) => Math.Max(n1, n2);
static double menor(double n1, double n2) => Math.Min(n1, n2);
static double raiz(double n1, int n2) => Math.Pow(n1, 1.0 / n2);

double n1 = 0, n2 = 0;
int ex = 0, op, indice;
string? msg1 = "Informe o indice da operação que você quer executar:\n1-Adição\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potenciação\n6-Maior e menor entre dois numeros\n7-Radiciação\nOpção: ";

try
{
    do
    {
        Console.Clear();
        Console.Write(msg1);
        op = int.Parse(Console.ReadLine());

        while (op < 1 || op > 7)
        {
            Console.Clear();
            Console.Write($"O indice informado ({op}) não é valido\n{msg1}");
            op = int.Parse(Console.ReadLine());
        }

        if (op != 5 && op != 7)
        {
            Console.Clear();
            Console.Write("Informe o numero 1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o numero 2: ");
            n2 = double.Parse(Console.ReadLine());
        }
        else
        {
            if (op == 5)
            {
                Console.Clear();
                Console.Write("Informe a base da potencia: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Informe o expoente: ");
                ex = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Clear();
                Console.Write("Informe o radicando da raiz: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Informe o indice: ");
                ex = int.Parse(Console.ReadLine());
            }
        }

        Console.Clear();
        Console.WriteLine("Resultado:");
        switch (op)
        {

            case 1:
                Console.WriteLine($"{n1} + {n2} = {somar(n1, n2)}");
                break;

            case 2:
                Console.WriteLine($"{n1} - {n2} = {subtrair(n1, n2)}");
                break;

            case 3:
                while (n2 == 0)
                {
                    Console.Write("Divisão por zero não é permitida\nInforme novamente: ");
                    n2 = double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{n1} / {n2} = {dividir(n1, n2)}");
                break;

            case 4:
                Console.WriteLine($"{n1} x {n2} = {multiplicar(n1, n2)}");
                break;

            case 5:
                Console.WriteLine($"{n1} elevado a {ex} = {potencia(n1, ex)}");
                break;

            case 6:
                Console.WriteLine($"Maior: {maior(n1, n2)}\nMenor: {menor(n1, n2)}");
                break;

            case 7:
                Console.WriteLine($"Raiz {ex}º de {n1} = {raiz(n1, ex)}");
                break;

        }
        
        Console.Write($"\nPara fazer uma nova conta digite 1, para finalizar digite 2:\n1-Nova conta\n2-Finalizar\nOpção: ");
        indice = int.Parse(Console.ReadLine());

        while (indice < 1 || indice > 2)
        {
            Console.Clear();
            Console.Write($"O numero {indice} não corresponde a 1 ou a 2, informe novamente: ");
            indice = int.Parse(Console.ReadLine());
        }

    } while (indice == 1);
}
catch (Exception exo)
{
    Console.Clear();
    Console.WriteLine($"Informação recebida invalida.\nErro: {exo.Message}");
}