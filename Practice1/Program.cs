
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

namespace Practice1
{
    class Program
    {

        // Create four new videos
        private Video video1, video2, video3, video4 = new Video();


        static void Main(string[] args)
        {

  
                                             

            Console.WriteLine("Hello World! This is Practice 1.");
        }

        ///<summary>
        /// Adds comments after
        /// populating individual comment
        /// attributes.
        ///</summary>
        public void AddVideoComments()
        {

            // Create 4 comments on each video
            // *************************************************************

            // Video 1 Comments
            Comment firstCommentVideo1 = new Comment();
            firstCommentVideo1.SetCommentAuthor("Judy");
            firstCommentVideo1.SetCommentContent("What type of flour do you reccomend for gluten allergies?");
            Comment secondCommentVideo1 = new Comment();
            secondCommentVideo1.SetCommentAuthor("Ronald");
            secondCommentVideo1.SetCommentContent("I like the way your recipe tastes!");
            Comment thirdCommentVideo1 = new Comment();
            thirdCommentVideo1.SetCommentAuthor("Wanda");
            thirdCommentVideo1.SetCommentContent("I would add an additional teaspoon of vanilla.");
            Comment fourthCommentVideo1 = new Comment();
            fourthCommentVideo1.SetCommentAuthor("Bubbly Baker");
            fourthCommentVideo1.SetCommentContent("If you want to make this a pound cake, use one less egg and add half a cup of milk.");            
            video1.AddComment(firstCommentVideo1);
            video1.AddComment(secondCommentVideo1);
            video1.AddComment(thirdCommentVideo1);
            video1.AddComment(fourthCommentVideo1);  

            // Video 2 Comments
            Comment firstCommentVideo2 = new Comment();
            firstCommentVideo2.SetCommentAuthor("Avery");
            firstCommentVideo2.SetCommentContent("Nice manuevers along the curb!");
            Comment secondCommentVideo2 = new Comment();
            secondCommentVideo2.SetCommentAuthor("Hanna");
            secondCommentVideo2.SetCommentContent("What kind of wheels do you have?");
            Comment thirdCommentVideo2 = new Comment();
            thirdCommentVideo2.SetCommentAuthor("Okinna");
            thirdCommentVideo2.SetCommentContent("I skated down this hill, but it took me an extra 5 minutes because I fell once.");
            Comment fourthCommentVideo2 = new Comment();
            fourthCommentVideo2.SetCommentAuthor("Shawn the Sheep");
            fourthCommentVideo2.SetCommentContent("I could have done better.");            
            video1.AddComment(firstCommentVideo2);
            video1.AddComment(secondCommentVideo2);
            video1.AddComment(thirdCommentVideo2);
            video1.AddComment(fourthCommentVideo2);               

            // Video 3 Comments
            Comment firstCommentVideo3 = new Comment();
            firstCommentVideo3.SetCommentAuthor("Lana");
            firstCommentVideo3.SetCommentContent("What a wonderful performance!");
            Comment secondCommentVideo3 = new Comment();
            secondCommentVideo3.SetCommentAuthor("Mama");
            secondCommentVideo3.SetCommentContent("I cried and cried!");
            Comment thirdCommentVideo3 = new Comment();
            thirdCommentVideo3.SetCommentAuthor("Daddy Doo");
            thirdCommentVideo3.SetCommentContent("This was my first video of a ballet. Sorry for the fidgety camera.");
            Comment fourthCommentVideo3 = new Comment();
            fourthCommentVideo3.SetCommentAuthor("Ozma");
            fourthCommentVideo3.SetCommentContent("A treasure!");            
            video1.AddComment(firstCommentVideo3);
            video1.AddComment(secondCommentVideo3);
            video1.AddComment(thirdCommentVideo3);
            video1.AddComment(fourthCommentVideo3);

            // Video 4 Comments
            Comment firstCommentVideo4 = new Comment();
            firstCommentVideo4.SetCommentAuthor("Judy");
            firstCommentVideo4.SetCommentContent("What type of flour do you reccomend for gluten allergies?");
            Comment secondCommentVideo4 = new Comment();
            secondCommentVideo4.SetCommentAuthor("Ronald");
            secondCommentVideo4.SetCommentContent("I like the way your recipe tastes!");
            Comment thirdCommentVideo4 = new Comment();
            thirdCommentVideo4.SetCommentAuthor("Wanda");
            thirdCommentVideo4.SetCommentContent("I would add an additional teaspoon of vanilla.");
            Comment fourthCommentVideo4 = new Comment();
            fourthCommentVideo4.SetCommentAuthor("Bubbly Baker");
            fourthCommentVideo4.SetCommentContent("If you want to make this a pound cake, use one less egg and add half a cup of milk.");            
            video1.AddComment(firstCommentVideo4);
            video1.AddComment(secondCommentVideo4);
            video1.AddComment(thirdCommentVideo4);
            video1.AddComment(fourthCommentVideo4);            

        }

        ///<summary>
        /// Adds the values for author,
        /// title, and length in seconds
        /// for each video.
        ///</summary>
        public void AddVideoDetails()
        {


                      // Create 4 videos
            // ***********************************************************
            
            // Video 1: How to Bake a Cake
            video1.SetAuthor("Little Debbie");
            video1.SetTitle("How to Bake a Snack Cake");
            video1.SetVideoLengthInSeconds(3600);

            // Video 2: Riding down the hill on a skateboard
            video2.SetAuthor("Tony Hawk");
            video2.SetTitle("San Fransisco Downhill");
            video2.SetVideoLengthInSeconds(270);

            // Video 3: Child's ballet performance
            video3.SetAuthor("Daddy Doo");
            video3.SetTitle("Dance of the Sugar Plum Fairies");
            video3.SetVideoLengthInSeconds(1800);

            // Video 4: Writing a cover letter for a job interview
            video4.SetAuthor("Rhonda Reviews");
            video4.SetTitle("Writing Resume Cover Letters for Dummies");
            video4.SetVideoLengthInSeconds(300);


        }
    }
}
