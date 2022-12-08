﻿using System;

namespace Practice3
{

    #region PROGRAM REQUIREMENTS

    /*
     
     
     Scenario #
     You have been hired by an event planning company. They help organize and market events throughout the world. 
     They need you to write a program to track each of these events and produce the marketing material to distribute 
     on social media. They typically handle a few main types of events:
     
        1. Lectures, which have a speaker and have a limited capacity.
        2. Receptions, which require people to RSVP, or register, beforehand.
        3. Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
        4. Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
     
     They would like the ability to generate three different messages:
     
        1. Standard details - Lists the title, description, date, time, and address.
        2. Full details - Lists all of the above, plus type of event and information specific to that event type. 
                          For lectures, this includes the speaker name and capacity. For receptions this includes 
                          an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        3. Short description - Lists the type of event, title, and the date.
     
     Program Specification #
     
     Write a program that has a base Event class along with derived classes for each type of event. 
     These classes should contain the necessary data and provide methods to return strings for each of the 
     messages the company desires.
     
     Remember that any data or methods that are common among all types of events should be in the base class.
     
     Once you have the classes in place, write a program that creates at least one event of each type and sets 
     all of their values. Then, for event event, call each of the methods to generate the marketing messages and 
     output their results to the screen.
     
     In addition, your program must:
     
     1. Use inheritance to avoid duplicating shared attributes and methods.
     2. Use an address class for the addresses.
     3. Follow the principles of encapsulation, making sure each member variable is private.
     
     
     
    */

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Practice 3.");
        }
    }
}
