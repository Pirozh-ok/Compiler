using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TFLab.StateMachine;

namespace TFLab
{
    static class UseStateMachine
    {
        static List<StateMachine> _listState = new List<StateMachine>()
        {
            new StateMachine('I', false, new List<Transition>{new Transition('D', '('), new Transition('B','/'),new Transition('K','\n') }),
            new StateMachine('B', false, new List<Transition>{new Transition('C', '/')}),
            new StateMachine('C', false, new List<Transition>{new Transition('C', 's'), new Transition('K', '\n')}),
            new StateMachine('D', false, new List<Transition>{new Transition('F', '*')}),
            new StateMachine('F', false, new List<Transition>{new Transition('F', 's'), new Transition('G', '*'), new Transition('F', '\n')}),
            new StateMachine('G', false, new List<Transition>{new Transition('K',')')}),
            new StateMachine('K', true, null)
        };
        
        static public List<string> StartAnalize(List<(char, int)> lexems, List<string> errors)
        {
            const char startState = 'I';
            char currentState = startState; 
            string result = string.Empty;
            int indexLastEndState = -1;
            bool isStringComment = false;
            bool isMultiStringComment = false;
            int i = 0;
            while (i < lexems.Count())
            {
                //если считанный символ это буква или цифра, то переход обозначаем s, для петли в комментарии
                var transition = (Char.IsLetter(lexems[i].Item1) || Char.IsDigit(lexems[i].Item1) || (lexems[i].Item1 == ' ')) ? 's' : lexems[i].Item1;
                //определяем следующее состояние 
                var nextState = _listState.FirstOrDefault(x => x.State == currentState).Transitions.FirstOrDefault(x => x.transition == transition);

                //если нет перехода по считанному символу, значит неверная последовательность
                if (nextState == null)
                {
                    isStringComment = false;
                    isMultiStringComment = false;
                    var errorSymbol = lexems[i].Item1 == '\n' ? "\\n" : lexems[i].Item1.ToString();
                    errors.Add($"Строка {lexems[i].Item2}: имя \"{errorSymbol}\" не существует в текущем контексте");
                    currentState = startState;
                }
                //если такой переход есть, переходим в след состояние
                else
                {
                    currentState = nextState.state;

                    //если в состоянии комментария, то устанавливаем флаг (для нейтрализации ошибок)
                    if(currentState == 'C')
                        isStringComment = true;

                    //если в состоянии многострочного комментария, устанавливаем флаг (для нейтрализации ошибок)
                    if(currentState == 'F')
                        isMultiStringComment = true;

                    //если след состояние оказалось последним, переходим в начальное состояние, только если это не конец кода
                    if(_listState.FirstOrDefault(x => x.State == currentState).IsEnd && (i + 1 < lexems.Count()))
                    {
                        currentState = startState;
                        indexLastEndState = i;
                    }
                }
                i++;
            }
            /*//если последнее состояние не было конечным, добавляем ошибку последнюю конструкцию
            if(!_listState.FirstOrDefault(x => x.State == currentState).IsEnd && !isStringComment)
            {
                result += $"Неверный синтаксис \"" + text.Substring(indexLastEndState+1,text.Length-indexLastEndState-1) + "\".";
                countError++;
            }
            else if (!_listState.FirstOrDefault(x => x.State == currentState).IsEnd && !isStringComment && isMultiStringComment)
            {
                result += $"Неверный синтаксис \"" + text.Substring(indexLastEndState + 1, text.Length - indexLastEndState - 1) + "\". Пропущена лексема \"*)\"";
                countError++;
            }*/

            return errors;/*$"Количество ошибок: {countError}\n" + result*/;
        }
    }
}
