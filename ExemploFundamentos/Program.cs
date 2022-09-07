using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Angelo";
pessoa1.Idade = 34;
pessoa1.Apresentar();

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int numeroIncremento = 10;
numeroIncremento++;
Console.WriteLine($"Incrementando o 10: {numeroIncremento}");

int numeroDecremento = 11;
numeroDecremento--;
Console.WriteLine($"Decrementando o 11: {numeroDecremento}");

// tabuada com laço for
int numeroTabuada = 5;
for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numeroTabuada} x {contador} = {numeroTabuada * contador}");
}

// tabuada com laço while
int numeroTab = 5;
int contador1 = 0;

while(contador1 <= 10)
{
    Console.WriteLine($"{contador1}* Execução: {numeroTab} x {contador1} = {numeroTab * contador1}");
    contador1++;
}

// Array com FOR - (utilizar quando precisa de contador)

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
/*Sendo Array é uma classe, Resize é redimensionar, Ref passando por referencia  o arrayInteiros e 
em seguida vou pegar a sua capacidade Length que é quatro, e multiplicar por 2. */

Console.WriteLine("Percorrendo o Array com FOR");

for(int contar = 0; contar < arrayInteiros.Length; contar++)
{
    Console.WriteLine($"Posição N° {contar} - {arrayInteiros[contar]}");
}

//Copiando um Array para outro Array

int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array com ForEach (utilizar quando não precisa de contador)

Console.WriteLine("Percorrendo o Array com FOREACH");
int contadorForeach = 0;

foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++;
}

//Array de lista, trabalha internamente com array, uma extensão do array - utilizada para inserção, deleção..

Console.WriteLine("Percorrendo a LIST com FOR");

List<string> listaString = new List<string>(); //nao precisa informar capacidade maxima para a lista

listaString.Add("SC");
listaString.Add("PR");
listaString.Add("PE");

for(int contador2 = 0; contador2 < listaString.Count; contador2++) //COUNT - é a mesma coisa que o Lenght. Retorna a quantidade de elementos
{
    Console.WriteLine($"Posição N° {contador2} - {listaString[contador2]}");
}

Console.WriteLine("Percorrendo a LIST com FOREACH");
int contadorforeach = 0;
foreach(string item in listaString) //Sempre utilizar o FOREACH LIST para precorrer a lista - gerencia automaticamente a capacidade maxima
{
    Console.WriteLine($"Posição N° {contadorforeach} - {item}");
    contadorforeach++;
}

// laço DO While
int somatorio = 0, numeros = 0;

do 
{
    Console.WriteLine("Digite um numero, ou 0 para parar e somar: ");
    numeros = Convert.ToInt32(Console.ReadLine());

    somatorio += numeros;

} while(numeros != 0);

Console.WriteLine($"total de soma dos numeros digitados é: {somatorio}");

// Menu interativo com While

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear(); // limpa o console
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
             // ou usar Environment.Exit(0); para encerrar o programa
            break;

        default:
            Console.WriteLine("Opção invalida!");
            break;
    }

}

 Console.WriteLine("O programa foi encerrado");

//int a = Convert.ToInt32(null) -> Quando null, retorna valor 0.
