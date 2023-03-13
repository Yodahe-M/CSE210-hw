public class Observing : Activity
{
    public Observing()
    {
        SetName("Observig"); 
        SetDescription("This activity will help you observe objects by assigninh a color to focus on in yout surroundings. It can also shift your attention away from stress and onto other elements in your environment.");
    }

    public override void DoActivity()
    {
        List<string> colors = new List<string>(){
            "Black", "Blue", "White", "Gray", "Brown"
        };

        Random randomColor = new Random();
        int randomIndex = randomColor.Next(colors.Count);
        
        string pickColors = (colors [randomIndex]);
        Console.WriteLine($"Look around the room and find objects with the color {pickColors}");

        Console.Write("When you have found those objects press enter and list them");
        

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        SetFutureTime(futureTime);

        while (! CalculateTime())
        {

            Console.ReadLine();

        }


    }
}