namespace HomeWork01
{
    internal class Program

    {
        //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a* b,
        //введенные из командной строки, и выводящую результат выполнения на экран.
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Необходимо ввести три аргумента: (число, арифметический знак, число).");
            }
            else
            {
                if (!decimal.TryParse(args[0],out decimal number1) || !decimal.TryParse(args[2], out decimal number2))
                {
                    Console.WriteLine("Недопустимое(-ые) число(-а)");
                }
                else
                {
                    switch (args[1])
                    {
                        case "+":
                            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                            break;
                        case "-":
                            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                            break;
                        case "*":
                            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                            break;
                        case "/":
                            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                            break;
                        default:
                            Console.WriteLine("Недопустимый арифметический знак (должен быть \"+\", \"-\", \"*\" или \"\\\")");
                            break;
                    }
                }
            }
        }
    }
}
