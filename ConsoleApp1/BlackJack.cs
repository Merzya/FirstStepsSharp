// See https://aka.ms/new-console-template for more information

namespace consolesapp
{
    public class BlackJack
    {
       public void PlayGame()
        {
            User user1 = new You("Merzya");
           
            Comp user2 = new Comp("Comp");
           

            Console.WriteLine(user1.GetInfo());
            Console.WriteLine(user2.GetInfo());
            Console.WriteLine(user2.GetName() +" "+ user1.GetName());
        }
    }

    public abstract class User
    {
      
        public User(string name)
        {
            Name = name;
        }
        public virtual string GetName() { return Name; }
        public string Name { get; set; }
        public int Score { get; set; }
        protected abstract string GetScore();
        public string GetInfo()
        {
            return Name + " " + GetScore();
        }
    }
    internal class You : User
    {
        public You(string name) : base(name)
        {
        }

        public string getInfo()
        {
            return GetScore().ToString();
        }

        protected override string GetScore()
        {
            return "Твій рахунок: " + Score;
        }

        public override string GetName()
        {
            return "гравець " + base.GetName();
        }
    }
    internal class Comp : User
    {
        public Comp(string name) : base(name)
        {
        }

        protected override string GetScore()
        {
            string strScore = Score.ToString();
            return "Рахунок компа: " + strScore;
        }
    }


}


