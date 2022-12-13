using linked_list_problem_solution;

LinkedList music = new LinkedList();

music.InsertTail("Humble and Kind - Tim Mcgraw");
music.InsertHead("Die a Happy Man - Thomas Rhett");
music.InsertHead("21 Guns - Green Day");
music.InsertHead("Don't Stop Believing - Journey");
music.InsertHead("Let You Down - NF");
music.InsertAfter("21 Guns - Green Day", "The Middle - Jimmy Eat World");

Console.WriteLine("Test 1");
foreach (var value in music)
{
    Console.WriteLine(value);
}

Console.WriteLine();
Console.WriteLine("Test 2");
music.RemoveHead();


music.RemoveTail();
music.Replace("21 Guns - Green Day", "All Star - Smash Mouth");

foreach (var value in music)
{
    Console.WriteLine(value);
}