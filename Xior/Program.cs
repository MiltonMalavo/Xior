//dafsfkndsklmfkdjsfnkadjsfnkdjs
/*
   Variaveis - são espaços na memória que servem para poder armanzenar alguma coisa e consequentemente essa coisa
   deve estar ligado a um tipo de dados
    
    Numerico - usando para armanzenar numero
        /reais
        *inteiros
       
    int - 1,2,-1,0,-5 -
    string "gggg" "Milton" "5", "?" "-5",
    bool - true, false
    double - 5.9, 0.6, -0.5, 1.9, -1.6
    char - '','9' 'A' 'a' 'f' '<' 'd'
    float -  5.9, 0.6, -0.5, 1.9, -1.6
    decimal 
    

    Byte - é conjunto de 8bits
    1Byte-8bits
    00000000
    "Csharp"

    int - 4Byte 2^n onde:
    n == número de bits
    2^32
    char - 1Byte == 8bits
    2^8 == 256 0-255
    -128 0 127
    5 = 0 4
    -2 -1 0 1 2
    

    Regras para declaração (Nomes) de variavies:
    1 Regra - Deve começar com uma letra
    2 Regra - Não devo conter espaços em branco
    3 Regra - Não deve caracteres especias excepto o (UnderLine _) ex: ?,!,ç
    4 Regra - Não deve ser uma palavra reservada (termos que a linguagem usa)
    5 Regra - Case Sensitive (Letras maiusculas são difrentes de minuscula) Ex: a é diferente de A
    Console, break, class, int, if, else, do-while, while, for, foreach, internal,
    6 Regra - As palavras não devem ser acentuadas
    static, void, args

    Milton, Milton Malavo, idade, break, 1nome, coração, hoje!4, Milton_Malavo, _, _nome, _nome


    Declarção - Falar que existem ou criar
    sintaxe para declarar sem atribuição de valor incialmente:
    Tipo_De_Dados Nome_da_Variavel

    sintaxe  para declarar com atribuição de valor incialmente:
    Tipo_De_Dados Nome_da_Variavel = x
*/





int idade; // sem atribuição
int idade1 = 100;

//string nome = "Milton";

//Boa Praticas
//CamelCase - Camelo - nomeEstudanteIade
//PascalCase - NomeEstudandeIade
//snake_case - nome_estudante_idade

bool EstadoPorta=false;
bool EstadoPorta1;

int dia = 3;
decimal preco = 5.6m;
float preco1 = 5.8f;

int Golos = 5;
float kilo = 1.5f;
decimal precoProduto = 13m;

int QuantidadeDeAlunos = 45;
int Dia = 3;
int mes = 2;
int ano = 2026;

//Volume, medições - float
//calculo - double
//Preco - decimal
//NomeDeAlgumaCoisa - string
//DadosQueTêmUmBit - char ex: operadores (*,+,/), simbolos (!, #, @)
//Valor inteiro - inteiro

//Comandos de Entrada e Saida de Dados
//Csharp
//Console.WriteLine(instrução); - Saida
//Console.ReadLine() - Entrada- Leitura
//Console.Read()
//Console.WriteLine-  Escreve a instrução e muda de linha
//Console.Write-  Escreve a instrução e não muda de linha

string Texto = "Olá";
Texto = "Bom Dia";


//Console.Write(Texto);

//Concatenação de dados
//3 de formas de fazer isso

string Mensagem = "Olá,";
string nome = "Dorivaldo";
float altura = 2;

//Olá, Dorivaldo


//Console.WriteLine("Olá, Dorivaldo");

//Console.WriteLine(Mensagem+nome);

//Temlate String
Console.WriteLine($"{Mensagem} {nome}");

//Indice das variaveis 0 - mais infinito
Console.WriteLine("{0} {1}, Como estás? tu tens {2} metros", Mensagem, nome, altura);


//Tipo de dado dinamicos
//var, object, dynamic

//var nomedavariavel = "";
//object da = 12;

//dynamic ccc = "";




