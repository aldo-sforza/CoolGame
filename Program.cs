using CoolGame.Models;
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Hello, class!");

var player1 = new Wizard(Guid.NewGuid());
Player player2= new Wizard(Guid.NewGuid());
var player3= new Wizard(Guid.NewGuid());

player1.SetIinitialHealth();
//player2.Attack(player1.Id, 3);

var dices = GameDiceThrower.Throw(2, 6);

try
{
    player1.UpdateNickName("uto");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentException ex)
{ 
    Console.WriteLine(ex.Message); 
}

Console.WriteLine(player1);

