public class GoalTrack
{
    private List<Goal> _goalsList;
    private int _score;

    public GoalTrack()
    {
        _goalsList = new List<Goal>();
        _score = 0;
    }
    
    public void AddGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }
    public void RecordGoal(string goalName)
    {
        if (goalName != null)
        {
           // goalName.RecordGoal();
           // _score += goalName.Value;
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }
    public void DisplayGoal()
    {
        Console.WriteLine("The goals are:");

        int i = 0;
       // while (i < _goalsList.Count)
        {
            foreach (Goal goal in _goalsList)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    Console.Write($"Completed: {checklistGoal._timesDone}/{checklistGoal._numOfTimes} times");
                }
                else
                {
                    Console.WriteLine($"[]{_goalsList[i+1]}. {goal.IsComplete} {goal}");
                    i++;
                }
                
            }
            
                
            }
        }
        public int DisplayScore()
        {
            Console.WriteLine($"You have {_score} points.");
            return _score;
        }
    }