using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Something new", "Something newSomething newSomething new");

            var blog = post.Publish;
            post.UpVote();
            post.UpVote();
            post.DownVote();


            Console.WriteLine(blog);
            Console.WriteLine(post.Vote);
        }
    }
}
