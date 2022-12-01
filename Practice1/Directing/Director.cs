using System;
using Practice1.Tracker;

namespace  Practice1.Directing
{

    public class Director
    {

        private List<Video> _videos = new List<Video>();

        // Create 4 videos
        // ***********************************************************
       public Director()
        {


        }



        ///<summary>
        ///Add four new videos
        ///to the video list.
        ///</summary>
        public void CreateVideos()
        {

            // Add four blank videos
            // to a video list
            for (int i = 0; i < 4; i++)
            {
                Video _video = new Video();

                _videos.Add(_video);

            }


        }

        ///<summary>
        /// Adds the values for author,
        /// title, and length in seconds
        /// for each video. Execute
        /// this method before
        /// the AddVideoComments() method.
        ///</summary>
        public void AddVideoDetails()
        {
            foreach (Video video in _videos)

                if (_videos.IndexOf(video) == 0)
                {
                    // Video 1: How to Bake a Cake
                    video.SetAuthor("Little Debbie");
                    video.SetTitle("How to Bake a Snack Cake");
                    video.SetVideoLengthInSeconds(3600);
                }
                else if (_videos.IndexOf(video) == 1)
                {
                    // Video 2: Riding down the hill on a skateboard
                    video.SetAuthor("Tony Hawk");
                    video.SetTitle("San Fransisco Downhill");
                    video.SetVideoLengthInSeconds(270);                    

                }
                else if (_videos.IndexOf(video) == 2)
                {

                    // Video 3: Child's ballet performance
                    video.SetAuthor("Daddy Doo");
                    video.SetTitle("Dance of the Sugar Plum Fairies");
                    video.SetVideoLengthInSeconds(1800);


                }
                else if (_videos.IndexOf(video) == 3)
                {

                    // Video 4: Writing a cover letter for a job interview
                    video.SetAuthor("Rhonda Reviews");
                    video.SetTitle("Writing Resume Cover Letters for Dummies");
                    video.SetVideoLengthInSeconds(300);

                }
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

            foreach (Video video in _videos)
            {

                // Create comment objects
                Comment comment1 = new Comment();
                Comment comment2 = new Comment();
                Comment comment3 = new Comment();
                Comment comment4 = new Comment();


                if (_videos.IndexOf(video) == 0)
                {

                    // Video 1 Comments
                    comment1.SetCommentAuthor("Judy");
                    comment1.SetCommentContent("What type of flour do you reccomend for gluten allergies?");
                    comment2.SetCommentAuthor("Ronald");
                    comment2.SetCommentContent("I like the way your recipe tastes!");
                    comment3.SetCommentAuthor("Wanda");
                    comment3.SetCommentContent("I would add an additional teaspoon of vanilla.");
                    comment4.SetCommentAuthor("Bubbly Baker");
                    comment4.SetCommentContent("If you want to make this a pound cake, use one less egg and add half a cup of milk.");            
                    video.AddComment(comment1);
                    video.AddComment(comment2);
                    video.AddComment(comment3);
                    video.AddComment(comment4);                     

                }
                else if (_videos.IndexOf(video) == 1)
                {

                    // Video 2 Comments
                    
                    comment1.SetCommentAuthor("Avery");
                    comment1.SetCommentContent("Nice manuevers along the curb!");
                    comment2.SetCommentAuthor("Hanna");
                    comment2.SetCommentContent("What kind of wheels do you have?");
                    comment3.SetCommentAuthor("Okinna");
                    comment3.SetCommentContent("I skated down this hill, but it took me an extra 5 minutes because I fell once.");
                    comment4.SetCommentAuthor("Shawn the Sheep");
                    comment4.SetCommentContent("I could have done better.");            
                    video.AddComment(comment1);
                    video.AddComment(comment2);
                    video.AddComment(comment3);
                    video.AddComment(comment4);                       

                }
                else if (_videos.IndexOf(video) == 2)
                {

                    // Video 3 Comments
                    
                    comment1.SetCommentAuthor("Lana");
                    comment1.SetCommentContent("What a wonderful performance!");
                    comment2.SetCommentAuthor("Mama");
                    comment2.SetCommentContent("I cried and cried!");
                    comment3.SetCommentAuthor("Daddy Doo");
                    comment3.SetCommentContent("This was my first video of a ballet. Sorry for the fidgety camera.");
                    comment4.SetCommentAuthor("Ozma");
                    comment4.SetCommentContent("A treasure!");  
                    video.AddComment(comment1);
                    video.AddComment(comment2);
                    video.AddComment(comment3);
                    video.AddComment(comment4);                                           

                }
                else if (_videos.IndexOf(video) == 3)
                {

                    // Video 4 Comments
                    comment1.SetCommentAuthor("Walter");
                    comment1.SetCommentContent("What should we include about our high school education?");
                    comment2.SetCommentAuthor("Gisela");
                    comment2.SetCommentContent("I talked about my study abroad in my cover letter and it made a big impact.");
                    comment3.SetCommentAuthor("Xian");
                    comment3.SetCommentContent("What should I include if I am seeking an internship?");
                    comment4.SetCommentAuthor("Shawnee");
                    comment4.SetCommentContent("Whenever you cite research articles, make sure to include the reference details in the letter.");  
                    video.AddComment(comment1);
                    video.AddComment(comment2);
                    video.AddComment(comment3);
                    video.AddComment(comment4);  

                }
                
            }


        }    

        ///<summary>
        /// Displays all the details
        /// and comments for each
        /// video in the list.
        ///</summary>
        public void DisplayAllVideoDetails()
        {
            foreach (Video video in _videos)
            {

                video.DisplayVideoDetails();
                video.DisplayVideoComments();
                
            }

        }

        ///<summary>
        /// Performs all of the necessary
        /// tasks for creating, detailing,
        /// and displaying video and comment
        /// details.
        ///</summary>
        public void TrackVideos()
        {
            CreateVideos();
            AddVideoDetails();
            AddVideoComments();
            DisplayAllVideoDetails();
        }



    }

}


