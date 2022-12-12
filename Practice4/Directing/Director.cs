using System;
using Practice4.Activites;
using Practice4.Base;

namespace Practice4.Directing
{
    class Director
    {
        private List<Activity> _activities = new List<Activity>();

        public void CreateActivities()
        {

            // Create the Cycling activity

            // Create the Running activity

            // Create the Swimming activity



        }

        ///<summary>
        ///
        ///</summary>
        public void GetActivitySummaries()
        {
            foreach (Activity activity in _activities)
            {
                activity.GetSummary();
                
            }

        }
        
    }
    
}
