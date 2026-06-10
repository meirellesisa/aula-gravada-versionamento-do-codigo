Console.WriteLine("Primeiro Projeto!");

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

