
using System;

abstract class Gato
{
    public string Color { get; set; }
    public string TipoPelo { get; set; }
    public string ColorOjos { get; set; }

    public static int ContadorGatos = 0;

    public Gato(string color, string tipoPelo, string colorOjos)
    {
        Color = color;
        TipoPelo = tipoPelo;
        ColorOjos = colorOjos;
        ContadorGatos++;
        Console.WriteLine($"Se ha creado un gato. Total de gatos: {ContadorGatos}");
    }

    public abstract void Comer();
    public abstract void Maullar();
    public abstract void Dormir();
}

class Siames : Gato
{
    public Siames(string color, string tipoPelo, string colorOjos)
        : base(color, tipoPelo, colorOjos) { }

    public override void Comer() => Console.WriteLine("El siamés está comiendo elegantemente.");
    public override void Maullar() => Console.WriteLine("El siamés maúlla suavemente.");
    public override void Dormir() => Console.WriteLine("El siamés duerme en una posición muy fina.");
}

class MaineCoon : Gato
{
    public MaineCoon(string color, string tipoPelo, string colorOjos)
        : base(color, tipoPelo, colorOjos) { }

    public override void Comer() => Console.WriteLine("El Maine Coon come con mucho apetito.");
    public override void Maullar() => Console.WriteLine("El Maine Coon tiene un maullido grave.");
    public override void Dormir() => Console.WriteLine("El Maine Coon duerme profundamente.");
}

class Persa : Gato
{
    public Persa(string color, string tipoPelo, string colorOjos)
        : base(color, tipoPelo, colorOjos) { }

    public override void Comer() => Console.WriteLine("El persa come lentamente.");
    public override void Maullar() => Console.WriteLine("El persa maúlla con poca energía.");
    public override void Dormir() => Console.WriteLine("El persa duerme casi todo el día.");
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Creación de gatos ---\n");

        Siames gato1 = new Siames("Crema", "Corto", "Azules");
        gato1.Comer();
        gato1.Maullar();
        gato1.Dormir();

        Console.WriteLine();

        MaineCoon gato2 = new MaineCoon("Marrón", "Largo", "Verdes");
        gato2.Comer();
        gato2.Maullar();
        gato2.Dormir();

        Console.WriteLine();

        Persa gato3 = new Persa("Blanco", "Largo", "Ambar");
        gato3.Comer();
        gato3.Maullar();
        gato3.Dormir();

        Console.WriteLine();
        Console.WriteLine($"Total de gatos creados: {Gato.ContadorGatos}");
    }
}
