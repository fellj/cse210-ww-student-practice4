using System;

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



        private static string _newLine = Environment.NewLine;

        private static string _dividingLine = "###########################";

        private enum EVENTTYPE {Lecture = 1, Outdoor = 2, Reception = 3}

        private string _eventTitle;

        private string _eventDescription;

        private DateTime _eventDate;

        private TimeOnly _eventTime;

        private Address _eventAddress;

        private int _eventType;

        public Event(string inputTitle, string inputDescription, DateTime inputDate, TimeOnly inputTime, Address inputAddress, int inputEventType)
        {
            _eventTitle       = inputTitle;
            _eventDescription = inputDescription;
            _eventDate        = inputDate;
            _eventTime        = inputTime;
            _eventAddress     = inputAddress;
            _eventType        = inputEventType;
            
        }

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
        ///</summary>
        public void SetEventTitle(string inputEventTitle)
        {
            _eventTitle = inputEventTitle;

        }        

        ///<summary>
        /// Get the event
        /// date
        ///</summary>
        public DateTime GetEventDate()
        {
            return _eventDate;

        }

        ///<summary>
        /// Set the event
        /// date
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
        ///</summary>
        public void SetEventDescription(string inputEventDescription)
        {
            _eventDescription = inputEventDescription;

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
        ///</summary>
        public void SetEventDescription(string inputEventDescription)
        {
            _eventDescription = inputEventDescription;

        }


        ///<summary>
        /// Displays the standard details
        /// of the event
        ///</summary>
        public virtual void DisplayStandardEventDetails()
        {

            Console.WriteLine("Standard Event Details");
            Console.WriteLine(_dividingLine);
            Console.WriteLine(_newLine);
            Console.WriteLine(_newLine);
            Console.WriteLine($"Event Title: {_eventTitle}");
            Console.WriteLine($"Event Description: {_eventDescription}");
            Console.WriteLine($"Event Date: {_eventDate}");
            Console.WriteLine($"Event Time: {_eventTime}");            
            Console.WriteLine($"Event Address: {_newLine}{_eventAddress.GetFullAddress()}");            



        }

         ///<summary>
        /// Displays the full details
        /// of the event
        ///</summary>
        public virtual void DisplayFullEventDetails()
        {

            Console.WriteLine("Full Event Details");
            Console.WriteLine(_dividingLine);
            Console.WriteLine(_newLine);
            Console.WriteLine(_newLine);
            Console.WriteLine($"Event Title: {_eventTitle}");
            Console.WriteLine($"Event Type: {GetEventType()}");            
            Console.WriteLine($"Event Description: {_eventDescription}");
            Console.WriteLine($"Event Date: {_eventDate}");
            Console.WriteLine($"Event Time: {_eventTime}");            
            Console.WriteLine($"Event Address: {_newLine}{_eventAddress.GetFullAddress()}");            



        }     

         ///<summary>
        /// Displays a shortened 
        /// list of the event details
        ///</summary>
        public virtual void DisplayShortEventDetails()
        {

            Console.WriteLine("Short Event Details");
            Console.WriteLine(_dividingLine);
            Console.WriteLine(_newLine);
            Console.WriteLine(_newLine);
            Console.WriteLine($"Event Title: {_eventTitle}");
            Console.WriteLine($"Event Type: {GetEventType()}");            
            Console.WriteLine($"Event Date: {_eventDate}");
         



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
            switch ((EVENTTYPE)_eventType)
            {
                case EVENTTYPE.Lecture:
                     return "Lecture";
                
                case EVENTTYPE.Outdoor:
                     return "Outdoor";

                case EVENTTYPE.Reception:
                     return "Reception";

                default:
                     return "Unknown";
            }

        }  

    }


}