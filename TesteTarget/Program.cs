Console.WriteLine("\nJob Rotation - Ribeirão Preto\n");

//Atividade 1
Console.WriteLine("#Atividade 1");

int indice = 13;
int soma = 0;
int k = 0;

while (k < indice)
{
  k = k + 1;
  soma = soma + k;
}

Console.WriteLine($"Resposta: {soma}");

//Atividade 2
Console.WriteLine("\n#Atividade 2");

int n = 0;
int anterior = 0;
int atual = 1;
int proximo = 0;
bool fibonacci = false;

Console.Write("\nDigite um número inteiro para verificar se ele PERTENCE na sequncia Fibonacci: ");
n = int.Parse(Console.ReadLine());

if (n == 0 || n == 1)
{
  fibonacci = true;
}

while ((!fibonacci) && (n > proximo))
{
  proximo = anterior + atual;
  if (proximo == n)
  {
    fibonacci = true;
  }
  anterior = atual;
  atual = proximo;
}
if (fibonacci)
{
  Console.WriteLine($"O número {n} PERTENCE a sequência Fibonacci");
}
else
{
  Console.WriteLine($"O número {n} NÃO PERTENCE a sequência Fibonacci");
}

//Atividade 3
Console.WriteLine("\n#Atividade 3");

Console.WriteLine("Descubra a lógica e complete o próximo elemento:");

Console.WriteLine("a) 1, 3, 5, 7, ...");
Console.WriteLine($"Resposta: {7 + 2}");

Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ...");
Console.WriteLine($"Resposta: {64 * 2}");

Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ...");
Console.WriteLine($"Resposta: {36 + 13}");

Console.WriteLine("d) 4, 16, 36, 64, ...");
Console.WriteLine($"Resposta: {64 + 36}");

Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ...");
Console.WriteLine($"Resposta: {8 + 5}");

Console.WriteLine("f) 2, 10, 12, 16, 17, 18, 19, ...");
Console.WriteLine($"Resposta: 200");

//Atividade 4
Console.WriteLine("\n#Atividade 5");
Console.WriteLine("\nDois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?");
Console.WriteLine("Resposta: \nA distância será a mesma, considerando que no momento do cruzmento ambos estarão no mesmo ponto da estrada.");


//Atividade 5
Console.WriteLine("\n#Atividade 5");

Console.WriteLine("\nEscreva um programa que inverta os caracteres de um string.");
Console.Write("\nEntre com o valor da string: ");

string text = Console.ReadLine();

for (int i = text.Length; i > 0; i--)
{
  Console.Write(text[i - 1]);
}

Console.WriteLine("\n#DESDE JÁ AGRADEÇO A OPORTUNIDADE");
















