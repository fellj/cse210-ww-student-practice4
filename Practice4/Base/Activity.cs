using System;
using System.Globalization;

namespace Practice4.Base
{

    #region CLASS REQUIREMENTS

    /*

    For each activity, they want to track the the date and the length of the activity in minutes.
    In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    These methods should be overridden in the derived classes.
    Finally, you should provide a GetSummary method to produce a string with all the summary information.
    Remember that the summary method can make use of the other methods to produce its result. 
    This method should be available for all classes, so it should be defined in the base class 
    (you can override it in the derived classes if needed, but it may not need to be...).
     
    */

    #endregion

    class Activity
    {

        #region Class Level Variables

        private DateTime _activityDate;

        private int _activityLengthInMinutes;

        private Constants.ACTIVITYTYPE _activityType;

        #endregion

        #region Constructor

        ///<summary>
        /// Constructor for the base
        /// activity class. 
        ///<param name="inputActivityLengthInMinutes"> The length of the activity in minutes</param>
        ///<param name="inputActivityDate"> The date of the lecture</param>               
        ///<param name="inputActivityType"> The type of the event</param>        
        ///</summary>        
        public Activity(DateTime inputActivityDate, int inputActivityLengthInMinutes, Constants.ACTIVITYTYPE inputActivityType)
        {

            _activityDate = inputActivityDate;
            _activityLengthInMinutes = inputActivityLengthInMinutes;
            _activityType = inputActivityType;

            
        }

        #endregion

        #region Methods
        
        
        #region Getters and Setters

        ///<summary>
        /// Get activity
        /// date
        ///</summary>
        public string GetActivityDate()
        {
            return _activityDate.ToString($"{Constants.NumericDayOfTheWeek} {Constants.ShortNameOfTheMonth} {Constants.Year4Digit}", 
                                             CultureInfo.CreateSpecificCulture(Constants.USSpecificCulture));
        }

        ///<summary>
        /// Set activity
        /// date
        ///<param name="inputActivityDate">The input activity date.</param>
        ///</summary>
        public void SetActivityDate(DateTime inputActivityDate)
        {
            _activityDate = inputActivityDate;
        }

        ///<summary>
        /// Get the activity
        /// length in minutes
        ///</summary>
        public int GetActivityLengthInMinutes()
        {
            return _activityLengthInMinutes;
        }

        ///<summary>
        /// Set the activity
        /// length in minutes
        ///<param name="inputActivityLengthInMinutes">The activity length in minutes</param>
        ///</summary>
        public void SetActivityLengthInMinutes(int inputActivityLengthInMinutes)
        {

            _activityLengthInMinutes = inputActivityLengthInMinutes;

        }


       ///<summary>
        /// Get the activity
        /// type
        ///</summary>
        public string GetActivityType()
        {
            switch (_activityType)
            {
                case Constants.ACTIVITYTYPE.Cycling:
                    return Constants.CyclingActivity;

                case Constants.ACTIVITYTYPE.Running:
                    return Constants.RunningActivity;

                case Constants.ACTIVITYTYPE.Swimming:
                    return Constants.SwimmingActivity;
                
                default:
                    return Constants.UnknownActivity;
            }

        }

        ///<summary>
        /// Set the activity
        /// type
        ///<param name="inputActivityType">The activity type as enum ACTIVITYTYPE</param>
        ///</summary>
        public void SetActivityType(Constants.ACTIVITYTYPE inputActivityType)
        {

            _activityType = inputActivityType;

        }       

        ///<summary>
        /// Get the speed
        /// in mph
        ///</summary>
        public virtual int GetSpeedInMPH()
        {
            int speed = 10;

            return speed;
        }

        ///<summary>
        /// Get the distance
        /// in miles
        ///</summary>
        public virtual double GetDistanceInMiles()
        {
            double distance = 1.10;

            return distance;
        }   

        ///<summary>
        /// Get the pace
        /// in total miles
        /// in one minute
        ///</summary>
        public virtual double GetPace()
        {
            double distanceInOneMinute = 0.65;

            return distanceInOneMinute;
        }             



        #endregion

        #region Activity Calculations

        ///<summary>
        /// Calculate the speed
        /// in miles per hour
        ///</summary>
        public virtual double CalculateSpeed()
        {


            return (Constants.MinutesPerHour);

        }

        ///<summary>
        /// Calculate the distance
        /// in miles
        ///</summary>
        public virtual double CalculateDistance()
        {


            return (Constants.OlympicSwimmingPoolLengthInMeters * Constants.MeterToKilometerConversion * Constants.KilometerToMileConversion);

        }

        ///<summary>
        /// Calculate the pace
        /// in minutes per mile
        ///</summary>
        public virtual double CalculatePace()
        {


            return Constants.MinutesPerHour;

        }        


        #endregion

        #region Get Summary

        ///<summary>
        /// Returns a summary
        /// of the activity
        /// statistics
        /// Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        ///</summary>
        public virtual void GetSummary()
        {
            Console.WriteLine($"Activity Summary:{Constants._newLine}{Constants._dividingLine}");
            Console.WriteLine($"{Constants._newLine}");
            Console.WriteLine($"{GetActivityDate()} {GetActivityType()} ({GetActivityLengthInMinutes()} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()}");

        }

        #endregion
   
        #endregion


    }
    
}