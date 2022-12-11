using System;
using Practice4.Base;

namespace Practice4.Activites
{

    class Cycling : Activity
    {
        #region Class Level Variables

        private int _speed;

        private double _cyclingDistance;

        private double _cyclingPace;

        #endregion

        #region Constructor

        ///<summary>
        /// Constructor for the Lecture
        /// class. This class inherits
        /// from the Event base class.
        ///<param name="inputCyclingSpeed"> The average speed of the cylcing activity.</param>
        ///<param name="inputCyclingDuration"> The duration of the cycling activity in minutes</param> 
        ///<param name="inputCyclingDate"> The date of the cycling activity</param>               
        ///<param name="inputActivityType"> The type of the activity</param>        
        ///</summary>
        public Cycling(int inputCyclingSpeed, int inputCyclingDuration, DateTime inputCyclingDate, Constants.ACTIVITYTYPE inputCyclingType) : 
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
        public int GetSpeed()
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

        ///<summary>
        /// Get cycling distance
        ///</summary>
        public double GetCyclingDistance()
        {
            return _cyclingDistance;
        }

        ///<summary>
        /// Set cycling distance
        ///</summary>
        public void SetCyclingDistance(double inputCyclingDistance)
        {
            _cyclingDistance = inputCyclingDistance;
        }        

        ///<summary>
        /// Get the cycling
        /// pace
        ///</summary>
        public double GetCyclingPace()
        {
            return _cyclingPace;
        }

        ///<summary>
        /// Set the cycling
        /// pace
        ///<param name="inputCyclingPace">The cycling pace.</param>
        ///</summary>
        public void SetCyclingPace(double inputCyclingPace)
        {
            _cyclingPace = inputCyclingPace;
        }

        #endregion

        #region Activity Calculations


        ///<summary>
        /// Calculate the cycling
        /// distance in miles
        ///</summary>    
        public override double CalculateDistance()
        {
            return (_cyclingDistance * base.CalculateDistance());

        }

        ///<summary>
        /// Calculate the cycling speed
        /// in miles per hour
        ///<param name="minutes">Double value representing the
        /// total number of minutes for the activity.</param>        
        ///<param name="distance">Double value representing the
        /// distance.</param>
        ///</summary>
        public override double CalculateSpeed(double minutes, double distance)
        {
            return base.CalculateSpeed(minutes, distance);
        }

        #endregion


        ///<summary>
        /// Calculate the pace
        /// in minutes per mile
        ///<param name="minutes">Double value representing the
        /// total number of minutes required to run one mile.</param>
        ///<param name="distance">Double value representing the
        /// total number of miles traveled.</param>
        ///</summary>
        public override double CalculatePace(double minutes, double distance)
        {
            return base.CalculatePace(minutes, distance);
        }

        #region Get Summary for Cycling

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