using System;
using Practice3.Base;

namespace Practice3.Events
{
    class Lecture : Event
    {
        #region Class Level Variables

        

        private string _speakerName;

        private int _lectureHallCapacity;



        #endregion

        #region Constructor


        ///<summary>
        /// Constructor for the Lecture
        /// class. This class inherits
        /// from the Event base class.
        ///<param name="inputLectureTitle"> The title of the lecture</param>
        ///<param name="inputLectureDescription"> The description of the lecture</param> 
        ///<param name="inputLectureDate"> The date of the lecture</param>               
        ///<param name="inputLectureTime"> The time of the lecture</param>        
        ///<param name="inputLectureAddress"> The location of the lecture</param>        
        ///<param name="inputEventType"> The type of the event</param>        
        ///</summary>
        public Lecture(string inputLectureTitle, string inputLectureDescription, DateTime inputLectureDate, TimeOnly inputLectureTime, Address inputLectureAddress, Constants.EVENTTYPE inputLectureType) : 
            base(inputLectureTitle, inputLectureDescription, inputLectureDate, inputLectureTime, inputLectureAddress, Constants.EVENTTYPE.Lecture)
        {
            SetEventTitle(inputLectureTitle);
            SetEventDescription(inputLectureDescription);
            SetEventTime(inputLectureTime);
            SetEventAddress(inputLectureAddress);
            SetEventType(inputLectureType);
            
        }

        #endregion

        #region Methods

        #region Getters and Setters


        ///<summary>
        /// Get the lecture
        /// speaker
        ///</summary>
        public string GetLectureSpeaker()
        {
            return _speakerName;

        }

        ///<summary>
        /// Set the lecture
        /// speaker name
        ///<param name="inputLectureSpeaker"> The string representation of the lecture speaker name.</param>
        ///</summary>
        public void SetLectureSpeaker(string inputLectureSpeaker)
        {
            _speakerName = inputLectureSpeaker;
        }

        ///<summary>
        /// Get the lecture
        /// hall capacity
        ///</summary>
        public string GetLectureHallCapacity()
        {
            return _lectureHallCapacity.ToString();

        }

        ///<summary>
        /// Set the lecture
        /// hall capacity
        ///<param name="inputLectureHallCapacity"> The integer representation of the lecture hall capacity.</param>
        ///</summary>
        public void SetLectureHallCapacity(int inputLectureHallCapacity)
        {
            _lectureHallCapacity = inputLectureHallCapacity;
        }



        #endregion

        #region Display Lecture Messages

        ///<summary>
        /// Displays the full
        /// lecture details
        ///</summary>
        public override void DisplayFullEventDetails()
        {
            base.DisplayFullEventDetails();
            Console.WriteLine(Constants._dividingLine);
            Console.WriteLine($"Speaker Name: {GetLectureSpeaker()}");
            Console.WriteLine($"Lecture Capacity: {GetLectureHallCapacity()}");            

        }

        #endregion

        #endregion
    }
}