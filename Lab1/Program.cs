static void TaskWrapper(int? taskNumber)
{
    switch (taskNumber)
    {
        case 1:
            {
                Console.Write("n?");
                var n = Convert.ToByte(Console.ReadLine());
                Console.Write("m?");
                var m = Convert.ToByte(Console.ReadLine());
                Console.Write("x?");
                var x = Convert.ToByte(Console.ReadLine());
                Solvations.SolveTaskOne(n, m, x);
                break;
            }
        case 2:
            {
                Console.Write("x?");
                var x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y?");
                var y = Convert.ToDouble(Console.ReadLine());
                Solvations.SolveTaskTwo(x, y);
                break;
            }
        case 3:
            {
                Console.Write("Выберите тип переменной:\n1 - float, 2 - double: ");
                var dataType = Convert.ToByte(Console.ReadLine());
                
                bool isFloat = (dataType == 1) ? true : false; // тернарный оператор для избавления от 
                if (isFloat)
                {
                    float a = 1000f, b = .0001f;
                    Solvations.SolveTaskThree(a, b);
                }
                else
                {
                    double a = 1000, b = .0001;
                    Solvations.SolveTaskThree(a, b);
                }

                break;
            }
        default:
            {
                break;
            }
    }
    Console.WriteLine();
}

while (true)
{
    Console.Write("Введите номер нужной вам задачи (1/2/3 - номера задач, 0 для выхода из программы): ");
    try
    {
        var chosenTask = Convert.ToByte(Console.ReadLine());
        if (chosenTask == 0) break;
        TaskWrapper(chosenTask);
    }

    catch (System.FormatException ex) { Console.WriteLine("Некорректный ввод!\nПодсказка: используйте запятую при введении вещественных чисел.\n"); } //  Обработка ошибки некорректного ввода значений

    catch (Exception ex) { Console.WriteLine($"!\nПроизошла ошибка выполнения! Текст ошибки: {ex.ToString()}\n!"); } //  Обработка ошибок выполнения
    
}
class Solvations
{
    public static void SolveTaskOne(int m, int n, int x)
    {
        Console.WriteLine($"m - ++n: {m - ++n}");
        Console.WriteLine($"m++ > --n: {m++ > --n}");
        Console.WriteLine($"m-- < ++n: {m-- < ++n}");

        Console.WriteLine($"Значение выражения 25x^-√(x^2+x): {25 * Math.Pow(x, 5) - Math.Sqrt(Math.Pow(x, 2) + x)}");
    }

    public static void SolveTaskTwo(double x, double y)
    {
        if (y <= 0 && (Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) Console.WriteLine("Точка принадлежит площади графика");
        else Console.WriteLine("Точка не относится к площади графика");
    }

    public static void SolveTaskThree(float a, float b)
    {
        Console.WriteLine(Math.Pow(a-b, 3) - (Math.Pow(a, 3)+3*a*Math.Pow(b,2))/(-3*Math.Pow(a,2)*b-Math.Pow(b,3)));
    }

    public static void SolveTaskThree(double a, double b)
    {
        Console.WriteLine(Math.Pow(a - b, 3) - (Math.Pow(a, 3) + 3 * a * Math.Pow(b, 2)) / (-3 * Math.Pow(a, 2) * b - Math.Pow(b, 3)));
    }
}

