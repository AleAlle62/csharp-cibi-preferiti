string[] preferiti = { "Pasta", "pizza", "tacos", "hamburger", "sushi" };
Console.WriteLine("la lunghezza della classifica e:" + preferiti.Length);

Console.WriteLine("la classifica:");
for (int i = 0; i < preferiti.Length; i++)
{
    Console.WriteLine((i+1) + ":" + preferiti[i]);
}

Console.WriteLine("il mio cibo:" + preferiti[0]);
Console.WriteLine("meno preferito:" + preferiti[preferiti.Length-1]);


int index = preferiti.Length / 2;
if (preferiti.Length % 2 == 0)
{
    Console.WriteLine("il cibo nel mezzo e':" + preferiti[index - 1] + "e" + preferiti[index]); 
}
else
{
    Console.WriteLine("il cibo nel mezzo e':" + preferiti[index]); 
}