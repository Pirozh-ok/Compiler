using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    static class UseStateMachine
    {
        static List<StateMachine> _listState = new List<StateMachine>()
        {
            new StateMachine(0, false, new List<Transition>{new Transition(1, 'a')}),
            new StateMachine(1, false, new List<Transition>{new Transition(2, 'b')}),
            new StateMachine(2, false, new List<Transition>{new Transition(3, 'c'), new Transition(4, 'd')}),
            new StateMachine(3, false, new List<Transition>{new Transition(5, 'e'), new Transition(6, 'f')}),
            new StateMachine(4, false, new List<Transition>{new Transition(1, 'k'), new Transition (7, 'g')}),
            new StateMachine(5, false, new List<Transition>{new Transition(8, 'n'), new Transition(1, 'i')}),
            new StateMachine(6, false, new List<Transition>{new Transition(8, 'n'), new Transition(1, 'i')}),
            new StateMachine(7, false, new List<Transition>{new Transition(8, 'n')}),
            new StateMachine(8, false, new List<Transition>{new Transition(9, 'm')}),
            new StateMachine(9, false, new List<Transition>{new Transition(10, 'l')}),
            new StateMachine(10, true, new List<Transition>{})
        };

        static Dictionary<char, string> _descriptionState = new Dictionary<char, string>()
        {
            {'a', "переход в состояние 1 - поставить бутыку" },
            {'b', "переход в состояние 2 - выбрать способ оплаты" },
            {'c', "переход в состояние 3 - выбран способ оплаты наличными" },
            {'d', "переход в состояние 4 - выбран способ оплаты по карте" },
            {'e', "переход в состояние 5 - оплата монетами" },
            {'f', "переход в состояние 6 - оплата купюрами" },
            {'i', "переход в состояние 1 - купюра/монеты автомат не принял" },
            {'k', "переход в состояние 1 - сервер не ответил" },
            {'g', "переход в состояние 7 - сервер ответил" },
            {'n', "переход в состояние 8 - оплата прошла успешно" },
            {'m', "переход в состояние 9 - налить молоко" },
            {'l', "переход в состояние 10 - забрать молоко" }
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
