using System;

namespace Udemy
{
    public class Post
    {
        public string Title { get; }

        public string Description { get; }

        public DateTime CreateDate { get; }

        public int Vote { get; private set; }


        public Post(string title, string desription)
        {
            Title = title;
            Description = desription;
            CreateDate = DateTime.Now;
        }

        public string Publish => "Title : " + Title + "\nDesc : " + Description + "\nDate : " + CreateDate;

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }
    }
}
