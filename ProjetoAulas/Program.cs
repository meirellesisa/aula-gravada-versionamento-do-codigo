/*Console.WriteLine("Primeiro Projeto!");

string nomePessoa = "Isabella Meirelles";

nomePessoa = "Isabella Meirelles de Freitas";

Console.WriteLine("Nome = " + nomePessoa);

int idade = 25;

Console.WriteLine("Idade = " + idade);


decimal preco = 19.90m;
Console.WriteLine("Preço = " + preco);

float alturaPessoa = 1.75f;
Console.WriteLine($"A altura é igual a : {alturaPessoa}");

double peso = 70;
Console.WriteLine($"O peso da pessoa é: {peso} Kg");

// Inferência de tipo

var idadeNova = 30;
Console.WriteLine("Nova Idade = " + idade);

char letra = 'A';

Console.WriteLine(letra);

bool ativo = true;
//ativo = false;-

Console.WriteLine(ativo);

const string nomeCurso = "C# para Iniciantes";
Console.WriteLine(nomeCurso);


//nomeCurso = "C# para Iniciantes - Atualizado"; 

/*
 * Linha 1
 * Linha 2
 * Linha 3
*/

/*
// soma de dois números
int resultado = 2 + 2;
int rultadoDaSoma = 2 + 2;

// regra de negocio: idade minima de cadastro é 18 anos


//int numero2 = 2;
var numero1 = 1;

var numero2 = 2;

//int soma = numero1 + numero2;
var soma = numero1 + numero2;
Console.WriteLine("Soma = " + soma);

var subtracao = numero2 - numero1;
Console.WriteLine($"Subtração = {subtracao}");

var multiplicacao = numero1 * numero2;
Console.WriteLine($"Multiplicação = {multiplicacao}");

var divisao = numero2 / numero1;
Console.WriteLine($"Divisão = {divisao}");

var multiplicacao2 = (numero1 * numero2) * 10;
Console.WriteLine($"Mais de uma opercação matemática = {multiplicacao2}");


//var numero1 = 1;
//var numero2 = 2;
// Relacional de igualdade
bool igual = numero1 == numero2;
Console.WriteLine(igual);
//var idade = 33;

// Relacional maior que 
bool maior = numero2 > numero1;
Console.WriteLine(maior);

// Relacional menor que
bool menor = numero2 < numero1;
Console.WriteLine(menor);

// Relacional maior ou igual 
bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

// Relacional menor ou igual
bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual2 = 1 >= 1;
Console.WriteLine(maiorOuIgual2);

// Relacional diferente
bool diferente = numero2 != numero1;
Console.WriteLine(diferente);



//var numero1 = 1;
//var numero2 = 2;

//Operador lógico AND -> && -> E
// Ambas as expressões precisam ser verdadeiras para o resultado ser verdadeiro

var valido = numero2 > numero1 && 8 > 7;
Console.WriteLine(valido);

var valido2 = numero2 > numero1 && 6 > 7;
Console.WriteLine(valido2);

//Operador lógico OR-> || -> OU
// Basta com que uma das expressões seja verdadeira para o resultado ser verdadeiro

var valido3 = numero2 > numero1 || 6 > 7;
Console.WriteLine(valido3);

var valido4 = numero2 > 10 || 6 > 7;
Console.WriteLine(valido4);

var valido5 = numero2 > numero1|| 8 > 7;
Console.WriteLine(valido5);

//Operador lógico Not -> ! -> Negação
var valido6 = !(numero2 > 10);
Console.WriteLine(valido6);

var valido7 = !(numero2 > numero1);
Console.WriteLine(valido7);


//bool ativo = true;
ativo = false;

string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
Console.WriteLine(status);

var nome = NomeCompleto();
//Console.WriteLine(nome);

//Console.WriteLine(primeiroNome);


string NomeCompleto()
{
    var primeiroNome = "Isabella";
    var segundoNome = "Meirelles";

    return primeiroNome + " " + segundoNome;
}


int SomaValores(int a, int b)
{
    return a + b;
}

//var resultado = EscreverNome();

//EscreverNome();

void EscreverNome()
{
    Console.WriteLine("Procedimento é uma função que retorna o tipo void (nenhum valor)");
    var nome = NomeCompleto();
    var soma = SomaValores(3,6);

    Console.WriteLine(nome);
    Console.WriteLine(soma);
}


var soma1 = SomaValores(a: 100, b: 1530);
Console.WriteLine(soma1);


var soma2 = SomaValores(a: 10, b: 37);
Console.WriteLine(soma2);


var soma3 = SomaValores(23, 58);
Console.WriteLine(soma3);

string NomeEIdade(string nome, int idade)
{
    return $"Meu nome é {nome} e tenho a seguinte idade: {idade}";
}


////var nomeEIdade = NomeEIdade("Meu nome é Isabella e tenho a seguinte idade: ", 25);
////Console.WriteLine(nomeEIdade);
///
var nomeEIdade2 = NomeEIdade("Isabella", 25);
Console.WriteLine(nomeEIdade2);

var nomeEIdade3 = NomeEIdade("João", 12);
Console.WriteLine(nomeEIdade3);

var nomeEIdade4 = NomeEIdade("Maria", 60);
Console.WriteLine(nomeEIdade4);


// git init 
// git add . -> criar o arquivo .gitignore
// git commit -m "Primeiro commit"
// git remote add origin URL
// git push -u origin main ou master (depende de como foi criado)







// Estrutura de Dados 

// ArrayList ==============================
using System.Collections;

var arrayList = new ArrayList();

// Adicionando dados 
arrayList.Add(1);          // indice 0
arrayList.Add("Isabella"); // indice 1
arrayList.Add(true);       // indice 2

// Removendo item da nossa coleção ArrayList

arrayList.RemoveAt(1);

//arrayList = new ArrayList();
arrayList.Clear();

// Forma de ler os dados 
//Console.WriteLine(arrayList[1]);

foreach(var item in arrayList)
{
    Console.WriteLine(item);
}



// ArrayTipado ==============================

//var arrayTipadoNumero = new int[3] { 1, 2, 3 };
var arrayTipadoNumero = new int[3];

arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

Array.Resize(ref arrayTipadoNumero, 11);
arrayTipadoNumero[10] = 100;

foreach(var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

var arrayTipadoString = new string[2] { "Isabella", "Meirelles" };

foreach (var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
//===========================================================


// Lista Genérica ==============================

var lista = new List<string>(10);

lista.Add("Isabella");  // indice 0
lista.Add("Meirelles"); // indice 1

var nome = lista[0];
// Console.WriteLine(nome);

foreach(var item in lista)
{
    Console.WriteLine(item);
}



var lista2 = new List<string>(10) { "Isabella", "Meirelles", "Curso" };
var nome2 = lista2[1];

lista2.RemoveAt(2);

//Console.WriteLine(nome2);
foreach (var item in lista2)
{
    Console.WriteLine(item);
}



// Dictionary ou Dicionário ==============================

var dicionario = new Dictionary<int, string>();

dicionario.Add(1,"Isabella");
dicionario.Add(100,"Lucas");

dicionario[50] = "Curso";

var nome = dicionario[1];
var nome2 = dicionario[100];
var nome3 = dicionario[50];
Console.WriteLine(nome3);

var dicionario2 = new Dictionary<int, string>()
{
    {1, "Isabella" },
    {100, "Lucas" },
    {50, "Curso" }
};

foreach (var item in dicionario2)
{
    Console.WriteLine(item.Key);
}

Console.WriteLine();

foreach (var item in dicionario2)
{
    Console.WriteLine(item.Value);
}

Console.WriteLine();

foreach (var item in dicionario2)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}




// Queue - Fila - FIFO ==============================

var fila = new Queue<string>();

fila.Enqueue("Isabella"); // primeiro pessoa da fila 
fila.Enqueue("Meirelles"); //segunda pessoa da fila 
                           // fim da fila

//foreach(var item in fila)
//{
//    Console.WriteLine(item);
//}

//var nome = fila.Peek();
//var nome2 = fila.Peek();
//Console.WriteLine(nome);
//Console.WriteLine(nome2);

var nome = fila.Dequeue();
Console.WriteLine(nome);

var nome2 = fila.Dequeue();
Console.WriteLine(nome2);



//Stack - utiliza o coneceito de LIFO ==============================

var stack = new Stack<string>();

stack.Push("Isabella");
stack.Push("Meirelles");

foreach(var item in stack)
{
    Console.WriteLine(item);
}
var nome3 = stack.Peek();
Console.WriteLine(nome3);
var nome = stack.Pop();
var nome2 = stack.Pop();
//Console.WriteLine(nome);
//Console.WriteLine(nome2);


// Semana 7 -> Aula 1
// string -> int 
// string -> bool
// string -> double 

//int numero = int.Parse("a");
//int numero = Convert.ToInt32("a");
//int numero = Convert.ToInt32(null);
//int numero = int.Parse(null);
int numero = int.Parse("1");
Console.WriteLine(numero);


//bool verdadeiro = bool.Parse("true");
bool verdadeiro = bool.Parse("verdadeiro");
Console.WriteLine(verdadeiro);



// Semana 7 -> Aula 2
//var numero = "12345";
var numero = "abc";

//var tryParse = int.TryParse(numero, out int numeroConvertido) 
//             ? $"Número convertido com sucesso - {numeroConvertido}"
//             : $"Não foi possível converter - {numero}";

//var tryParse = int.TryParse(numero, out int numeroConvertido)
//             ? $"Número convertido com sucesso - {numeroConvertido}"
//             : $"Não foi possível converter - {numero} - {numeroConvertido}";

//Console.WriteLine(tryParse);

int numeroConvertido;
var tryParse = int.TryParse(numero, out numeroConvertido)
             ? $"Número convertido com sucesso - {numeroConvertido}"
             : $"Não foi possível converter - {numero} - {numeroConvertido}";
var soma = numeroConvertido + 100;
Console.WriteLine(tryParse);
Console.WriteLine(soma);

// Parse VS TryParse
// Parse -> Lança uma exceção caso a conversão falhe
// TryParse -> Retorna um booleano indicando se a conversão
// foi bem-sucedida ou não, sem lançar uma exceção.
// O valor convertido é retornado por meio de um parâmetro de saída (out).

bool.TryParse();
long.TryParse();
char.TryParse();
double.TryParse();


// Semana 7 -> Aula 3

//var diaDaSemana = 1;
//var diaDeTrabalho = true;

//if (diaDaSemana == 0 && diaDeTrabalho)
//{
//    Console.WriteLine("Hoje é domingo");
//}
//else if (diaDaSemana == 0 && diaDeTrabalho == false)
//{
//    Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
//}
//else
//{
//    Console.WriteLine("Hoje não é domingo");
//}

var diaDaSemana = 10;

if (diaDaSemana == 0)
{
    Console.WriteLine("Hoje é domingo");
}
else if (diaDaSemana == 1)
{
    Console.WriteLine("Hoje é segunda");
}
else if (diaDaSemana == 2)
{
    Console.WriteLine("Hoje é terça");
}
else if (diaDaSemana == 3)
{
    Console.WriteLine("Hoje é quarta");
}
else if (diaDaSemana == 4)
{
    Console.WriteLine("Hoje é quinta");
}
else if (diaDaSemana == 5)
{
    Console.WriteLine("Hoje é sexta");
}
else if (diaDaSemana == 6)
{
    Console.WriteLine("Hoje é sabado");
}
else
{
    Console.WriteLine("Valor inválido para o dia da semana");
}




// Semana 7 -> Aula 4

var diaDaSemana = 0;

if (diaDaSemana < 1)
{

    Console.WriteLine("Hoje é domingo");
}
else
{
    Console.WriteLine("Dia da semana invalido");
}

//switch (diaDaSemana)
//{
//    case 0:
//        Console.WriteLine("Hoje é domingo");
//        break;
//    case 1:
//        Console.WriteLine("Hoje é segunda");
//        break;
//    case 2:
//        Console.WriteLine("Hoje é terça");
//        break;
//    case 3:
//        Console.WriteLine("Hoje é quarta");
//        break;
//    case 4:
//        Console.WriteLine("Hoje é quinta");
//        break;
//    case 5:
//        Console.WriteLine("Hoje é sexta");
//        break;
//    case 6:
//        Console.WriteLine("Hoje é sabado");
//        break;
//    default:
//        Console.WriteLine("Valor inválido para o dia da semana");
//        break;
//}

// Semana 7 -> Aula 5

var lista = new List<string>()
{
    "Isabella",   // indice 0
    "Meirelles", // indice 1
    "Curso"     // indice 2
};

var count = lista.Count;

//inicialização ; condição ; incremento

for(var i = 0; i < count; i++)
{
    var nome = lista[i];
    Console.WriteLine(nome);
};

foreach(var item in lista)
{
    Console.WriteLine(item);
}


// o incremento pode ser feito da seguinte forma:
// i++ -> i = i + 1
//  i -> i + 1
//  i += 1


// Semana 7 -> Aula 6

var lista = new List<string>()
{
    "Isabella",   // indice/posicao 0
    "Curso", // indice/posicao 1
    "Csharp"     // indice/posicao 2
};


foreach(string item in lista)
{
    Console.WriteLine(item);
}

foreach(var item in "Isabella Meirelles")
{
    Console.WriteLine(item);
}


// Semana 7 -> Aula 7
var i = 3;

while(i< 2)
{
    Console.WriteLine("var i = " + i);
    i++;
    //i = i + 1;
    //i += 1;
}


var j = 3;

do
{
    Console.WriteLine("var j = " +j);
    j++;
}
while (j < 2);

var opcaoValida = false;
do
{
    Console.WriteLine("Menu do sistema");
}
while (opcaoValida);


*/


// Semana 7 -> Aula 8

var i = 0;

//while (i < 5)
//{
//    Console.WriteLine("var i = " + i);
//    i++;

//    if(i == 2)
//    {
//        Console.WriteLine("Valor de i é igual a 2");
//        break;
//    }
//}

while (i < 5)
{

    if (i < 2)
    {
        Console.WriteLine("Continuando ...");

        i++;
        continue;
    }

    Console.WriteLine("var i = " + i);
    i++;
}