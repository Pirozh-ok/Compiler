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
            new StateMachine('I', false, new List<Transition>{new Transition('D', '('), new Transition('B','/')}),
            new StateMachine('B', false, new List<Transition>{new Transition('C', '/')}),
            new StateMachine('C', false, new List<Transition>{new Transition('C', 's'), new Transition('K', '\n')}),
            new StateMachine('D', false, new List<Transition>{new Transition('F', '*')}),
            new StateMachine('F', false, new List<Transition>{new Transition('F', 's'), new Transition('G', '*'), new Transition('F', '\n')}),
            new StateMachine('G', false, new List<Transition>{new Transition('K',')')}),
            new StateMachine('K', true, null),
        };
        /**/ // 
        /*static Dictionary<char, string> _descriptionState = new Dictionary<char, string>()
        {
            {'a', "переход в состояние 1 - поставить бутыку" },
            {'c', "переход в состояние 2 - выбран способ оплаты наличными" },
            {'d', "переход в состояние 3 - выбран способ оплаты по карте" },
            {'e', "переход в состояние 4 - оплата монетами" },
            {'f', "переход в состояние 5 - оплата купюрами" },
            {'i', "переход в состояние 1 - купюру/монеты автомат не принял" },
            {'k', "переход в состояние 1 - оплата по карте не прошла" },
            {'g', "переход в состояние 6 - выдача сдачи" },
            {'n', "переход в состояние 7 - оплата прошла успешно" },
            {'m', "переход в состояние 8 - налить молоко" },
            {'l', "переход в состояние 9 - забрать молоко" }
        };*/
        static public string StartAnalize(string text)
        {
            int countError = 0; 
            const char startState = 'I';
            char currentState = startState; 
            string result = string.Empty;
            int indexLastEndState = -1;
            int i = 0;
            while (i < text.Length)
            {
                //если считанный символ это буква или цифра, то переход обозначаем s, для петли в комментарии
                var transition = (Char.IsLetter(text[i]) || Char.IsDigit(text[i]) || (text[i] == ' ')) ? 's' : text[i];

                //если считаный символ буква и это последний символ в строке, то это конечное состояние
                if ((transition == 's' || Char.IsDigit(text[i])) && i + 1 == text.Length)
                    transition = '\n';

                var nextState = _listState.FirstOrDefault(x => x.State == currentState).Transitions.FirstOrDefault(x => x.transition == transition);

                //если нет перехода по считанному символу, значит это ошибочный символ
                if (nextState == null)
                {
                    result += $"Имя \"{text[i]}\" не существует в текущем контексте\n";
                    countError++;
                    currentState = startState;
                }
                //если такой переход есть, переходим в след состояние
                else
                {
                    currentState = nextState.state;
                    //если след состояние оказалось последним, переходим в начальное состояние, только если это не конец кода
                    if(_listState.FirstOrDefault(x => x.State == currentState).IsEnd && (i + 1 < text.Length))
                    {
                        currentState = startState;
                        indexLastEndState = i;
                    }
                }
                i++;
            }
            //если последнее состояние не было конечным, добавляем ошибку последнюю конструкцию
            if(!_listState.FirstOrDefault(x => x.State == currentState).IsEnd)
            {
                result += $"Неверный синтаксис: " + text.Substring(indexLastEndState+1,text.Length-indexLastEndState-1);
                countError++;
            }
 
            return $"Количество ошибок: {countError}\n" + result;
        }
    }
}
