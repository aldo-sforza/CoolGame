namespace CoolGame.Models
{
    public static class GameDiceThrower
    {
        /// <summary>
        /// Throws a number of dice equals to <paramref name="numberOfDice"/> with dice faces equals to <paramref name="numberOfDiceFaces"/>
        /// </summary>
        /// <param name="numberOfDice"></param>
        /// <param name="numberOfDiceFaces"></param>
        /// <returns>the result of dice</returns>
        public static IEnumerable<int> Throw(int numberOfDice,
                                             int numberOfDiceFaces)
        {
            var dices = new List<int>();
            var random = new Random();
            
            for (int i = 0; i < numberOfDice; i++)
            {
                dices.Add(random.Next(1, numberOfDiceFaces));
            }

            return dices;
        }
    }
}