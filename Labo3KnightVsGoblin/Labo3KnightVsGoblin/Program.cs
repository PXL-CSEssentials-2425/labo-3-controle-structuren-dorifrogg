Random rng = new Random();
string input;
int knightHealth;
int attackGoblin;
int goblinHealth = rng.Next(101);
int attackKnight = 10;
int healKnight = 10;

Console.WriteLine("Welcome to the Knight vs Goblin game!");
Console.WriteLine("---------------------------------------");
Console.Write("Input your knight's health points (from 1 to 100): ");
bool isValidNumber = int.TryParse(Console.ReadLine(), out knightHealth);
if(isValidNumber == true)
{
    if (knightHealth > 100)
    {
        
        Console.WriteLine("The amount of health points that were input was greater than 100, set HP value to 100.");
        knightHealth = 100;
    }
    if (knightHealth <= 0)
    {
        Console.WriteLine("The amount of health points that were input was less than 1, set HP value to 1.");
        knightHealth = 1;
    }
}
else 
{
    Console.WriteLine("Invalid input detected, set HP value to 1, do better...");
    knightHealth = 1;
}
while (knightHealth > 0 && goblinHealth > 0) 
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Knight's health: {knightHealth}");
    Console.WriteLine($"Goblin's health: {goblinHealth}");
    Console.ResetColor();

    Console.WriteLine("It's the knight's turn.");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.Write("What would you like the knight to do?: ");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            goblinHealth -= attackKnight;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The knight strikes the goblin for 10 points of damage!");
            attackGoblin = rng.Next(16);
            Console.WriteLine($"The goblin sneers and strikes you back for {attackGoblin} damage!");
            knightHealth -= attackGoblin;
            Console.ResetColor();
            break;
        case "2":
            knightHealth += healKnight;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The knight heals themself for 10 life points!");
            attackGoblin = rng.Next(16);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"The goblin sneers and strikes you back for {attackGoblin} damage!");
            knightHealth -= attackGoblin;
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Invalid input given, try again. The goblin punishes you for your inadequacy. Do better...");
            attackGoblin = rng.Next(16);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"The goblin sneers and strikes you back for {attackGoblin} damage!");
            knightHealth -= attackGoblin;
            Console.ResetColor();
            break;
    }
}
if (knightHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The knight has perished...");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine("The goblin has been vanquished!");
}

/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspunten van de ridder en goblin in te stellen.
 */
/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
