namespace DataStructures.Exercises
{
    //1.22
    //1.1.1
    public enum State
    {
        UNKNOWN,
        DECIMAL,
        AFTER_DECIMAL,
        INITIAL,
        NUMBER
    }

    public class IsValidNumber
    {
        public static bool Check(string input)
        {
            int index = 0;

            State currentState = State.INITIAL;

            while (index < input.Length && currentState != State.UNKNOWN)
            {
                var ch = input[index];

                currentState = GetNextState(ch, currentState);
                index++;
            }

            return currentState != State.UNKNOWN;
        }

        public static State GetNextState(char ch, State currentState)
        {
            State state = State.UNKNOWN;

            switch (currentState)
            {
                case State.INITIAL:
                case State.NUMBER:
                    if (ch > '0' && ch <= '9')
                        state = State.NUMBER;
                    if (ch == '.')
                        state = State.DECIMAL;
                    break;
                case State.AFTER_DECIMAL:
                    {
                        if (ch > '0' && ch <= '9')
                            state = State.AFTER_DECIMAL;
                        if (ch == '.')
                            state = State.UNKNOWN;
                    }
                    break;
                case State.DECIMAL:
                    {
                        if (ch == '.')
                            state = State.UNKNOWN;
                        if (ch > '0' && ch <= '9')
                            state = State.AFTER_DECIMAL;
                    }
                    break;
                case State.UNKNOWN:
                    {
                        state = State.UNKNOWN;
                    }
                    break;
            }

            return state;
        }
    }
}