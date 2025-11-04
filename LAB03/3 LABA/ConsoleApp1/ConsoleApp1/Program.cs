// See https://aka.ms/new-console-template for more information

// У МЕНЯ НЕЧЕТНЫЙ НОМЕР В СПИСКЕ - 7.  
using System.Xml.Xsl;

void function1()
{ //1 — Переменные и операторы

    //Задание 1.Перевод температуры
    void Temperature()
    {
        Console.WriteLine("Введите температуру в градусах: ");
        float Celsium = float.Parse(Console.ReadLine());
        float Fahrenheit = Celsium * 1.8f + 32;            //F = C × 9/5 + 32
        Console.WriteLine($"В Фаренгейтах: {Fahrenheit}");
    }
    //Задание 2.Перевод валюты
    void Currency()
    {
        Console.WriteLine("Введите сумму в BYN: ");
        float BYN = float.Parse(Console.ReadLine());
        const float exchangerate = 2.9f; //Курс 1 доллар к BYN
        float USD = BYN / exchangerate;
        Console.WriteLine($"В долларах: {USD}");
    }
    //Задание 3.Среднее арифметическое трёх чисел
    void Average()
    {
        int sum = 0;
        float threenumbers = 0f;
        float[] numbers = new float[3];
        float average;
        Console.WriteLine("Введите числа: ");
        for (int i = 0; i < 3; i++)
        {
            numbers[i] = float.Parse(Console.ReadLine());
            sum++;
            threenumbers += numbers[i];
        }
        average = threenumbers / sum;
        Console.WriteLine($"Среднее арифметическое трех чисел: {average} ");
    }

    Console.WriteLine("Введите номер задания:");
    Console.WriteLine("\n");
    Console.WriteLine("1 - Конвертация температуры из градусов в Цельсии");
    Console.WriteLine("3 - Конвертация валюты из RUB в USD");
    Console.WriteLine("5 - Среднее арифметическое трех чисел");
    int choisefunc1 = int.Parse(Console.ReadLine());
    switch (choisefunc1)
    {
        case 1: Temperature(); ; break;
        case 3: Currency(); break;
        case 5: Average(); break;

        default:
            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
            break;
    }


}

void function2()
{ //2 — Условные операторы (if-else, switch)

    //Задание 1.Определение месяца
    void MonthDeter()
    {
        Console.WriteLine("Введите номер месяца: ");
        int month = int.Parse(Console.ReadLine());
        switch (month)
        {
            case 1:
                Console.WriteLine("Январь");
                break;
            case 2:
                Console.WriteLine("Февраль");
                break;
            case 3:
                Console.WriteLine("Март");
                break;
            case 4:
                Console.WriteLine("Апрель");
                break;
            case 5:
                Console.WriteLine("Май");
                break;
            case 6:
                Console.WriteLine("Июнь");
                break;
            case 7:
                Console.WriteLine("Июль");
                break;
            case 8:
                Console.WriteLine("Август");
                break;
            case 9:
                Console.WriteLine("Сентябрь");
                break;
            case 10:
                Console.WriteLine("Октябрь");
                break;
            case 11:
                Console.WriteLine("Ноябрь");
                break;
            case 12:
                Console.WriteLine("Декабрь");
                break;
            default:
                Console.WriteLine("Нет месяца с таким номером");
                break;
        }



    }
    //Задание 3.Определение четверти
    void Circle()
    {
        Console.WriteLine("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвёртой четверти.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Точка находится в начале координат.");
        }
        else if (x == 0)
        {
            Console.WriteLine("Точка находится на оси Y.");
        }
        else if (y == 0)
        {
            Console.WriteLine("Точка находится на оси X.");
        }
    }
    //Задание 5. Определение Времени.
    void TimeDeter()
    {
        Console.WriteLine("Введите часы (от 0 до 23): ");
        int hour = int.Parse(Console.ReadLine());

        if (hour < 0 || hour > 23)
        {
            Console.WriteLine("Некорректный ввод. Часы должны быть от 0 до 23.");
        }
        else if (hour >= 6 && hour < 12)  //Если больше или равно 6 но меньше 12
        {
            Console.WriteLine("Утро");
        }
        else if (hour >= 12 && hour < 18)  //Если больше или равно 12 но меньше 18
        {
            Console.WriteLine("День");
        }
        else if (hour >= 18 && hour < 22)
        {
            Console.WriteLine("Вечер");
        }
        else
        {
            Console.WriteLine("Ночь");
        }
    }

    Console.WriteLine("Введите номер задания:");
    Console.WriteLine("\n");
    Console.WriteLine("1 - Определение месяца");
    Console.WriteLine("3 - Определение координатной четверти");
    Console.WriteLine("5 - Определение времени");
    int choisefunc2 = int.Parse(Console.ReadLine());
    switch (choisefunc2)
    {
        case 1: MonthDeter(); ; break;
        case 3: Circle(); break;
        case 5: TimeDeter(); break;

        default:
            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
            break;
    }
}

void function3()
{ //3 — Циклы (while, do-while, for)

    //Задание 1
    void MINMAXNUMBER()
    {
        Console.WriteLine("Введите целое число: ");
        int number = Math.Abs(int.Parse(Console.ReadLine())); // работаем с положительным

        int minDigit = 9; // стартуем с максимальной возможной цифры
        int maxDigit = 0; // стартуем с минимальной возможной цифры

        while (number > 0)
        {


            while (number > 0)
            {
                int digit = number % 10;     // получаем последнюю цифру
                if (digit < minDigit) minDigit = digit; // обновляем минимум
                if (digit > maxDigit) maxDigit = digit; // обновляем максимум
                number /= 10;                // удаляем последнюю цифру
            }
        }

        Console.WriteLine($"Минимальная цифра: {minDigit}");
        Console.WriteLine($"Максимальная цифра: {maxDigit}");
    }

    //Задание 3
    void Fibonacci()
    {

        Console.Write("Введите количество чисел Фибоначчи: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.WriteLine("Первые " + n + " чисел Фибоначчи:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a + " ");
            int next = a + b;  // вычисляем следующее число
            a = b;            // сдвигаем: теперь предыдущее = текущее
            b = next;         // текущее = новое число

        }

        Console.WriteLine("\n"); // переход на новую строку


    }

    //Задание 5
    void AVERAGEn()
    {
        Console.Write("Введите количество чисел n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Введите число {i}: ");
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        double average = sum / n;
        Console.WriteLine($"Среднее арифметическое: {average}");

    }






    Console.WriteLine("Введите номер задания:");
    Console.WriteLine("\n");
    Console.WriteLine("1 - Минимальная и максимальная цифра");
    Console.WriteLine("3 - Числа Фибоначчи");
    Console.WriteLine("5 - Среднее арифметическое n чисел");
    int choisefunc3 = int.Parse(Console.ReadLine());
    switch (choisefunc3)
    {
        case 1: MINMAXNUMBER(); ; break;
        case 3: Fibonacci(); break;
        case 5: AVERAGEn(); break;

        default:
            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
            break;
    }
}

void function4()
{ //4 — Массивы (одномерные и двумерные)

    //Задание 1
    void Func4task1()
    {
        Console.WriteLine("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        if (cols <= 0 || rows <= 0)
        {
            Console.WriteLine("Отрицательные значения и \"нуль\" исключены");

        }
        else
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();  //экземпляр класса Random для генерации случайных чисел.

            // Заполнение массива случайными числами от 1 до 100
            Console.WriteLine("\nСгенерированный массив:");
            for (int i = 0; i < rows; i++)  //сначала идут строки.Каждый ряд заполняется внутренним циклом.
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);  //rand.Next() — возвращает случайное целое число.
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Суммы строк
            int maxRowSum = int.MinValue;  // Начальное значение - минимальное возможное (Оно будет переназначаться)
            int minRowSum = int.MaxValue;  // Начальное значение - максимальное возможное (Ни одна сумма,не сможет быть больше) 
            int maxRowIndex = -1;          // Индекс строки с макс. суммой
            int minRowIndex = -1;          // Индекс строки с мин. суммой   обе не влияют на конеч


            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                }

                if (rowSum > maxRowSum)
                {
                    maxRowSum = rowSum;
                    maxRowIndex = i;
                }

                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    minRowIndex = i;
                }
            }

            // Суммы столбцов
            int maxColSum = int.MinValue;
            int minColSum = int.MaxValue;
            int maxColIndex = -1;
            int minColIndex = -1;

            for (int j = 0; j < cols; j++)
            {
                int colSum = 0;
                for (int i = 0; i < rows; i++)
                {
                    colSum += matrix[i, j];
                }

                if (colSum > maxColSum)
                {
                    maxColSum = colSum;
                    maxColIndex = j;
                }

                if (colSum < minColSum)
                {
                    minColSum = colSum;
                    minColIndex = j;
                }
            }

            // Вывим результаты  (отсчет с 0)
            Console.WriteLine($"\nСтрока с максимальной суммой: {maxRowIndex} (сумма = {maxRowSum})");
            Console.WriteLine($"Строка с минимальной суммой: {minRowIndex} (сумма = {minRowSum})");          //по желанию,можно к результату прибавить 1,чтобы считать в привычной форме.
            Console.WriteLine($"Столбец с максимальной суммой: {maxColIndex} (сумма = {maxColSum})");
            Console.WriteLine($"Столбец с минимальной суммой: {minColIndex} (сумма = {minColSum})");
        }
    }

    //Задание 3
    void Func4task3()
    {

        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        if (size <= 0)
        {
            Console.WriteLine("Отрицательные значения и 0 не допускаются");
        }
        else
        {

            int[] array = new int[size];

            // Заполнение массива случайными числами от 1 до 100
            Random random = new Random();

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101);
                Console.Write(array[i] + " ");
            }

            // Перестановка элементов в обратном порядке
            for (int i = 0; i < size / 2; i++)   //если четное количество, то меняем все элементы местами, если нечетное,то элемент с центральным индексом не трогается по мат. условию.
            {
                // Обмен элементов местами через временную переменную
                int temp = array[i];  // присваиваем значение 1-го индекса
                array[i] = array[size - 1 - i]; // Записываем значение из правой части в левую часть
                array[size - 1 - i] = temp; // Записываем сохраненное значение левой части в правую
            }

            // Вывод результата
            Console.WriteLine("\n\nМассив в обратном порядке:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }


        }
    }

    //Задание 5
    void Func4task5()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        if (size <= 0)
        {
            Console.WriteLine("Отрицательные значения и нуль исключены");
        }
        else
        {
            // Создание и заполнение массива случайными числами от -100 до 100
            int[] array = new int[size];
            Random random = new Random();

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 101); // числа от -100 до 100
                Console.Write(array[i] + " ");
            }

            // Подсчет количества положительных и отрицательных элементов для будущих 2 массивов
            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < size; i++)
            {
                if (array[i] > 0)
                    positiveCount++;
                else if (array[i] < 0)
                    negativeCount++;
            }

            // Создание массивов для положительных и отрицательных чисел
            int[] positiveArray = new int[positiveCount];
            int[] negativeArray = new int[negativeCount];

            // Заполнение массивов отрицательными и положительными элементами.
            int positiveIndex = 0;
            int negativeIndex = 0;

            for (int i = 0; i < size; i++)  //сортируем массив на положительные и отрицателньые значения.
            {
                if (array[i] > 0)
                {
                    positiveArray[positiveIndex] = array[i];
                    positiveIndex++;
                }
                else if (array[i] < 0)
                {
                    negativeArray[negativeIndex] = array[i];
                    negativeIndex++;
                }
            }

            //Вывод массивов
            Console.WriteLine("\n\nМассив с положительными элементами:");
            if (positiveCount > 0)
            {
                for (int i = 0; i < positiveCount; i++)
                {
                    Console.Write(positiveArray[i] + " ");
                }
            }
            else
            {
                Console.Write("Нет положительных элементов");
            }

            Console.WriteLine("\n\nМассив с отрицательными элементами:");
            if (negativeCount > 0)
            {
                for (int i = 0; i < negativeCount; i++)
                {
                    Console.Write(negativeArray[i] + " ");
                }
            }
            else
            {
                Console.Write("Нет отрицательных элементов");
            }

            Console.WriteLine();
        }

    }




    Console.WriteLine("Введите номер задания:");
    Console.WriteLine("\n");
    Console.WriteLine("1 - Cуммы строк и столбцов");
    Console.WriteLine("3 - Обратный порядок ");
    Console.WriteLine("5 - Разделение массива");
    int choisefunc4 = int.Parse(Console.ReadLine());
    switch (choisefunc4)
    {
        case 1: Func4task1(); break;
        case 3: Func4task3(); break;
        case 5: Func4task5(); break;

        default:
            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
            break;
    }

}

void function5()
{ //5 — Функции и методы

    void Func5task1()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        long result = Factorial(n);
        Console.WriteLine($"{n}! = {result}");

        //Рекурсивная функция

        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

    }

    void Func5task3()
    {

        //Рекурсивная функция счета

        int Sum(int[] array, int index)
        {
            if (index >= array.Length)  // Остановит функция,когда дойдёт до последнего элемента массива.
                return 0;
            else
                return array[index] + Sum(array, index + 1);
        }


        Console.WriteLine("Введите количество элементов массива: ");

        int size = int.Parse(Console.ReadLine());

        if (size <= 0)
        {
            Console.WriteLine("Отрицательные значения и 0 не допускаются");
        }
        else
        {

            int[] array = new int[size];

            // Заполнение массива случайными числами от 1 до 100
            Random random = new Random();

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101);
                Console.Write(array[i] + " ");
            }


            int result = Sum(array, 0);
            Console.WriteLine($"\nСумма элементов массива: {result}");

        }

    }

    void Func5task5()
    {
        //5. Деление с остатком: реализовать функцию Divide(int dividend, int divisor,
        //out int quotient, out int remainder).
        //dividend - делимое
        //divisor - делитель
        //quotient - частное
        //remainder - остаток
        void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        Console.WriteLine("Введите делимое: ");
        int dividend = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите делитель: ");
        int divisor = int.Parse(Console.ReadLine());

        Divide(dividend, divisor, out int quotient, out int remainder);
        Console.WriteLine($"{quotient} и остаток {remainder}"); // Исправил divisor на remainder
    }

    void Func5task7()
    {


        Console.WriteLine("Введите количество элементов в массиве: ");
        int amount = int.Parse(Console.ReadLine());
        int[] array = new int[amount];
        Random random1 = new Random();
        for (int i = 0; i < amount; i++)
        {
            array[i] = random1.Next(1, 101);
        }

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < amount; i++)
        {
            Console.Write($"{array[i],3} ");  // Вывод с шириной 3 символа
        }
        Console.WriteLine();

        // Вызываем функцию фильтрации и получаем массив четных чисел
        int[] evenNumbers = FilterEven(array);

        Console.WriteLine("\nЧетные числа (отфильтрованные функцией):");

        for (int i = 0; i < evenNumbers.Length; i++)
        {
            Console.Write($"{evenNumbers[i],3} ");
        }

        Console.WriteLine();




        // Статистическая информация
        Console.WriteLine($"\nСтатистика:");
        Console.WriteLine($"Всего чисел: {amount}");  // Общее количество чисел
        Console.WriteLine($"Четных чисел: {evenNumbers.Length}");  // Количество четных
        Console.WriteLine($"Нечетных чисел: {amount - evenNumbers.Length}");  // Количество нечетных








        // Демонстрация работы функции с прямым передачей параметров
        Console.WriteLine("\n=== Демонстрация FilterEven с params ===");

        // Вызываем функцию, передавая числа напрямую как параметры
        int[] testResult = FilterEven(2, 4, 5, 6, 8, 11, 12);

        // Выводим результат демонстрации
        Console.WriteLine("FilterEven(2, 4, 5, 6, 8, 11, 12):");
        Console.WriteLine("Результат: " + string.Join(" ", testResult));

        // Функция для фильтрации четных чисел 
        static int[] FilterEven(params int[] numbers)
        {
            // ПЕРВЫЙ ПРОХОД: подсчитываем количество четных чисел
            int evenCount = 0;  // Счетчик четных чисел

            // Перебираем все числа для подсчета
            foreach (int number in numbers)
            {
                // Если число четное, увеличиваем счетчик
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Создаем массив результата нужного размера
            int[] result = new int[evenCount];

            // Выводим информацию о количестве обрабатываемых чисел
            Console.WriteLine($"\nФункция FilterEven обрабатывает {numbers.Length} чисел...");

            // ВТОРОЙ ПРОХОД: заполняем массив результата
            int index = 0;  // Индекс для заполнения массива результата

            // Снова перебираем все числа
            foreach (int number in numbers)
            {
                // Проверяем, является ли число четным
                if (number % 2 == 0)
                {
                    // Если четное - добавляем в массив результата
                    result[index] = number;
                    // Выводим информацию о добавлении
                    Console.WriteLine($" Число {number} - четное (добавлено в массив)");
                    // Увеличиваем индекс для следующего элемента
                    index++;
                }
                else
                {
                    // Если нечетное - просто выводим информацию
                    Console.WriteLine($" Число {number} - нечетное ");
                }
            }

            // Выводим итоговое количество найденных четных чисел
            Console.WriteLine($"В массиве собрано {evenCount} четных чисел");

            // Возвращаем массив с результатом
            return result;
        }




    }

    Console.WriteLine("Введите номер задания:");
    Console.WriteLine("\n");
    Console.WriteLine("1 - функция Factorial(int n)");
    Console.WriteLine("3 - Сумма массива (рекурсия) ");
    Console.WriteLine("5 -  функция Divide(int dividend, int divisor,out int quotient, out int remainder)");
    Console.WriteLine("7 -  Фильтрация чётных чисел");
    int choisefunc5 = int.Parse(Console.ReadLine());
    switch (choisefunc5)
    {
        case 1: Func5task1(); break;
        case 3: Func5task3(); break;
        case 5: Func5task5(); break;
        case 7: Func5task7(); break;
        default:
            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
            break;
    }

}


Console.WriteLine("====================================");
Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА N3 - CS.BASICS");
Console.WriteLine("Основы языка программирования C#");
Console.WriteLine("====================================");
Console.WriteLine("\n");
Console.WriteLine("Выберите блок задач для выполнения: ");
Console.WriteLine("\n");
Console.WriteLine("1 — Переменные и операторы");
Console.WriteLine("2 — Условные операторы (if-else, switch)");
Console.WriteLine("3 — Циклы (while, do-while, for)");
Console.WriteLine("4 — Массивы (одномерные и двумерные)");
Console.WriteLine("5 — Функции и методы");
Console.WriteLine("\n");
Console.WriteLine("0 — Выход из программы");
Console.WriteLine("\n");
Console.WriteLine("Введите номер блока: ");
int choise = int.Parse(Console.ReadLine());

switch (choise)
{
    case 1:
        function1();
        break;
    case 2:
        function2();
        break;
    case 3:
        function3();
        break;
    case 4:
        function4();
        break;
    case 5:
        function5();
        break;
    case 0:
        Console.WriteLine("Выходим из программы...");
        break;
    default:
        Console.WriteLine("Ошибка.Нет совпадений.Закрываем программу...");
        break;
}












