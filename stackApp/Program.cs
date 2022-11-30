namespace stackApp;
class Program
{
    static void Main(string[] args)
    {
//Stacks are first in-last out (or last in-first out)
        Stack<string> trainerStack = new Stack<string>();
        trainerStack.Push("Mark");
        trainerStack.Push("Jonathan");
//Write the trainer stack.
        Console.WriteLine("Your trainers are ");
        foreach (var trainer in trainerStack) {
            Console.Write(trainer + ", ");
    
        }
//Create a batch stack.
        Stack<string> batchStack = new Stack<string>();
        batchStack.Push("Admir");
        batchStack.Push("Benton");
        batchStack.Push("Wengel");
        batchStack.Push("Samuel");
//Write the batch stack.
        Console.WriteLine("");
        Console.WriteLine("Group 1 of the batch includes ");
        foreach (var batchMate in batchStack) {
            Console.Write(batchMate + ", ");
        }

        
        
    }
}
