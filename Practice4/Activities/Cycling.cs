using System;
using Practice4.Base;

namespace Practice4.Activites
{

    class Cycling : Activity
    {
        #region Class Level Variables

        private double _speed;

        #endregion

        #region Constructor

        ///<summary>
        /// Constructor for the Lecture
        /// class. This class inherits
        /// from the Event base class.
        ///<param name="inputCyclingSpeed"> The cycling speed in miles per hour.</param>
        ///<param name="inputCyclingDuration"> The duration of the cycling activity in minutes</param> 
        ///<param name="inputCyclingDate"> The date of the cycling activity</param>               
        ///<param name="inputActivityType"> The type of the activity</param>        
        ///</summary>
        public Cycling(double inputCyclingSpeed, double inputCyclingDuration, DateTime inputCyclingDate, Constants.ACTIVITYTYPE inputCyclingType) : 
            base(inputCyclingDate, inputCyclingDuration, Constants.ACTIVITYTYPE.Cycling)
        {
            _speed = inputCyclingSpeed;
            base.SetActivityLengthInMinutes(inputCyclingDuration);
            base.SetActivityDate(inputCyclingDate);
            base.SetActivityType(inputCyclingType);
            
        }

        #endregion

        #region Getters and Setters

        ///<summary>
        /// Get the cycling
        /// speed in mph
        ///</summary>
        public double GetSpeed()
        {
            return _speed;
        }

        ///<summary>
        /// Set the speed
        /// in miles per hour
        ///<param name="speed">The speed in miles per hour.</param>
        ///</summary>
        public void SetSpeed(int inputSpeed)
        {
            _speed = inputSpeed;
        }

        #endregion

        #region Activity Calculations


        ///<summary>
        /// Calculate the cycling
        /// distance in miles
        ///</summary>    
        public override double CalculateDistance()
        {

            return (base.GetActivityLengthInMinutes() / (Constants.MinutesPerHour / CalculateSpeed()));

        }

        ///<summary>
        /// Calculate the cycling speed
        /// in miles per hour
        ///</summary>
        public override double CalculateSpeed()
        {
            return _speed;
        }

        #endregion


        ///<summary>
        /// Calculate the pace
        /// in minutes and seconds per mile
        ///</summary>
        public override string CalculatePace()
        {
            double doublePace = Constants.MinutesPerHour / CalculateSpeed();

            return $"{Math.Round(doublePace, 2, MidpointRounding.AwayFromZero)}";

        }

        #region Get Summary for Cycling

        ///<summary>
        /// Returns a summary
        /// of the activity
        /// statistics
        /// Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        ///</summary>
        public override void GetSummary(double distance, double speed, string pace)
        {
            base.GetSummary(distance, speed, pace);
        }

        #endregion

        
    }

    
}