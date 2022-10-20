//Griffin Parker
//Mini Challenge 3 Remastered - Asking Questions
//October 18, 2022
//This project asks the user for their name and when they woke up, and then checks to make sure they inputted something for both fields. It then tells the user 
//their name and when they woke up.
//Peer Review by Daniel Decoito: The program runs well and meets all criteria for the project. First I would like the mention how much I enjoyed the 
//interaction with the user. Although what is being asked is simple I enjoyed how it was being asked. It created a more engaging programing. You have intersting conditions for your loops. 
//While they are interesting in thought ultimatley the create unnecesary code. Consider using the not equal to operator to create your condition. an example 
//being -->while (stringVar != "end")<--, I hope that makes sense. Another thing that can be done is to use line breaks withing a string so you dont have to write multiple Console.WriteLines.
//Otherwise that the app worked great and had alot of humor.

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
