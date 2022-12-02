using System;

namespace Practice1.Tracker
{

    #region CLASS HEADER

     /********************************************************************************
     *********************************************************************************
     * Author: John Fell
     * Purpose: Class with attributes and methods for a video 
     * Date: 11/29/22
     *********************************************************************************
     ********************************************************************************/

    #endregion
   
    public class Video
    {

        private List<Comment> _comments = new List<Comment>();                        // List of Video comments

        private string _title;                                                        // String variable for Video title                     

        private string _author;                                                       // String variable for Video author                     

        private int _videoLengthInSeconds;                                            // Integer variable for Video length (in seconds)

        private static string _videoLine = "*******************************";         // String variable for visual video separator

        private static string _commentLine = "---------------------";                 // String variable for visual comment separator

        private static string _spaceBuffer = "        ";                              // String variable for spaces before comment details


        public Video()
        {

            _title = "Add a Video Title";
            _author = "Add a Video Author";
            _videoLengthInSeconds = 0;


        }

        ///<summary>
        /// Returns the video's title as a string.
        ///</summary>
        public string GetTitle()
        {
            return _title;

        }

        ///<summary>
        /// Sets the video's title 
        /// using a string value.
        ///</summary>
        public void SetTitle(string inputTitle)
        {
            _title = inputTitle;

        }


        ///<summary>
        /// Returns the video's author as a string.
        ///</summary>
        public string GetAuthor()
        {
            return _author;
        }


        ///<summary>
        /// Sets the video's author 
        /// using a string value.
        ///</summary>
        public void SetAuthor(string inputAuthor)
        {
            _author = inputAuthor;
        }        

        ///<summary>
        /// Returns the video's length in seconds as an integer.
        ///</summary>
        public int GetVideoLengthInSeconds()
        {
            return _videoLengthInSeconds;
        }

        ///<summary>
        /// Sets the video's length in seconds 
        /// using an integer value.
        ///</summary>
        public void SetVideoLengthInSeconds(int inputVideoLength)
        {
            _videoLengthInSeconds = inputVideoLength;
        }


        ///<summary>
        /// Add a comment to the video's list of comments.
        ///<param name="inputComment"> A comment object.</param>
        ///</summary>
        public void AddComment(Comment inputComment)
        {
            _comments.Add(inputComment);
        }

        ///<summary>
        /// Returns the number of comments
        /// for the video as an integer.
        ///</summary>
        public int ReturnNumberOfComments()
        {
            return _comments.Count;
        }

        ///<summary>
        /// Displays the video title,
        /// author and length in seconds.
        ///</summary>
        public void DisplayVideoDetails()
        {
            Console.WriteLine(_videoLine);
            Console.WriteLine($"Video Title: {_title}");
            Console.WriteLine($"Video Author: {_author}");
            Console.WriteLine($"Video Length (In Seconds): {_videoLengthInSeconds}");
            Console.WriteLine($"Total Comments: {ReturnNumberOfComments()}");
            Console.WriteLine("");

        }

        ///<summary>
        /// Displays the video's comments 
        /// including author and comment text.
        ///</summary>
        public void DisplayVideoComments()
        {
            foreach (Comment comment in _comments)
            {
                Console.WriteLine(_commentLine);
                Console.WriteLine($"{_spaceBuffer} Comment Author: {comment.GetCommentAuthor()}");
                Console.WriteLine($"{_spaceBuffer} Comment: {comment.GetCommentContent()}");
                Console.WriteLine("");                
                
            }
        }


    }
    

    

}