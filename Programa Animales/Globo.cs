using System;

public class Globo: Peces
{
    public string ColorPez { get; set; }

    public void Color()
    {
        Console.WriteLine("Amarillo con manchas");
    }

    public void Inflarse()
    {
        Console.WriteLine("Inflarse");
    }
}