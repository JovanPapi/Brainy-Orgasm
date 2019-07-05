using System;
using System.Drawing;

namespace BrainyOgrasm
{
    /// <summary>
    /// Enum that represents the type of Game that is being played
    /// </summary>
    [Serializable]
    public enum Mode
    {
        Universe,
        Scientists,
        VisualStudio
    }

    /// <summary>
    /// Class that represents a user that is playing the game
    /// </summary>
    [Serializable]
    public class User : IEquatable<User>, IComparable<User>
    {
        /// <summary>
        /// Gets or sets the name of the User
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the points gathered so far by the User
        /// </summary>
        public int Points { get; set; }
        /// <summary>
        /// Gets ot sets the lives that the User has
        /// </summary>
        public int LivesLeft { get; set; }
        /// <summary>
        /// The collector for the User
        /// </summary>
        public Collector Collector { get; set; }
        /// <summary>
        /// The Mode that the User is playing
        /// </summary>
        public Mode TypeOfGame { get; set; }

        /// <summary>
        /// Constuctor for User
        /// </summary>
        /// <param name="UserName">The name of the User</param>
        /// <param name="TypeOfGame">The Mode he is playing</param>
        public User(string UserName, Mode TypeOfGame)
        {
            this.TypeOfGame = TypeOfGame;
            this.Name = UserName;
            this.Points = 0;
            LivesLeft = 3;
        }

        /// <summary>
        /// Checks if the User has any lives left
        /// </summary>
        /// <returns>True, if the User has no lives left</returns>
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
            return -(this.Points - other.Points);
        }

        /// <summary>
        /// Moves the Collector of the User
        /// </summary>
        /// <param name="newLocation">The new location of the Collector</param>
        public void Move(Point newLocation)
        {
            Collector.Move(newLocation);
        }

        /// <summary>
        /// Draws the Collector
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void Draw(Graphics g)
        {
            Collector.Draw(g);
        }
    }
}
