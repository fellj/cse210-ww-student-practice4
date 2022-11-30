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

using System;
using Practice1.Tracker;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create 4 videos
            // ***********************************************************
            
            // Video 1: How to Bake a Cake
            Video video1 = new Video();
            video1.SetAuthor("Little Debbie");
            video1.SetTitle("How to Bake a Snack Cake");
            video1.SetVideoLengthInSeconds(3600);

            // Video 2: Riding down the hill on a skateboard
            Video video2 = new Video();
            video2.SetAuthor("Tony Hawk");
            video2.SetTitle("San Fransisco Downhill");
            video2.SetVideoLengthInSeconds(270);

            // Video 3: Child's ballet performance
            Video video3 = new Video();
            video3.SetAuthor("Daddy Doo");
            video3.SetTitle("Dance of the Sugar Plum Fairies");
            video3.SetVideoLengthInSeconds(1800);


            // Video 4: Writing a cover letter for a job interview
            Video video4 = new Video();
            video4.SetAuthor("Rhonda Reviews");
            video4.SetTitle("Writing Resume Cover Letters for Dummies");
            video4.SetVideoLengthInSeconds(300);

            // Create 4 comments on each video
            // *************************************************************

            // Video 1 Comments
            Comment firstComment = new Comment();
            firstComment.SetCommentAuthor("Judy");
            firstComment.SetCommentContent("What type of flour do you reccomend for gluten allergies?");
            Comment secondComment = new Comment();
            secondComment.SetCommentAuthor("Ronald");
            secondComment.SetCommentContent("I like the way your recipe tastes!");
            Comment thirdComment = new Comment();
            thirdComment.SetCommentAuthor("Wanda");
            thirdComment.SetCommentContent("I would add an additional teaspoon of vanilla.");
            Comment fourthComment = new Comment();
            fourthComment.SetCommentAuthor("Bubbly Baker");
            fourthComment.SetCommentContent("If you want to make this a pound cake, use one less egg and add half a cup of milk.");            
            video1.AddComment(firstComment);
            video1.AddComment(secondComment);
            video1.AddComment(thirdComment);
            video1.AddComment(fourthComment);                                                

            Console.WriteLine("Hello World! This is Practice 1.");
        }
    }
}
