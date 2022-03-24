using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    class Transition
    {
        public int state;
        public char transition;
        public Transition(int _state, char _transition)
        {
            state = _state;
            transition = _transition;
        }
    }
    class StateMachine
    {
        public int State { get; set; }
        public bool IsEnd { get; }
        private List<Transition> _transitions = new List<Transition>();
        public List<Transition>Transitions { get{ return _transitions; } }
        public StateMachine(int state, bool isEnd, List<Transition> transitions)
        {
            State = state;
            IsEnd = isEnd; 
            _transitions = transitions; 
        }
    }
}
