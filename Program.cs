//Griffin Parker
//Mini Challenge 3 Remastered - Asking Questions
//October 18, 2022

string name = "";
string time = "";
string repeat = "";
int choice = 0;
int loop = 0;
while (loop == 0)
{
Console.Clear();
Console.WriteLine("Ay yo, what ya momma call ya?");
name = Console.ReadLine();
Console.WriteLine("And what time did your eyes crack open this morning?");
time = Console.ReadLine();

if (name.Length <= 0 || time.Length <= 0)
{
    Console.WriteLine("Thought you could pull a fast one on me eh? You need to actually answer BOTH THE QUESTIONS!!");
    Thread.Sleep(4000);
    choice++;
}else
{
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"So you're telling me that you're {name} and you woke up at {time}???");
Console.WriteLine();
Thread.Sleep(1500);
Console.WriteLine("Man...");
Thread.Sleep(1000);
Console.WriteLine("You're pulling my leg, ain'tcha?");
Console.WriteLine();
choice = 0;
}
while (choice == 0)
{
Console.WriteLine("C'mon, tell me the truth this time. \"yes\" or \"no\"?");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "no")
{
    choice++;
    loop++;
    Console.WriteLine("Alright then, keep your secrets...");
}
if (repeat == "yes")
{
    choice++;
}
}
}
