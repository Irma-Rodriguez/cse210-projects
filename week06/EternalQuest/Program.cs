// I added a feature that allows the player to increase his level every 500 points, when the player levels up, the game displays a congratulations message.
using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}