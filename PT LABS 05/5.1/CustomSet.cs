using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_Static
{
    public class CustomSet
    {
        private int[] numbers;

        // Свойство для доступа к массиву без возможности изменения
        public int[] Numbers
        {
            get
            {
                // Возвращаем копию массива для защиты от внешних изменений
                int[] copy = new int[numbers.Length];
                Array.Copy(numbers, copy, numbers.Length);
                return copy;
            }
        }

        // Конструктор с параметрами
        public CustomSet(int[] numbersArray)
        {
            if (numbersArray == null)
                throw new ArgumentNullException(nameof(numbersArray));

            // Удаляем дубликаты и сортируем для удобства
            this.numbers = RemoveDuplicatesAndSort(numbersArray);
        }

        // Приватный метод для удаления дубликатов и сортировки
        private int[] RemoveDuplicatesAndSort(int[] array)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(array);
            int[] result = uniqueNumbers.ToArray();
            Array.Sort(result);
            return result;
        }

        // Оператор + для объединения множеств
        public static CustomSet operator +(CustomSet set1, CustomSet set2)
        {
            if (set1 == null || set2 == null)
                throw new ArgumentNullException();

            // Объединяем два массива
            int[] combined = new int[set1.numbers.Length + set2.numbers.Length];
            Array.Copy(set1.numbers, 0, combined, 0, set1.numbers.Length);
            Array.Copy(set2.numbers, 0, combined, set1.numbers.Length, set2.numbers.Length);

            return new CustomSet(combined);
        }

        // Оператор - для разности множеств
        public static CustomSet operator -(CustomSet set1, CustomSet set2)
        {
            if (set1 == null || set2 == null)
                throw new ArgumentNullException();

            // Элементы из set1, которых нет в set2
            List<int> difference = new List<int>();

            foreach (int num in set1.numbers)
            {
                if (!set2.numbers.Contains(num))
                {
                    difference.Add(num);
                }
            }

            return new CustomSet(difference.ToArray());
        }

        // Оператор & для пересечения множеств
        public static CustomSet operator &(CustomSet set1, CustomSet set2)
        {
            if (set1 == null || set2 == null)
                throw new ArgumentNullException();

            // Элементы, которые есть в обоих множествах
            List<int> intersection = new List<int>();

            foreach (int num in set1.numbers)
            {
                if (set2.numbers.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            return new CustomSet(intersection.ToArray());
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Set: {{{string.Join(", ", numbers)}}}";
        }

        // Переопределение метода Equals для сравнения по количеству элементов
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CustomSet))
                return false;

            CustomSet other = (CustomSet)obj;
            return this.numbers.Length == other.numbers.Length;
        }

        //Переопределение GetHashCode  
        //"Я разработал класс CustomSet для работы с множествами целых чисел.
        //Реализовал хранение в отсортированном массиве без дубликатов, перегрузил операторы для объединения, разности и пересечения, переопределил методы ToString и Equals.
        //Протестировал на двух примерах — все операции работают корректно. Задание выполнено полностью."

        public override int GetHashCode()
        {
            return numbers.Length.GetHashCode();
        }
    }
}