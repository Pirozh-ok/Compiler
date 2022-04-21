using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    internal interface IRecursiveFunction
    {
        // Выражение
        void Expression();
        // Слагаемое
        void Term();
        // Множитель
        void Factor();
        // Дробное число
        void FractionalNumber();
        // Функция
        void Function();
        // Целая часть
        void WholePart();
        // Дробная часть
        void Fraction();
        // Цифра
        void Digit();
        // Имя функции
        void NameFunction();
    }
}
