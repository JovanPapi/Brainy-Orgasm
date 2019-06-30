using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    [Serializable]
    public class Users : IEquatable<Users>, IComparable<Users>
    {
        public string UserName { get; set; }
        public int Points { get; set; }
        public int LivesLeft { get; set; }
        public string TypeOfGame { get; set; }

        public Users(string UserName, string TypeOfGame)
        {
            this.UserName = UserName;
            this.Points = 0;
            LivesLeft = 3;
            this.TypeOfGame = TypeOfGame;
        }

        public void IncresePoints()
        {
            Points++;
        }
        public void DecreaseLive()
        {
            LivesLeft--;
        }
        public bool CheckLives()
        {
            return LivesLeft == 0;
        }

        public override string ToString()
        {
            return String.Format("{0}  -  {1}", this.UserName, this.Points);
        }

        public bool Equals(Users other)
        {
            return this.UserName == other.UserName;
        }

        public int CompareTo(Users other)
        {
            return this.Points - other.Points;
        }
    }
}
