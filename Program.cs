/*
//EXERCICIO 1
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double m = double.Parse(Console.ReadLine());
        Console.WriteLine($"O resultado da soma é: {n+m}");
        Console.WriteLine($"O resultado da subtração é: {n-m}");
        Console.WriteLine($"O resultado da multiplicação é: {n*m}");
        Console.WriteLine($"O resultado da divisão é: {n/m}");
   
    }
}
*/
/*
//EXERCICIO 2
using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o valor do produto: ");
        double valorProduto = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a porcentagem de desconto: ");
        double percentualDesconto = Convert.ToDouble(Console.ReadLine());
        double desconto = valorProduto * percentualDesconto / 100;
        double valorFinal = valorProduto - desconto;
        Console.WriteLine($"O valor do desconto é: R$ {desconto:F2}");
        Console.WriteLine($"O valor final com desconto é: R$ {valorFinal:F2}");
    }
}*/

/*
//EXERCICIO 3
using System;
class Program
{
    static void Main(string[] args)
    {
        int n= 1;


        for (int i = 1; i < 21; i ++)
        {
           if (n%2==0)
           {
            Console.WriteLine($"{i}");
           }
           n++;
        }
    }
}*/
/*
//EXERCICIO 4
using System;


class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int A = int.Parse(Console.ReadLine());


        Console.Write("Digite o segundo número: ");
        int B = int.Parse(Console.ReadLine());
        if (A > B)
        {
            int temp = A;
            A = B;
            B = temp;
        }


        int soma = 0;
        for (int i = A; i <= B; i++)
        {
            soma += i;
        }
        Console.WriteLine($"A soma dos números entre {A} e {B} é: {soma}");
    }
}*/

/*using System;
//EXERCICIO 5

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nNúmeros na ordem inversa:");
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}*/

/*
//EXERCICIO 6
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Escreva o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Escreva o número para buscar no array: ");
        int numeroBuscado = int.Parse(Console.ReadLine());
        bool encontrado = false;
        foreach (int numero in numeros)
        {
            if (numero == numeroBuscado)
            {
                encontrado = true;
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine($"O número {numeroBuscado} está presente no array.");
        }
        else
        {
            Console.WriteLine($"O número {numeroBuscado} não está presente no array.");
        }
    }
}*/
/*
//EXERCICIO 7
 using System;
class Program
{
    static double CalcularMedia(double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }


    static void Main()
    {
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());


        Console.Write("Digite a segundaª nota: ");
        double nota2 = double.Parse(Console.ReadLine());


        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());


        double media = CalcularMedia(nota1, nota2, nota3);


        Console.WriteLine($"A média do aluno é: {media:F2}");
    }
}*/

/*
//EXERCICIO 8
using System;
public class Programa
{
    public static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }


        return true;
    }


    public static void Main()
    {
        Console.WriteLine("Digite o número para verificação: ");
        int numero = int.Parse(Console.ReadLine());


        if (EhPrimo(numero))
        {
            Console.WriteLine($"{numero} o número digitado é primo.");
        }
        else
        {
            Console.WriteLine($"{numero} o número digitado não é primo.");
        }
    }
}*/

/*
//EXERCICIO 09
using System;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}*/

//EXERCICIO 10

using System;


public class Calculadora
{
    public double Somar(double num1, double num2)
    {
        return num1 + num2;
    }


    public double Subtrair(double num1, double num2)
    {
        return num1 - num2;
    }


    public double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }


    public double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero!");
            return 0;  
        }
        return num1 / num2;
    }
}


public class Programa
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();


        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());


        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());


        Console.WriteLine($"Soma: {calc.Somar(numero1, numero2)}");
        Console.WriteLine($"Subtração: {calc.Subtrair(numero1, numero2)}");
        Console.WriteLine($"Multiplicação: {calc.Multiplicar(numero1, numero2)}");
        Console.WriteLine($"Divisão: {calc.Dividir(numero1, numero2)}");
    }
}


