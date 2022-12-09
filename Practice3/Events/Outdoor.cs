using System;
using Practice3.Base;

namespace Practice3.Events
{
    class Outdoor : Event
    {
        #region Class Level Variables

        

        private string _weatherStatement;


        #endregion

        #region Constructor


        ///<summary>
        /// Constructor for the Outdoor
        /// class. This class inherits
        /// from the Event base class.
        ///<param name="inputOutdoorTitle"> The title of the outdoor event</param>
        ///<param name="inputOutdoorDescription"> The description of the outdoor event</param> 
        ///<param name="inputOutdoorDate"> The date of the outdoor event</param>               
        ///<param name="inputOutdoorTime"> The time of the outdoor event</param>        
        ///<param name="inputOutdoorAddress"> The location of the outdoor event</param>        
        ///<param name="inputEventType"> The type of the event</param>        
        ///</summary>
        public Outdoor(string inputOutdoorTitle, string inputOutdoorDescription, DateTime inputOutdoorDate, TimeOnly inputOutdoorTime, Address inputOutdoorAddress, Constants.EVENTTYPE inputOutdoorType) : 
            base(inputOutdoorTitle, inputOutdoorDescription, inputOutdoorDate, inputOutdoorTime, inputOutdoorAddress, Constants.EVENTTYPE.Outdoor)
        {
            SetEventTitle(inputOutdoorTitle);
            SetEventDescription(inputOutdoorDescription);
            SetEventTime(inputOutdoorTime);
            SetEventAddress(inputOutdoorAddress);
            SetEventType(inputOutdoorType);
            
        }

        #endregion

        #region Methods

        #region Getters and Setters


        ///<summary>
        /// Get the weather
        /// statement
        ///</summary>
        public string GetWeatherStatement()
        {
            return _weatherStatement;

        }

        ///<summary>
        /// Set the weather
        /// statement
        ///<param name="inputWeatherStatement"> The string representation of the weather forecast.</param>
        ///</summary>
        public void SetWeatherStatement(string inputWeatherStatement)
        {
            _weatherStatement = inputWeatherStatement;
        }

        #endregion

        #region Display Outdoor Messages

        ///<summary>
        /// Displays the full
        /// outdoor event details
        ///</summary>
        public override void DisplayFullEventDetails()
        {
            base.DisplayFullEventDetails();
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine($"Weather Forecast: {GetWeatherStatement()}");


        }

        #endregion

        #endregion
    }
}