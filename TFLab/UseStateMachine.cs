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
            char previousState = startState; 
            string result = string.Empty;
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
                    var errorSymbol = lexems[i].Item1 == '\n' ? "\\n" : lexems[i].Item1.ToString();
                    errors.Add($"Строка {lexems[i].Item2}: имя \"{errorSymbol}\" не существует в текущем контексте");
                    //возвращаемся в состояние до ошибки и продолжаем разбор
                    currentState = previousState;
                }
                //если такой переход есть, переходим в след состояние
                else
                {
                    //запоминаем предыдущее состояние, для нейтрализации в случае ошибки
                    previousState = currentState;
                    currentState = nextState.state;

                    //если многострочный комментарий, то устанавливаем флаг
                    isMultiStringComment = currentState == 'F' ? true: false;

                    //если след состояние оказалось последним, переходим в начальное состояние, только если это не конец кода
                    if(_listState.FirstOrDefault(x => x.State == currentState).IsEnd && (i + 1 < lexems.Count()))
                    {
                        currentState = startState;
                    }
                }
                i++;
            }
            //если последнее состояние не было конечным, добавляем ошибку про не закрытый комментарий
            if(!_listState.FirstOrDefault(x => x.State == currentState).IsEnd && isMultiStringComment)
                errors.Add($"Строка {lexems[i-1].Item2}: обнаружен не закрытый комментарий, требуется \"*)\"");
            
            return errors;
        }
    }
}