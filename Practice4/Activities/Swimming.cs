using System;
using Practice4.Base;

namespace Practice4.Activites
{
    class Swimming : Activity
    {

        #region Class Level Variables

        private int _totalLaps;

        #endregion

        #region Contructor

        ///<summary>
        /// Constructor for the Swimming
        /// class. This class inherits
        /// from the Activity base class.
        ///<param name="inputSwimmingTotalLaps"> The total number of laps of the swimming activity.</param>
        ///<param name="inputSwimmingDuration"> The duration of the swimming activity in minutes</param> 
        ///<param name="inputSwimmingDate"> The date of the swimming activity</param>               
        ///<param name="inputActivityType"> The type of the activity</param>        
        ///</summary>
        public Swimming(int inputSwimmingTotalLaps, double inputSwimmingDuration, DateTime inputSwimmingDate, Constants.ACTIVITYTYPE inputSwimmingType) :
               base(inputSwimmingDate, inputSwimmingDuration, Constants.ACTIVITYTYPE.Swimming)
        {
            _totalLaps = inputSwimmingTotalLaps;
            base.SetActivityLengthInMinutes(inputSwimmingDuration);
            base.SetActivityDate(inputSwimmingDate);
            base.SetActivityType(inputSwimmingType);              
            
        }

        #endregion

        #region Methods

        #region Getters and Setters

        ///<summary>
        /// Get the total
        /// number of laps
        ///</summary>
        public int GetTotalLaps()
        {
            return _totalLaps;
        }

        ///<summary>
        /// Set the total number
        /// of laps
        ///<param name="inputTotalLaps">The total number of laps as integer.</param>
        ///</summary>
        public void SetTotalLaps(int inputTotalLaps)
        {
            _totalLaps = inputTotalLaps;
        }

        


        #endregion

        #region Swimming Activity Calculations

        ///<summary>
        /// Calculate the swimming
        /// distance in miles
        ///</summary>        
        public override double CalculateDistance()
        {
            return (((_totalLaps * Constants.OlympicSwimmingPoolLengthInMeters) * Constants.MeterToKilometerConversion) * Constants.KilometerToMileConversion);

        }

        ///<summary>
        /// Calculate the swimming
        /// speed in miles per hour
        ///</summary>
        public override double CalculateSpeed()
        {
            return (CalculateDistance() / base.GetActivityLengthInMinutes()) * base.CalculateSpeed();

        }

        ///<summary>
        ///
        ///</summary>
        public override string CalculatePace()
        {
            double doublePace = Constants.MinutesPerHour / CalculateSpeed();
            return $"{Math.Round(doublePace, 2, MidpointRounding.AwayFromZero)}";
        }

        


        #endregion


        #region Get Summary

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


        #endregion       
    }
    
}