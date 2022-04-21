using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    internal class RecurciveAnalyzer : IRecursiveFunction
    {
        private string _text; 
        private 
        RecurciveAnalyzer(string text)
        {
            _text = text;
            _text.Replace("\n", "");
            _text.Replace(" ", "");
        }

        public void Expression()
        {
            Term();
        }

        public void Term()
        {
            throw new NotImplementedException();
        }
        public void Digit()
        {
            throw new NotImplementedException();
        }

        

        public void Factor()
        {
            throw new NotImplementedException();
        }

        public void Fraction()
        {
            throw new NotImplementedException();
        }

        public void FractionalNumber()
        {
            throw new NotImplementedException();
        }

        public void Function()
        {
            throw new NotImplementedException();
        }

        public void NameFunction()
        {
            throw new NotImplementedException();
        }

        public void WholePart()
        {
            throw new NotImplementedException();
        }
    }
}
