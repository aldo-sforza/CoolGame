namespace CoolGame.Models
{
    public class Wizard : Player
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public Wizard(Guid id) : base(id)
        {
        }

        /// <inheritdoc/>
        public override void Attack(Guid userId, int damage)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>

        public override void Defense(int shield)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Allows the wizard to study a spell
        /// </summary>
        public void StudySpell()
        {
        }
    }
}