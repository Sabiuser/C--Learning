using System;
// Create Queue<string> for support tickets
// → Add 5 tickets
// → Show next ticket (Peek)
// → Process (Dequeue) 2 tickets
// → Show remaining tickets
// → Add 2 more tickets
// → Process all remaining
namespace Day09_Queue
{
    public class QueueTask
    {
        public static void Run()
        {
            Queue<string> tickets = new Queue<string>();
            tickets.Enqueue("Sabi");
            tickets.Enqueue("Ramji");
            tickets.Enqueue("Bharani");
            tickets.Enqueue("Mani");

            Console.WriteLine(tickets.Peek());

            Console.WriteLine($"First Ticket : {tickets.Dequeue()}");
            Console.WriteLine($"Second Ticket : {tickets.Dequeue()}");

            Console.WriteLine($"Count : {tickets.Count}");

            foreach(var ticket in tickets)
            {
                Console.WriteLine($"Tickets : {ticket}");
            }

            tickets.Enqueue("Messi");
            tickets.Enqueue("Mbappe");
foreach(var final in tickets)
            {
                Console.WriteLine($"Final tickets : {final}");
            }


        }
    }
}