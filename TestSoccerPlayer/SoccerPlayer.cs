using System;
using static System.Console;
class TestSoccerPlayer
{
    static void Main()
    {
        SoccerPlayer player = new SoccerPlayer();
        Write("Enter the Soccer Player's name >> ");
        player.Name = ReadLine();
        Write("Enter the Soccer Player's jersey number >> ");
        player.Number = Convert.ToInt32(ReadLine());
        Write("Enter the Soccer Player's goals >> ");
        player.Goals = Convert.ToInt32(ReadLine());
        Write("Enter the Soccer Player's assists >> ");
        player.Assists = Convert.ToInt32(ReadLine());
        player.CalPoints();

        WriteLine("\n\nThe Player is {0}. Jersey number is #{1}.\nGoals: 
        {2}. Assists: {3}.\nTotal points earned: {4}\n", player.Name, 
        player.Number, player.Goals, player.Assists, player.Points);
    }
}

class SoccerPlayer
{
    public string Name;
    public int Number;
    public int Goals;
    public int Assists;
    public int Points;

    public void CalPoints()
    {
        Points = (8*Goals) + (2*Assists);
    }
}
