using System;
using Practice4.Base;

namespace Practice4.Activites
{
    class Running : Activity
    {
        #region Class Level Variables
        private double _runningDistance;

        #endregion

        #region Constructor

        ///<summary>
        /// Constructor for the Running
        /// class. This class inherits
        /// from the Activity base class.
        ///<param name="inputRunningDistance"> The total distance in miles of the running activity.</param>
        ///<param name="inputRunningDuration"> The duration of the running activity in minutes</param> 
        ///<param name="inputRunningDate"> The date of the running activity</param>               
        ///<param name="inputActivityType"> The type of the activity</param>        
        ///</summary>
        public Running(int inputRunningDistance, int inputRunningDuration, DateTime inputRunningDate, Constants.ACTIVITYTYPE inputRunningType) : 
               base(inputRunningDate, inputRunningDuration, Constants.ACTIVITYTYPE.Running) 
        {

            _runningDistance = inputRunningDistance;
            base.SetActivityLengthInMinutes(inputRunningDuration);
            base.SetActivityDate(inputRunningDate);
            base.SetActivityType(inputRunningType);            
            
        }

        #endregion

        #region Getters and Setters

        ///<summary>
        /// Get the running
        /// distance
        ///</summary>
        public double GetRunningDistance()
        {
            return _runningDistance;

        }

        ///<summary>
        /// Set the running
        /// distance
        ///<param name="inputRunningDistance">The input running distance. </param>
        ///</summary>
        public void SetRunningDistance(double inputRunningDistance)
        {

            _runningDistance = inputRunningDistance;

        }


        #endregion

        #region Running Activity Calculations

        ///<summary>
        /// Calculate the
        /// running distance
        /// in miles
        ///</summary>
        public override double CalculateDistance()
        {
            return (_runningDistance);
        }

        ///<summary>
        /// Calculate the running 
        /// speed in miles per hour
        ///</summary>
        public override double CalculateSpeed()
        {


            return ((_runningDistance / base.GetActivityLengthInMinutes()) * Constants.MinutesPerHour);

        }

        ///<summary>
        /// Calculate the running
        /// pace
        ///</summary>
        public override double CalculatePace()
        {
            return (base.CalculatePace() / CalculateSpeed());
        }

        #endregion

        #region Get Summary for Running

        ///<summary>
        /// Returns a summary
        /// of the activity
        /// statistics
        /// Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        ///</summary>
        public override void GetSummary()
        {
            base.GetSummary();
        }

        #endregion
        
    }
    
}