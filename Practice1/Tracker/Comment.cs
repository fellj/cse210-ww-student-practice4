using System;

namespace Practice1.Tracker
{

    #region CLASS HEADER
     /********************************************************************************
     *********************************************************************************
     * Author: John Fell
     * Purpose: Class with attributes and methods for a video's comment 
     * Date: 11/29/22
     *********************************************************************************
     ********************************************************************************/
    #endregion

    public class Comment
    {

        private string _commentAuthor;                 // String variable for comment author

        private string _commentText;                   // String variable for the comment's content

        public Comment()
        {

            _commentAuthor = "Add a Comment Author";
            _commentText = "Add content for the comment";

        }

        ///<summary>
        /// Returns the comment's author
        /// as a string.
        ///</summary>
        public string GetCommentAuthor()
        {
            return _commentAuthor;
        }

        ///<summary>
        /// Sets the comment's author
        /// using a string value.
        ///</summary>
        public void SetCommentAuthor(string inputAuthor)
        {
            _commentAuthor = inputAuthor;
        }


        ///<summary>
        /// Returns the comment's content
        /// as a string.
        ///</summary>
        public string GetCommentContent()
        {
            return _commentText;
        }

        ///<summary>
        /// Sets the comment's content
        /// using a string value.
        ///</summary>
        public void SetCommentContent(string inputComment)
        {
            _commentText = inputComment;
        }        

    }



}