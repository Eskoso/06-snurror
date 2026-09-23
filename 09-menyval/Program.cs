while(true)
{
    Console.WriteLine("\n--- MENY ---");
    Console.WriteLine("1. Visa profil");
    Console.WriteLine("2. Ändra inställningar");
    Console.WriteLine("3. Avsluta");
    Console.WriteLine("Ange ett alternativ: ");

    int val = Convert.ToInt32(Console.ReadLine());
    switch (val)
    {
        case 1:
            Console.WriteLine("Du valde att visa profilen.");
            break;
        case 2:
            Console.WriteLine("Du valde att ändra inställningarna.");
            break;
        case 3:
            Console.WriteLine("Avslutar programmet...");
            return; // Avslutar programmet
        default:
            Console.WriteLine("Ogiltigt val. Försök igen.");
            break;
    }
}