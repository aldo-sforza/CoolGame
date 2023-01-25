using System.Text;

namespace CoolGame.Models
{
    /// <summary>
    /// This class represents a player in a game
    /// </summary>
    public abstract class Player 
    {
        #region fields

        /// <summary>
        /// player id
        /// </summary>
        /// <remarks>the readonly keyword means that the value of this field cannot be changed outside the constructor</remarks>
        private readonly Guid _id;

        #endregion fields

        #region constructors

        /// <summary>
        /// Constructor that forces the player id
        /// </summary>
        /// <param name="id"></param>
        public Player(Guid id)
        {
            _id = id;
        }

        #endregion constructors

        /// <summary>
        /// Gets the player id
        /// </summary>
        public Guid Id => _id;
        
        /// <summary>
        /// Gets the nickname of the player
        /// </summary>
        public string NickName { get; private set; }
        /// <summary>
        /// Gets the current health of the player
        /// </summary>
        public int Health { get; private set; }

        #region methods

        /// <summary>
        /// Initializes the player's health to maximum 
        /// </summary>
        public void SetIinitialHealth()
        {
            Health = 100;
        }

        /// <summary>
        /// Defines the attack of the player
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="damage"></param>
        public abstract void Attack(Guid userId, int damage);

        /// <summary>
        /// Defines the defense of the player
        /// </summary>
        /// <param name="shield"></param>
        public abstract void Defense(int shield);

        /// <summary>
        /// Updates the nick name of the player
        /// </summary>
        /// <param name="nickName">new nick name</param>
        /// <exception cref="ArgumentNullException">if <paramref name="nickName"/> is nul or empt</exception>
        public void UpdateNickName(string nickName)
        {
            if (string.IsNullOrWhiteSpace(nickName))
            {
                throw new ArgumentNullException(nameof(nickName));
            }
            if (nickName.Contains("z") || nickName.Contains("s"))
            {
                throw new ArgumentException("z or s is an invalid character", nameof(nickName));
            }
            NickName = nickName;
        }

        /// <summary>
        /// This is an override of object.Tostring() to return just the player id
        /// </summary>
        /// <returns>id in string format</returns>
        /// <remarks>If this method is not overridden it returns the class full name, e.g.: <see cref="CoolGame.Models.Player"/></remarks>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Id: {_id.ToString()}");
            stringBuilder.AppendLine($"Nick name: {NickName}");
            stringBuilder.AppendLine($"Health: {Health}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// This is an override of object.Equals(object? obj) to check simply the player id
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true if <paramref name="obj"/> is a <see cref="CoolGame.Models.Player"/> and has the same id of this object</returns>
        public override bool Equals(object? obj)
        {
            var player = (Player)obj;

            return this._id == player._id;
        }

        #endregion methods
    }
}