namespace MinhaCalculadoraEngCivil2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**CALCULADORA**");
            Console
                .WriteLine("Informe o número da operação que deseja efetuar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Resto da divisão (mod)");

            int operacao = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out operacao);
            //int.TryParse(Console.ReadLine(), out int operacaoDois);
            
            // estrutura de condição
            // OU  -> || se uma das condições for verdadeira então entra na condição
            // E -> && se uma das condições for falsa NÃO entra na condição
            if (operacao != 1 && operacao != 2 && operacao != 3
                && operacao != 4 && operacao != 5)
            {
                Console
                    .WriteLine($"Valor digitado {operacao} na operação é inválido!");
                return;
            }

            Console.WriteLine("Informe o primeiro valor para a operação: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor para a operação: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());

            decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = primeiroValor + segundoValor;
                    break;
                case 2:
                    resultado = primeiroValor - segundoValor;
                    break;
                case 3:
                    resultado = primeiroValor / segundoValor;
                    break;
                case 4:
                    resultado = primeiroValor * segundoValor;
                    break;
                case 5:
                    resultado = primeiroValor % segundoValor;
                    break;
            }

            Console.WriteLine($"Resultado da operação: {resultado}");
        }
    }
}