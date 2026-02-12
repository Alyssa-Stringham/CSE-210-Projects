using System.Runtime.CompilerServices;

public class GoalManager
{
        private List<Goal> _goals;
        private int _score; 

        public GoalManager()
        {
                //initializes empty list of goals and sets player's score to 0
        }

        public void Start()
        {
                // called by Program.cs
                // runs menu loop
        }
        
        public void DisplayPlayerInfo()
        {
                // displays current score
        }

        public void ListGoalNames()
        {
                
        }

        public void ListGoalDetails()
        {
                // including checkbox indicating complete or not
                // The goals are: 
                // 1. [ ] goal 1
                // 2. [X] complete goal
                // 3. [ ] checklist - Currently Completed: 0/3

                // display points
        }

        public void CreateGoal()
        {
                // ask user to info
                // creates goal
                // adds to list
        }

        public void RecordEvent()
        {
                // asks user which goal they did
                // records event by calling RecordEvent method on that goal

                //List goals
                // Which goal did you accomplish? 
                // earn points
                // simple goal - mark complete; checklist, add to currently completed - when all done, get bonus
                // Congratulations! You have earned {points} points!
                // You now have {totalPoints} points
        }

        public void SaveGoals()
        {
                // saves list of goals to file
                // What is the filename for the goal file? 
                // decide how to save/ store/ load info (number of points line 1, type of goal: user entered name and description, point value, accomplished or not, times done - checklist)
        }

        public void LoadGoals()
        {
                // loads list of goals from file
                // What is the filename for the goal file? 

        }       
}