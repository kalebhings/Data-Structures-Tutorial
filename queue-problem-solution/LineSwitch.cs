namespace queue_problem_solution;

public class LineSwitch
{
    private class Line {
        private readonly string _person;

        public Line(string person) {
            _person = person;
        }

        /// <summary>Connect the call</summary>
        public void MoveLine() {
            Console.WriteLine($"It is now {_person}'s turn to ride!");
        }
    }

    private readonly List<Line> _personQueue = new List<Line>();
    private readonly int _maxQueueSize;

    public LineSwitch(int maxQueueSize)
    {
        _maxQueueSize = maxQueueSize;
    }

    public void EnterLine(string person, string fastPass)
    {
        Line enter = new Line(person);
        if (_personQueue.Count < _maxQueueSize)
        {
            if (fastPass == "y")
            {
                _personQueue.Insert(0, enter);
            }
            else
            {
                _personQueue.Add(enter);                    
            }
        
        }
        else
        {
            Console.WriteLine($"Line is at max length, unable to add {person}");
        }
    }

    public void LineLength()
    {
        int length = _personQueue.Count();
        Console.WriteLine($"There are {length} people in line.");
    }

    public void ProcessLine()
    {
        if (_personQueue.Count > 0)
        {
            Line move = _personQueue[0];
            _personQueue.RemoveAt(0);
            move.MoveLine();
        }
        else
        {
            Console.WriteLine("There is no one in line!");
        }
    }
}