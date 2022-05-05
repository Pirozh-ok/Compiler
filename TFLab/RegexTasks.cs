using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static TFLab.StateMachine;

namespace TFLab
{    static public class RegexTasks
    {
        //конечный автомат для 2 задачи - поиск комментариев языка php
        static List<StateMachine> _listState = new List<StateMachine>()
        {
            new StateMachine('I', false, new List<Transition>
                {
                    new Transition('A', '<')
                }),
            new StateMachine('A', false, new List<Transition>
                {
                    new Transition('B', '!')
                }),
            new StateMachine('B', false, new List<Transition>
                {
                    new Transition('C', '-')
                }),
            new StateMachine('C', false, new List<Transition>
                {
                    new Transition('D', '-')
                }),
            new StateMachine('D', false, new List<Transition>
                {
                    new Transition('E', '-'),
                    new Transition('D', 's')
                }),
            new StateMachine('E', false, new List<Transition>
                {
                    new Transition('F', '-')
                }),
            new StateMachine('F', false, new List<Transition>
                {
                    new Transition('K', '>')
                }),
            new StateMachine('K', true, new List<Transition>{})
        };

        static public string Task1(string text)
        {
            //22. Установить, являются ли истинными тождества для регулярного выражения R1:
            //R1*R1*=R1*

            string result = string.Empty;
            Regex regex1 = new Regex(@"(abc+)*"),
                  regex2 = new Regex(@"(abc+)*(abc+)*");

            var matches1 = regex1.Matches(text);
            var matches2 = regex2.Matches(text);

            result += "1 выражение:\n";

            foreach (Match match in matches1)
            {
                result += $"{match.Value} позиция c {match.Index} по {match.Index + match.Value.Length}\n";
            }

            result += "\n2 выражение:\n";

            foreach (Match match in matches2)
            {
                result += $"{match.Value} позиция c {match.Index} по {match.Index + match.Value.Length}\n";
            }

            return result;
        }

        static public string Task2(string text)
        {
            // задача 45 - Построить РВ для поиска комментариев в PHP
            Regex regex = new Regex(@"<!--.*-->", RegexOptions.Multiline);
            var matches = regex.Matches(text);
            string result = "Через регулярное выражение:\n"; 

            foreach (Match match in matches)
            {
                result+= $"{match.Value} позиция c {match.Index} по {match.Index + match.Value.Length}\n";
            }

            result += "\nЧерез конечный автомат:\n";
            const char startState = 'I';
            char currentState = startState;
            var listSymbol = new List<Char>() { '<', '!', '-', '>' };
            int startPos = 0;
            string currentString = string.Empty;
            for(int i = 0; i < text.Length; i++)
            {
                var transition = !listSymbol.Contains(text[i])? 's':text[i];
                var nextState = _listState
                    .FirstOrDefault(x => x.State == currentState).Transitions
                    .FirstOrDefault(x => x.transition == transition);

                //если есть след состояние, переходим в него
                if(nextState != null)
                {
                    //если это начало комментария, то фиксируем его начальную позицию
                    if (currentState == 'I')
                        startPos = i;

                    currentString += text[i];
                    currentState = nextState.state;

                    //если перешли в конечное состояние - выводим результат и возвращаемся в начальное
                    if (_listState.FirstOrDefault(x => x.State == currentState).IsEnd)
                    {
                        result += $"{currentString} позиция с {startPos} по {startPos + currentString.Length}\n";
                        currentState = startState;
                        currentString = string.Empty;
                    }
                }
                //если нет перехода, начинаем разбирать с начального состояния
                else
                {
                    currentState = startState;
                    currentString = string.Empty;
                }
            }

            return result;
        }

        static public string Task3(string text)
        {
            //12. На основании свойств регулярных выражений доказать тождества для
            //произвольных R1, R2, R3, R4:
            //(R1 | R2)(R3 | R4) = R1R4 | R1R3 | R2R3 | R2R4

            string result = string.Empty;
            Regex regex1 = new Regex(@"(a|b)(c|d)"),
                  regex2 = new Regex(@"ac|ad|bc|bd");

            var matches1 = regex1.Matches(text);
            var matches2 = regex2.Matches(text);

            result += "1 выражение:\n";

            foreach (Match match in matches1)
            {
                result += $"{match.Value} позиция c {match.Index} по {match.Index + match.Value.Length}\n";
            }

            result += "\n2 выражение:\n";

            foreach (Match match in matches2)
            {
                result += $"{match.Value} позиция c {match.Index} по {match.Index + match.Value.Length}\n";
            }

            return result;
        }
    }

}
