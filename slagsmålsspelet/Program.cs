string playAgain = "yes";
while (playAgain == "yes"){

Random generator = new Random();

int hp1 = 100;
int hp2 = 100;



Console.WriteLine("Welcome to this fightsim, press enter to start the game");
Console.ReadLine();

Console.WriteLine("Player 1, what's your name?");
string name1 = Console.ReadLine();

Console.WriteLine("Player 2, what's your name?");
string name2 = Console.ReadLine();



Console.WriteLine(hp1 > 0 && hp2 > 0);

while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine("New Round");
    Console.WriteLine($"{name1} : {hp1} {name2} : {hp2}");

    int player1Damage = generator.Next(21);
    hp2 -= player1Damage;
    Console.WriteLine($"{name1} does {player1Damage} damage to {name2} , who now has {hp2} hp");

    int player2Damage = generator.Next(21);
    hp1 -= player2Damage;
    Console.WriteLine($"{name2} does {player2Damage} damage to {name1} , who now has {hp1} hp");

    Console.WriteLine("Press any button to go to the next round");
    Console.ReadKey();
    

}

Console.WriteLine("GAME OVER");
if (hp1 == 0 && hp2 == 0) {
    Console.WriteLine("THE GAME ENDED IN A DRAW");
}
else if(hp1 == 0){
    Console.WriteLine($"{name2} WON");
}
else{
    Console.WriteLine($"{name1} WON");
}

Console.WriteLine("Do you wanna play again?");
playAgain = Console.ReadLine();

}

Console.WriteLine("PRESS ANY BUTTON TO QUIT");

Console.ReadLine();








