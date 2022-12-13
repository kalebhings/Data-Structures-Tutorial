using queue_problem_solution;

Console.WriteLine("Test 1");
LineSwitch lineSwitch = new LineSwitch(5);
lineSwitch.EnterLine("Bob", "n"); 
lineSwitch.EnterLine("Joe", "n");
lineSwitch.EnterLine("Kaleb", "y");
lineSwitch.LineLength();
lineSwitch.ProcessLine();
lineSwitch.ProcessLine();
lineSwitch.ProcessLine();
lineSwitch.ProcessLine();

Console.WriteLine();
Console.WriteLine("Test 2");
LineSwitch lineSwitch2 = new LineSwitch(2);
lineSwitch2.EnterLine("Bob", "n"); 
lineSwitch2.EnterLine("Joe", "n");
lineSwitch2.EnterLine("Kaleb", "y");
lineSwitch2.EnterLine("Dylan", "y");