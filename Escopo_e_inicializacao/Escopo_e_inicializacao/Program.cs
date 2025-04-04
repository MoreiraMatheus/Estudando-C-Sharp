int x; //Declaração
x = 10; //Inicialização
Console.WriteLine(x); //Uma variável não pode ser usada se ela não for Inicializada!

double preco = 101.0;
double desconto = 0.0;
if (preco > 100.0) {
    desconto = preco * 0.1;
}
Console.WriteLine(desconto);
//quando a variável é declarada dentro de uma estrutura essa variável "Deixa de existir" quando essa estrutura finaliza sua função.
//É possível utilizar variáveis de um escopo maior dentro de um escopo menor (usar uma variável de fora de uma função dentro dela por exemplo).
//Mas não é possivel utilizar uma variável de um escopo menor em um escopo maior.