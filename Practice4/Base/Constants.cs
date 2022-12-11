using System;

namespace Practice4.Base
{
    class Constants
    {

        #region Date Format Specifiers

        public static string NumericDayOfTheWeek = "dd";

        public static string ShortNameOfTheMonth = "MMM";

        public static string Year4Digit = "yyyy";

        public static string USSpecificCulture = "en-US";

        #endregion

        #region Summary Formatting Variables

        public static string _newLine = Environment.NewLine;

        public static string _dividingLine = "**************************************";

        #endregion

        #region Activity Variables


        public enum ACTIVITYTYPE {Cycling = 1, Running = 2, Swimming = 3}      

        public static string CyclingActivity = "Cycling";

        public static string RunningActivity = "Running";        

        public static string SwimmingActivity = "Swimming";        

        public static string UnknownActivity = "Unknown";             

        public static int MinutesPerHour = 60;

        public static double KilometerToMileConversion = 0.62;

        public static int OlympicSwimmingPoolLengthInMeters = 50;

        public static double MeterToKilometerConversion = 0.001;

        #endregion

        
    }
    
}