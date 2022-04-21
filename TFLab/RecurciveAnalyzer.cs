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
        private int _currentPosition = 0;
        private List<string> transitions = new List<string>();
        RecurciveAnalyzer(string text)
        {
            _text = text;
            _text.Replace("\n", "");
            _text.Replace(" ", "");
        }

        public void Expression()
        {
            Term ();
            while (_currentPosition < _text.Length)
            {
                _currentPosition++;
                if (_text[_currentPosition] == '+' && _text[_currentPosition] == '-')
                    _currentPosition++;
                Term();
            }
        }

        public void Term()
        {
            transitions.Add("-> <Слагаемое>");
                Factor();
            while (_currentPosition < _text.Length)
            {
                _currentPosition++;
                if (_text[_currentPosition] == '*' && _text[_currentPosition] == '/')
                    _currentPosition++;
                Factor();
            }
        }
        public void Factor()
        {
            transitions.Add("-> <Множитель>");
            Term();
            while (_currentPosition < _text.Length)
            {
                _currentPosition++;
                if (_text[_currentPosition] == '+' && _text[_currentPosition] == '-')
                    _currentPosition++;
                Term();
            }
        }
        public void Digit()
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

/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilersLab1
{


//          G[<условный оператор>]:
//      1. <условный оператор> ::= IF(<условие>) THEN<оператор>
//      2. <условие> ::= <выражение><операция отношения><выражение>
//      3. <выражение> ::= <терм>{ +< терм >}
//4. < терм > ::= < множитель >{ *< множитель >}
//5. < множитель > ::= < идентификатор > | (< выражение >)
//      6. < идентификатор > ::= < буква >{< буква >|< цифра >}
//7. < оператор > ::= < идентификатор >:=< выражение > | < условный оператор >
//8. < операция отношения > ::= ”==” || ”<” | ”<=” | ”>” | ”>=” | ”!=”
//          < буква > ::= A | B | ...| Y | Z
//          < цифра > ::= 0 | 1 | ...| 8 | 9
    class Recoursive
    {
        string Text = "";
        public bool Result = true;
        int I = 0;
        public string ResultText = "";

        public Recoursive(string text)
        {
            Text = text.Replace(" ", "").Replace("\n", "").Replace("\t", "").Replace("\r", "");
        }

        void Identificator()
        {
            ResultText += " Identificator ";
            I++;
            while (I < Text.Length)
            {
                if (Char.IsLetterOrDigit(Text[I]))//пробел перед THEN был бы в тему
                    Result = true;
                else
                {
                    I--;
                    return;
                }
                I++;
            }
        }

        void Multiplier()
        {
            ResultText += " Multiplier ";
            I++;
            if (Char.IsLetter(Text[I]))
            {

                Identificator();
            }

            else
            {
                if (Text[I] == '(')
                {
                    Expression();
                    I++;
                    if (Text[I] != ')')
                    {
                        Result = false;
                        return;
                    }
                }
                else
                {

                }

            }
        }
        void Term()
        {
            ResultText += " Term ";
            Multiplier();
            I++;
            while (I < Text.Length)
            {
                if (Text[I] == '*')
                    Multiplier();
                else return;
                I++;
            }
        }

        void Expression()
        {
            ResultText += " Expression ";
            Term();
            if(I + 1 < Text.Length)
                while (Text[I] == '+' && I < Text.Length)
                {
                    //I++;
                    Term();

                }
        }
        //< операция отношения > ::= ”==” | ”<” | ”<=” | ”>” | ”>=” | ”!=”
        void Operation()
        {
            ResultText += " Operation ";
            if (I + 1 < Text.Length)
            {
                //I++;
                if(Text[I] == '>' || Text[I] == '<')
                {
                    I++;
                    if (Text[I] == '=')
                    {
                        Result = true;
                        return;
                    }
                    else
                    {
                        Result = false;
                        return;
                    }
                }
                else
                {
                    if(Text[I] == '=' || Text[I] == '!')
                    {
                        I++;
                        if (Text[I] == '=')
                        {
                            Result = true;
                            return;
                        }
                        else
                        {
                            Result = false;
                            return;
                        }
                    }
                    else
                    {
                        Result = false;
                        return;
                    }
                }
            }
            else
            {
                Result = false;
                return;
            }
        }

        public void Condition()
        {
            ResultText += " Condition ";
            if (Text[I] == '(')
            {
                Expression();
                Operation();
                Expression();

                if (Text[I] != ')')
                {
                    Result = false;
                    return;
                }
            }
            else
            {
                Result = false;
                return;
            }

        
        }

        //< оператор > ::= < идентификатор >:=< выражение > | < условный оператор > 
        void Operator()
        {
            ResultText += " Operator ";
            //I++;

            
            if (I + 2 < Text.Length) 
            {
                I++;

                if(Text[I] == 'I' && Text[I + 1] == 'F')
                {
                    ConditionalOperator();
                    return;
                }

                if (Char.IsLetter(Text[I]))
                {
                    Identificator();
                }

                else
                {
                    Result = false;
                    return;
                }

                I++;
                if (Text[I] == ':')
                {
                    I++;
                    if(Text[I] == '=')
                    {
                        Expression();
                    }
                    else
                    {
                        Result = false;
                        return;
                    }
                }
                else
                {
                    Result = false;
                    return;
                }
            }

        }
        void ConditionalOperator()
        {
            ResultText += " ConditionalOperator ";
            if (Text[I] == 'I' && Text[I + 1] == 'F' && Text.Length > 3 + I)
            {
                I += 2;
                Condition();
            }
            else
            {
                Result = false;
                return;
            }
           

            if (I + 4 < Text.Length)
                if (Text[I + 1] == 'T' && Text[I + 2] == 'H' && Text[I + 3] == 'E' && Text[I + 4] == 'N')
                {
                    I += 4;
                    Operator();
                }
                else Result = false;
            else Result = false;
        }
        public bool Scan()
        {

            ConditionalOperator();

            return Result;
        }
    }
}
 */