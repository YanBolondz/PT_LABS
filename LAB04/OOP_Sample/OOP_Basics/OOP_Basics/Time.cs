using System;

namespace OOP_Basics
{
    public class Time
    {
        // Поля (private для инкапсуляции)
        private int _hour;
        private int _minutes;
        private int _seconds;

        // Свойства с валидацией
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Часы должны быть в диапазоне от 0 до 23");
                _hour = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Минуты должны быть в диапазоне от 0 до 59");
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Секунды должны быть в диапазоне от 0 до 59");
                _seconds = value;
            }
        }

        // Конструктор по умолчанию  // Создается конструктор без параметров

        // Он вызывает другой конструктор того же класса(с тремя параметрами)

        // Передает ему значения 0, 0, 0 (0 часов, 0 минут, 0 секунд)
        public Time() : this(0, 0, 0) { }

        // Конструктор с параметрами
        public Time(int hour, int minutes, int seconds)
        {
            // Используем свойства для установки значений, чтобы сработала валидация
            Hour = hour;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Метод добавления минут (возвращает новый объект Time)
        public Time AddMinutes(int minutes)
        {
            if (minutes == 0)
                return new Time(Hour, Minutes, Seconds);

            int totalMinutes = Hour * 60 + Minutes + minutes;

            // Обработка перехода через сутки
            int newHour = (totalMinutes / 60) % 24;
            if (newHour < 0) newHour += 24; // Для отрицательных минут

            int newMinutes = totalMinutes % 60;
            if (newMinutes < 0)
            {
                newMinutes += 60;
                newHour = (newHour - 1 + 24) % 24;
            }

            return new Time(newHour, newMinutes, Seconds);
        }

        // Метод для представления времени в читаемом виде // Метод, требуемый заданием - ВЫВОДИТ в консоль
        public void PrintTime()
        {
            Console.WriteLine($"{Hour:D2}:{Minutes:D2}:{Seconds:D2}");
        }

        // Переопределение ToString для удобства   // Дополнительный метод (не требуется заданием) - ВОЗВРАЩАЕТ строку
        // Метод ToString() нужен для автоматического преобразования объекта класса Time в строковое представление, что позволяет удобно выводить время в консоль
        public override string ToString()
        {
            return $"{Hour:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}