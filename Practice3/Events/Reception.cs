using System;
using Practice3.Base;

namespace Practice3.Events
{
    class Reception : Event
    {

        #region Constructor


        ///<summary>
        /// Constructor for the Reception
        /// class. This class inherits
        /// from the Event base class.
        ///<param name="inputReceptionTitle"> The title of the reception</param>
        ///<param name="inputReceptionDescription"> The description of the reception</param> 
        ///<param name="inputReceptionDate"> The date of the reception</param>               
        ///<param name="inputReceptionTime"> The time of the reception</param>        
        ///<param name="inputReceptionAddress"> The location of the reception</param>        
        ///<param name="inputEventType"> The type of the event</param>        
        ///</summary>
        public Reception(string inputReceptionTitle, string inputReceptionDescription, DateTime inputReceptionDate, TimeOnly inputReceptionTime, Address inputReceptionAddress, Constants.EVENTTYPE inputReceptionType) : 
            base(inputReceptionTitle, inputReceptionDescription, inputReceptionDate, inputReceptionTime, inputReceptionAddress, Constants.EVENTTYPE.Reception)
        {
            SetEventTitle(inputReceptionTitle);
            SetEventDescription(inputReceptionDescription);
            SetEventTime(inputReceptionTime);
            SetEventAddress(inputReceptionAddress);
            SetEventType(inputReceptionType);
            
        }

        #endregion

        #region Methods

        #region Getters and Setters


        ///<summary>
        /// Get the email
        /// to RSVP
        ///</summary>
        public string GetRegistrationEmailAddress()
        {
            return Constants._registrationEmailAddress;

        }

        
        #endregion

        #region Display Reception Messages

        ///<summary>
        /// Displays the full
        /// reception details
        ///</summary>
        public override void DisplayFullEventDetails()
        {
            base.DisplayFullEventDetails();
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine($"Please RSVP at: {GetRegistrationEmailAddress()}");


        }

        #endregion

        #endregion
    }
}