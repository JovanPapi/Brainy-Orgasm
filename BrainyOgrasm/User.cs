using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    [Serializable]
    public enum Mode
    {
        Universe,
        Scientists,
        VisualStudio
    }

    [Serializable]
    public class User : IEquatable<User>, IComparable<User>
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int LivesLeft { get; set; }

        public Collector Collector { get; set; }
        public Mode TypeOfGame { get; set; }

        public User(string UserName, Mode TypeOfGame)
        {
            this.TypeOfGame = TypeOfGame;
            this.Name = UserName;
            this.Points = 0;
            LivesLeft = 3;
        }

        public bool CheckLives()
        {
            return LivesLeft == 0;
        }

        public override string ToString()
        {
            return String.Format("{0}  -  {1}", this.Name, this.Points);
        }

        public bool Equals(User other)
        {
            return this.Name == other.Name;
        }

        public int CompareTo(User other)
        {
            return this.Points - other.Points;
        }

        public void Move(Point newLocation)
        {
            Collector.Move(newLocation);
        }

        public void Draw(Graphics g)
        {
            Collector.Draw(g);
        }
    }
}
