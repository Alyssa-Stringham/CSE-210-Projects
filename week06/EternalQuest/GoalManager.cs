using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
        private List<Goal> _goals;
        private int _score; 

        public GoalManager()
        {
                _goals = new List<Goal>();
                _score = 0;
                //initializes empty list of goals and sets player's score to 0
        }

        public void Start()
        {
                int userChoiceInt = 0;
                while (userChoiceInt != 6)
                {
                        DisplayPlayerInfo(); 
                        Console.WriteLine("Menu Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
                        string userChoice = Console.ReadLine();
                        userChoiceInt = int.Parse(userChoice);

                        if (userChoiceInt == 1) // create new
                        {
                                CreateGoal();
                        }

                        else if (userChoiceInt == 2) // list 
                        {
                                ListGoalDetails();
                        }

                        else if (userChoiceInt == 3) // save
                        {
                                SaveGoals();
                        }

                        else if (userChoiceInt == 4) // load
                        {
                                LoadGoals();
                        }

                        else if (userChoiceInt == 5) // record event
                        {
                                RecordEvent();
                        }

                        else if (userChoiceInt == 6) // quit
                        {
                                System.Environment.Exit(0);
                        }      

                        else
                        {
                                Console.WriteLine("Invalid Entry. Please select a valid entry. ");
                        }                  
                }
        }
        
        public void DisplayPlayerInfo()
        {
                Console.WriteLine($"You have {_score} points");
        }

        public void ListGoalNames()
        {
                // purpose of this??
        }

        public void ListGoalDetails()
        {
                Console.WriteLine("The goals are: ");
                int goalNumber = 0;
                foreach (Goal goal in _goals)
                {
                        goalNumber +=1; 
                        Console.WriteLine($"{goalNumber}: {goal.GetDetailsString()}");
                }
        }

        public void CreateGoal()
        {
                Console.WriteLine("The types of Goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                Console.WriteLine("Which type of goal do you want to create? ");
                string userGoalChoice = Console.ReadLine();
                int userGoalInt = int.Parse(userGoalChoice);

                Console.WriteLine("What is the name of your goal? ");                        
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal? ");   
                string description = Console.ReadLine();
                Console.WriteLine("How many points do you want accociated with this goal? ");
                string valueString = Console.ReadLine();
                int points = int.Parse(valueString); 

                if (userGoalInt == 1)// simple
                {
                        SimpleGoal simple = new SimpleGoal(name, description, points);
                        _goals.Add(simple);
                }

                else if (userGoalInt == 2)// eternal
                {
                        EternalGoal eternal = new EternalGoal(name, description, points);
                        _goals.Add(eternal);
                }

                else if (userGoalInt ==3)// checklist
                {
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                        string targetString = Console.ReadLine();
                        int target = int.Parse(targetString);
                        Console.WriteLine("What is the bonus for accomplishing the goal that many times? ");  
                        string bonusString = Console.ReadLine();
                        int bonus = int.Parse(bonusString);
                      //  int timesComplete = 0; 

                        ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                        _goals.Add(checklist);
                }
        }

        public void RecordEvent()
        {
                ListGoalDetails();
                Console.WriteLine("Which goal did you accomplish? ");
                string userGoal = Console.ReadLine();
                int userGoalInt = int.Parse(userGoal);
                Goal userGoalString = _goals[userGoalInt-1];
                userGoalString.RecordEvent();
                int points = userGoalString.GetPoints();
                userGoalString.GetStringRepresentation();
                _score += points;
                Console.WriteLine($"You now have {_score} points. ");
        }

        public void SaveGoals()
        {
                Console.WriteLine("What is the name of the goal file? ");
                string filename = Console.ReadLine();
                using(StreamWriter outputFile = new StreamWriter(filename))
                {
                        outputFile.WriteLine(_score);
                        foreach (Goal g in _goals)
                        {
                                outputFile.WriteLine(g.GetStringRepresentation());
                        }
                }
        }

        public void LoadGoals()// loads list from file
        {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string scoreString = File.ReadLines(filename).First();
                _score = int.Parse(scoreString);
                string [] lines = System.IO.File.ReadAllLines(filename);
                string[] linesWithoutScore = lines.Skip(1).ToArray();
                foreach (string line in linesWithoutScore)
                {
                        string[] parts = line.Split(":");
                        string goalType = parts[0];
                        string goalDetails = parts[1];
                        if (goalType == "SimpleGoal")
                        {
                                string[] details = goalDetails.Split("~|~");
                                string GoalName = details[0];
                                string GoalDescription = details[1];
                                string GoalPointsString = details[2];
                                int GoalPoints = int.Parse(GoalPointsString);
                                string CompleteString = details[3];
                                bool isComplete = bool.Parse(CompleteString);
                               // add is complete bool or some way to store/ indicate if complete
                                SimpleGoal simple = new SimpleGoal(GoalName, GoalDescription, GoalPoints, isComplete);
                                simple.IsComplete(); 
                                _goals.Add(simple);

                        }

                        else if (goalType == "EternalGoal")
                        {
                                string[] details = goalDetails.Split("~|~");
                                string GoalName = details[0];
                                string GoalDescription = details[1];
                                string GoalPointsString = details[2];
                                int GoalPoints = int.Parse(GoalPointsString);
                                EternalGoal eternal = new EternalGoal(GoalName, GoalDescription, GoalPoints);
                                _goals.Add(eternal);                               
                        }

                        else if (goalType == "ChecklistGoal")
                        {
                                string[] details = goalDetails.Split("~|~");
                                string GoalName = details[0];
                                string GoalDescription = details[1];
                                string GoalPointsString = details[2];
                                int GoalPoints = int.Parse(GoalPointsString);
                                string GoalBonusString = details[3];
                                int GoalBonus = int.Parse(GoalBonusString);
                                string GoalTargetString = details[4];
                                int GoalTarget = int.Parse(GoalTargetString);
                                string GoalAmount = details[5];
                                int amountCompleted = int.Parse(GoalAmount);
                                ChecklistGoal checklist = new ChecklistGoal(GoalName, GoalDescription, GoalPoints, GoalTarget, GoalBonus, amountCompleted);
                                checklist.IsComplete();
                                // need to access times completed 
                                _goals.Add(checklist);
                        }

                        else
                        {
                                Console.WriteLine("Problem reading from file");
                        }
                }
        }  
  
}