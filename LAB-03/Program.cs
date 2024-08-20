namespace LAB_03;

/*-----------------------------------------------
PUCMINAS-Contagem
Disciplina:ATP
Programador: Vitor Prates
Descricao: Algoritimo que encontra as raízes de uma equação do segundo grau
Entrada: Coeficientes a, b e c
Saida: Imprime os valores de x1 e x2 (Raízes da equação de segundo grau) e o delta
-----------------------------------------------*/
class Program
{
    static void Main(string[] args)
    {

        // Declaração das variáveis
        double a, b, c, delta, x1, x2;

        // Entrada de dados com validação
        Console.WriteLine("Digite o valor de a: ");
        a = double.Parse(Console.ReadLine()!);
        while (a == 0)
        {
            Console.WriteLine("'a' não pode ser zero. Digite novamente o valor de a: ");
            a = double.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Digite o valor de b: ");
        b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o valor de c: ");
        c = double.Parse(Console.ReadLine()!);

        // Processamento
        delta = Math.Pow(b, 2) - 4 * a * c;

        // Condição e saída de dados
        if (delta < 0)
        {
            Console.WriteLine("Cálculo impossível - Para números reais, não existe raiz quadrada de um número negativo. \nDelta = {0}", delta);
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("A equação possui uma raiz dupla: x1 = x2 = {0}\nDelta = {1}", x1, delta);
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("O valor de x1 é: {0}\nO valor de x2 é: {1}\nO valor de delta é: {2}", x1, x2, delta);
        }
    }
}