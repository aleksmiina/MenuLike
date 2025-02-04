/*Objectives:

• Define an enumeration for the state of the chest.
• Make a variable whose type is this new enumeration.
• Write code to allow you to manipulate the chest with the lock, unlock, open, and close
    commands, but ensure that you don’t transition between states that don’t support it.
• Loop forever, asking for the next command.

/*

/*
The chest is locked. What do you want to do? unlock
The chest is unlocked. What do you want to do? open
The chest is open. What do you want to do? close
The chest is unlocked. What do you want to do?

*/






ChestState currentChest = ChestState.Locked;

bool gameRunning = true;

while (gameRunning)
{
    
    Console.WriteLine($"The chest is currently {currentChest}. What would you like to do with it?");

    string? playerInput = Console.ReadLine();

    switch (playerInput)
    {
        case "exit":
            gameRunning = false;
            break;
        case "unlock":
            if(currentChest == ChestState.Locked)
            {
                currentChest = ChestState.Closed;
            }
            else 
            {    
                Console.WriteLine($"The chest is {currentChest}");
            }
            break;
        case "open":
            if(currentChest == ChestState.Closed)
            {
                currentChest = ChestState.Open;
            }
            else
            {
                Console.WriteLine($"The chest is {currentChest}");
            }
            break;
        case "close":
            if(currentChest == ChestState.Open)
            {
                currentChest = ChestState.Closed;
            }
            else
            {
                Console.WriteLine($"The chest is {currentChest}");
            }
            break;
        case "lock":
            if(currentChest == ChestState.Closed)
            {
                currentChest = ChestState.Locked;
            }
            else
            {
                Console.WriteLine($"The chest is {currentChest}");
            }
            break;     

    }
 
}

enum ChestState
{
    Open,
    Closed,
    Locked,
    Unlocked
    
}
