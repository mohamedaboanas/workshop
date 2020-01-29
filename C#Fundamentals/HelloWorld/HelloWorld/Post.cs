using System;
using System.Security.Permissions;

namespace HelloWorld
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public readonly DateTime CreationDateTime = DateTime.Now;
        private int _vote ;


        public int DisplayVotes()
        {
            return _vote;
        }
       
        public void Upvoting()
        {
            _vote++;
        }

        public void Downvoting()
        {
            _vote--;
        }

    }
}