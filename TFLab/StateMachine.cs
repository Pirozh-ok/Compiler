using System.Collections.Generic;

namespace TFLab
{
    class StateMachine
    {
        public class Transition
        {
            public char state;
            public char transition;
            public Transition(char _state, char _transition)
            {
                state = _state;
                transition = _transition;
            }
        }

        //состояние 
        public char State { get; set; }
        // является ли конечным
        public bool IsEnd { get; }
        // список связей с другими состояниями
        private List<Transition> _transitions = new List<Transition>();
        public List<Transition>Transitions { get{ return _transitions; } }
        public StateMachine(char state, bool isEnd, List<Transition> transitions)
        {
            State = state;
            IsEnd = isEnd; 
            _transitions = transitions; 
        }
    }
}
