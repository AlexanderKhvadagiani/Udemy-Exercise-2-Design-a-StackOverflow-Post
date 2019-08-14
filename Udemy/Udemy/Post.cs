using System;

namespace Udemy
{
    internal class Post
    {
        public string Title { private get; set; }
        public string Description { private get; set; }
        private DateTime CreateDate { get; set; }
        private int Vote { get; set; }

        public Post()
        {
            CreateDate = DateTime.Now;
        }

        public string Publish
        {
            set
            {
                Title = value;
                Description = value;
            }

            get => "Title : " + Title + "\nDesc : " + Description + "\nDate : " + CreateDate;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }

        public int ShowWote => Vote;
    }
}