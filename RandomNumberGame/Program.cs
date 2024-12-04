Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1,101);
int tentativasRestantes = 5;
string mensagemDeBoasVindas = "Boas vindas ao Enigma Numérico! Vamos jogar?";
string descricao = "\nLembrando que você tem 5 tentativas para acertar o Número Secreto!";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"


███████╗███╗░░██╗██╗░██████╗░███╗░░░███╗░█████╗░
██╔════╝████╗░██║██║██╔════╝░████╗░████║██╔══██╗
█████╗░░██╔██╗██║██║██║░░██╗░██╔████╔██║███████║
██╔══╝░░██║╚████║██║██║░░╚██╗██║╚██╔╝██║██╔══██║
███████╗██║░╚███║██║╚██████╔╝██║░╚═╝░██║██║░░██║
╚══════╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║██║░░╚═╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║██║░░██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║██║╚█████╔╝╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░╚════╝░░╚════╝░");

Console.WriteLine(mensagemDeBoasVindas);
Console.WriteLine(descricao);
};

ExibirMensagemDeBoasVindas();

do
{
    Console.Write("\nDigite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;

    } else if(chute < numeroSecreto)
    {
        Console.Write("O número é ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("maior.");
        Console.ResetColor();

    } else
    {
        Console.Write("O número é ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("menor.");
        Console.ResetColor();
    }

    tentativasRestantes--;

    if (tentativasRestantes == 0)
    {
        Console.WriteLine("Você atingiu o limite de tentativas. O jogo acabou.");
        break;
    } else
    {
        Console.WriteLine("Por favor, digite um novo número.");
    }

} while (true);

Console.WriteLine("\nO jogo acabou. O número secreto era: " + numeroSecreto);