using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post {Title = "Something new", Description = "Something new Something newSomething newSomething new"};
           
            var blog = post.Publish;
            post.UpVote();
            post.UpVote();
            post.DownVote();

            var vote = post.ShowWote;

            Console.WriteLine(blog);
            Console.WriteLine(vote);
        }
    }
}