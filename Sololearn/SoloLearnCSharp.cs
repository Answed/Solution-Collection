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

    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            int input = int.Parse(Console.ReadLine());

            try { Console.WriteLine(games[input]); }
            catch { Console.WriteLine("Invalid "); }
        }
    }

    namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            
            var sumOfEven = 0;

            foreach(var num in numbers){
                if(num%2 == 0)
                    sumOfEven += num;
            }

            Console.WriteLine(sumOfEven);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i = 0;  i < num.GetLength(0); i++)
            {
                for(int y = 0 ; y < num.GetLength(1); y++)
                {
                    Console.Write(num[i,y]);
                }
                Console.WriteLine();
            }  
        }
        public static void WriteWinner(string[][] olympiad)
        {
            int[] winner = new int[3];

            for (int i = 0; i < winner.Length; i++)
            {
                winner[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < olympiad.Length; i++)
            {
                Console.WriteLine(olympiad.Length);
                Console.WriteLine(olympiad[i][winner[i]-1]);
            }
        }
    }
    
}
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numbers.Max() + numbers.Min());
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            foreach (char c in notAllowedSymbols)
            {
                if (password.Contains(c))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
            
        }
    }
}

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            int count = 0;

            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    count++;
                    Console.WriteLine(word);
                }
            }

            if (count == 0)
                Console.WriteLine("No match");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            //this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            //complete the constructor
            Console.WriteLine("Winner is " + finalists [winner ]);
        }
        
        //create destructor => "Game Over"
        ~FinalRound(){
            Console.WriteLine("Game Over");
        }
        
    }
        class Program
    {
        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {
        
        public string depName;
        
        public static int depCount = 2;

        //declare static depCount member with value of 2

        //complete the constructor
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            depCount++;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;
        
        //create the constructor
        public Avg(double num1, double num2){
            this.num1 = num1;
            this.num2 = num2;
        }
        

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }
        }
    }
    class MusicGenres
    {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int indexer]{
            get{
                return genres[indexer];
            }
            set{
                genres[indexer] = value;
            }
        }
        
    }
        class Program
    {

        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        
        //your code goes here
        public static Score operator+(Score tm1, Score tm2){
            return new Score(tm1.round1Score + tm2.round1Score, tm1.round2Score + tm2.round2Score);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator

        public static DancerPoints operator+(DancerPoints dancer1, DancerPoints dancer2){
            var tempName = dancer1.name + " & " + dancer2.name;
            var tempPoints = dancer1.points + dancer2.points;
            return new DancerPoints(tempName, tempPoints);
        }
    }
    namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }
    }
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    //complete the Car class
    class Car : Vehicle
    {
        public string Model { get; set; }

        public void ShowModel(){
            Console.WriteLine("Model: " + Model);
        }
        
    }

        class Program
    {
        static void Main(string[] args)
        {
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account
    {
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }
        
        //complete the constructor
        public User(string accNumber, double balance)
        {
            this.AccNumber = accNumber;
            this.Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    
    /*derive the class from Unit class
    and override Attack() method*/
    class Musketeer : Unit
    {
        public override void Attack(){
            Console.WriteLine("Using musket!");
        }
    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician : Unit
    {
        public override void Attack(){
            Console.WriteLine("Using magic!");
        }
    }
}
}
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : Draw
    {
        public override void StartDraw(){
            Console.WriteLine("Using brush");
        }
    }

    //inherit this class from the class Draw
    class Spray : Draw
    {
            public override void StartDraw(){
            Console.WriteLine("Using spray");
        }

    }
}