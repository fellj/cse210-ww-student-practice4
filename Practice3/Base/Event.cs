using System;
using Practice3.Base;

namespace Practice3.Base
{
    
    #region CLASS REQUIREMENTS

    /*
        Write a program that has a base Event class along with derived classes for each type of event.
        Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
        Remember that any data or methods that are common among all types of events should be in the base class.

        They would like the ability to generate three different messages:
     
        1. Standard details - Lists the title, description, date, time, and address.
        2. Full details - Lists all of the above, plus type of event and information specific to that event type. 
                          For lectures, this includes the speaker name and capacity. For receptions this includes 
                          an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        3. Short description - Lists the type of event, title, and the date.        

    */

    #endregion

    class Event
    {

        #region Class Level Variables

        private string _eventTitle;

        private string _eventDescription;

        private DateTime _eventDate;

        private TimeOnly _eventTime;

        private Address _eventAddress;

        private Constants.EVENTTYPE _eventType;

        #endregion

        #region Constructor

        public Event(string inputTitle, string inputDescription, DateTime inputDate, TimeOnly inputTime, Address inputAddress, Constants.EVENTTYPE inputEventType)
        {
            _eventTitle       = inputTitle;
            _eventDescription = inputDescription;
            _eventDate        = inputDate;
            _eventTime        = inputTime;
            _eventAddress     = inputAddress;
            _eventType        = inputEventType;
            
        }

        #endregion

        #region Methods

        #region Getters and Setters

        ///<summary>
        /// Get the event
        /// title
        ///</summary>
        public string GetEventTitle()
        {
            return _eventTitle;

        }

        ///<summary>
        /// Set the event
        /// title
        ///<param name="inputEventTitle">Represents the event title string object</param>        
        ///</summary>
        public void SetEventTitle(string inputEventTitle)
        {
            _eventTitle = inputEventTitle;

        }        

        ///<summary>
        /// Get the event
        /// date as a string
        ///</summary>
        public string GetEventDate()
        {
            return _eventDate.ToShortDateString();

        }

        ///<summary>
        /// Set the event
        /// date
        ///<param name="inputEventDate">Represents the event datetime object</param>        
        ///</summary>
        public void SetEventDate(DateTime inputEventDate)
        {
            _eventDate = inputEventDate;

        }                

        ///<summary>
        /// Get the event
        /// description
        ///</summary>
        public string GetEventDescription()
        {
            return _eventDescription;

        }

        ///<summary>
        /// Set the event
        /// description
        ///<param name="inputEventDescription">Represents the event description string object</param>        
        ///</summary>
        public void SetEventDescription(string inputEventDescription)
        {
            _eventDescription = inputEventDescription;

        }

        ///<summary>
        /// Get the event
        /// time
        ///</summary>
        public string GetEventTime()
        {
            return _eventTime.ToString();

        }

        ///<summary>
        /// Set the event
        /// time
        ///<param name="inputEventTime">Represents the event timeonly object</param>        
        ///</summary>
        public void SetEventTime(TimeOnly inputEventTime)
        {
            _eventTime = inputEventTime;

        }



        ///<summary>
        /// Get the event
        /// address
        ///</summary>
        public void GetEventAddress()
        {
           _eventAddress.GetFullAddress();

        }

        ///<summary>
        /// Set the event
        /// address
        ///<param name="inputEventAddress">Represents the event address object</param>
        ///</summary>
        public void SetEventAddress(Address inputEventAddress)
        {
            _eventAddress = inputEventAddress;

        }


 ///<summary>
        /// Gets the string
        /// representation of the event
        /// type based on the enum
        /// event type.
        /// The event type is set initially
        /// in the constructor.
        ///</summary>
        public string GetEventType()
        {
            switch (_eventType)
            {
                case Constants.EVENTTYPE.Lecture:
                     return "Lecture";
                
                case Constants.EVENTTYPE.Outdoor:
                     return "Outdoor";

                case Constants.EVENTTYPE.Reception:
                     return "Reception";

                default:
                     return "Unknown";
            }

        }  


        ///<summary>
        /// Set the event
        /// type
        ///<param name="inputEventType">Represents the event type enum object</param>
        ///</summary>
        public void SetEventType(Constants.EVENTTYPE inputEventType)
        {
            _eventType = inputEventType;

        }

        #endregion


        #region Display Event Messages        




        ///<summary>
        /// Displays the standard details
        /// of the event
        ///</summary>
        public virtual void DisplayStandardEventDetails()
        {

            Console.WriteLine("Standard Event Details");
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine($"Event Title: {GetEventTitle()}");
            Console.WriteLine($"Event Description: {GetEventDescription()}");
            Console.WriteLine($"Event Date: {GetEventDate()}");
            Console.WriteLine($"Event Time: {GetEventTime()}");            
            Console.WriteLine($"Event Address: {Constants._newLine}{_eventAddress.GetFullAddress()}");            



        }

         ///<summary>
        /// Displays the full details
        /// of the event
        ///</summary>
        public virtual void DisplayFullEventDetails()
        {

            Console.WriteLine("Full Event Details");
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine($"Event Title: {GetEventTitle()}");
            Console.WriteLine($"Event Type: {GetEventType()}");            
            Console.WriteLine($"Event Description: {GetEventDescription()}");
            Console.WriteLine($"Event Date: {GetEventDate()}");
            Console.WriteLine($"Event Time: {GetEventTime()}");            
            Console.WriteLine($"Event Address: {Constants._newLine}{_eventAddress.GetFullAddress()}");            



        }     

         ///<summary>
        /// Displays a shortened 
        /// list of the event details
        ///</summary>
        public virtual void DisplayShortEventDetails()
        {

            Console.WriteLine("Short Event Details");
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine(Constants._newLine);
            Console.WriteLine($"Event Title: {GetEventTitle()}");
            Console.WriteLine($"Event Type: {GetEventType()}");            
            Console.WriteLine($"Event Date: {GetEventDate()}");
         



        }

        #endregion         

        #endregion


    }


}