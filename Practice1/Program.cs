
#region PROGRAM DESCRIPTION
/*

Abstraction with YouTube Videos

Description:
Description Url: https://byui-cse.github.io/cse210-ww-course/unit06/final-practice/

Scenario #

You have been hired by a company that does product awareness monitoring by tracking the placement of their products
in YouTube videos. They want you to write a program that can help them work with the tens of thousands of videos 
they have identified as well as the comments on them.

Program Specification #

Write a program to keep track of YouTube videos and comments left on them. As mentioned this could be part of 
a larger project to analyze them, but for this assignment, you will only need to worry about storing the information 
about a video and the comments.

Your program should have a class for a Video that has the responsibility to track the title, author, 
and length (in seconds) of the video. Each video also has responsibility to store a list of comments, 
nd should have a method to return the number of comments. A comment should be defined by the Comment 
class which has the responsibility for tracking both the name of the person who made the comment and 
the text of the comment.

Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, 
and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos 
n a list.

Then, have your program iterate through the list of videos and for each one, display the title, author, length, 
number of comments (from the method) and then list out all of the comments for that video. Repeat this display 
for each video in the list.




*/
#endregion

using System;
using Practice1.Tracker;
using Practice1.Directing;

namespace Practice1
{
    class Program
    {


        static void Main(string[] args)
        {

            // Create a director object
            // and use it to track
            // videos
            Director director = new Director();
            director.TrackVideos();

        }


        







    }
}
