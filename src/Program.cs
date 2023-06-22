Display.DisplayText("Hello! How are you today?");

public static class Display
{
    public static void DisplayText(string text)
    {
        Console.WriteLine(text);
        Console.ReadLine();
    }
}