using System;

class Sphinx
{
    
    static void Main()
    {
        Console.WriteLine("Riddles of the Sphinx");
        Console.WriteLine("Defeat the Sphinx and Proceed or GET EATEN!!!!");
        Console.WriteLine("NOTE: The answers to the riddles are only one word");

        Console.WriteLine("Type 'Go' to get started");
        string reply = Console.ReadLine();
        if (reply == "Go" || reply == "go")
        {
            FirstRiddle();
        }
        
    }

    static void FirstRiddle()
    {
        Console.WriteLine("Your First Riddle: I am born of water but when i return to water, i die. What am I?");
        string riddle1 = Console.ReadLine();

        if (riddle1 == "Ice" || riddle1 == "ice")
        {
            Console.WriteLine("Congrats, you defeated the sphinx");
            SecondRiddle();
        }
        else
        {
            Console.WriteLine("You just got EATEN!!!");
            Console.WriteLine("Why dont you try again");
            Main();
        }
        
    }

    static void SecondRiddle()
    {
        Console.WriteLine("Here comes the second one: What starts with an e but only has a single letter in it?");
        string riddle2 = Console.ReadLine();
        
        if (riddle2 == "Envelope" || riddle2 == "envelope")
        {
            Console.WriteLine("Congrats, you defeated the sphinx again");
        }
        else
        {
            Console.WriteLine("why dont you try again");
            SecondRiddle();
        }
    }
}