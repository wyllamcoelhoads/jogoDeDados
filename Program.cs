﻿Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll1 == roll3)){
    
    if ((roll1 == roll2 && roll2 == roll3)){
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You relled double! +2 bonus to total!");
        total += 2;
    }
} 

if(total >= 15) {
    Console.WriteLine($"You win a new car! with: {total}");
}
else if(total >= 10) {
    Console.WriteLine($"You win a new laptop! with: {total}");
}
else if(total == 7) {
    Console.WriteLine($"You win a trip for two! with: {total}");
}
else {
    Console.WriteLine($"You win a kitten! with: {total}");
}