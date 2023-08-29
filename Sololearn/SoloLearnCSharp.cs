using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Welcome object with the same name
            Welcome welcome = new Welcome();
            
            welcome.WelcomeMessage();
        }
    }
    
    class Welcome
    {
        public void WelcomeMessage(){
            Console.WriteLine("Welcome to OOP");
        }
        
    }
}
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }
    
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            winrate = wins*100/games;
            Console.WriteLine((int)winrate);
        }
    }
}
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        //write a constructor here

        public Post()
        {
            Console.WriteLine("New Post");
        }


        public void ShowPost()
        {
            Console.WriteLine(text);
        }

    }