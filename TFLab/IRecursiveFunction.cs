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
        // Цифра
        void Digit();
        // Дробная часть
        void Fraction();
        // Имя функции
        void NameFunction();
    }
}
