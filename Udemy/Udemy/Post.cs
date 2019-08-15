using System;

namespace Udemy
{
    internal class Post
    {
        public string Title { private get; set; }
        public string Description { private get; set; }
        private readonly DateTime _createDate;
        public int Vote { get; private set; }


        public Post()
        {
            _createDate = DateTime.Now;
        }
        public string Publish
        {
            set
            {
                Title = value;
                Description = value;
                
                
            }

            get => "Title : "+ Title +"\nDesc : "+Description+"\nDate : "+_createDate;
        }

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
