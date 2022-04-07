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
            new StateMachine(0, false, new List<Transition>{new Transition(1, 'a')}),
            new StateMachine(1, false, new List<Transition>{new Transition(2, 'c'), new Transition(3, 'd')}),
            new StateMachine(2, false, new List<Transition>{new Transition(4, 'e'), new Transition(5, 'f')}),
            new StateMachine(3, false, new List<Transition>{new Transition(1, 'k'), new Transition (7, 'n')}),
            new StateMachine(4, false, new List<Transition>{new Transition(1, 'i'), new Transition(6, 'g')}),
            new StateMachine(5, false, new List<Transition>{new Transition(1, 'i'), new Transition(6, 'g')}),
            new StateMachine(6, false, new List<Transition>{new Transition(7, 'n')}),
            new StateMachine(7, false, new List<Transition>{new Transition(8, 'm')}),
            new StateMachine(8, false, new List<Transition>{new Transition(9, 'l')}),
            new StateMachine(9, true, new List<Transition>{})
        };

        static Dictionary<char, string> _descriptionState = new Dictionary<char, string>()
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
        };
        static public string StartAnalize(string[] strings)
        {
            const int startState = 0;
            string result = string.Empty;

           // рассматриваем каждую строку из ввода пользователя
            for(int j = 0; j < strings.Count(); j++)
            { 
                // начальное состояние всегда 0
                int currentState = startState;
                result += $"Анализ {j + 1} строки:\n";
                //анализируем каждый входящий символ, на наличие таких выходов из текущего состояния
                for (int i = 0; i < strings[j].Length; i++)
                {
                    var nextState = _listState.FirstOrDefault(x => x.State == currentState).Transitions.FirstOrDefault(x=>x.transition == strings[j][i]);
                    
                    if (nextState != null)
                    { 
                        currentState = nextState.state;
                        result += _descriptionState[nextState.transition] + '\n';
                    }
                    else 
                        return "ошибка в строке номер " + (j + 1).ToString() + " - нет перехода или неизвестный символ '" + strings[j][i] + "'"; 
                }
                // проверяем, является ли последнее состояние в которое перешли конечным. если нет, то цепочка переходов неполная и это ошибка
                if(!_listState.FirstOrDefault(x => x.State == currentState).IsEnd)
                    return "ошибка в строке номер " + (j + 1).ToString() + " - строка не пришла в конечное состояние";

                result += "\n";
            }
            return result;
        }
    }
}
