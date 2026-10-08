using System;
// Create interface: IWorker
// Methods: Work(), TakeBreak()

// Create classes:
// Developer → Work() prints "Writing code"
// Designer  → Work() prints "Creating designs"
// Manager   → Work() prints "Managing team"
// All → TakeBreak() prints "Taking a 15 min break"

// Store all in List<IWorker>
// Loop and call Work() + TakeBreak()
namespace Day08_IRuntime
{
    public interface IWorker
    {
        void Work();
        void TakeBreak();
    }
    public class Developer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Writing code...");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Take 15 mins break...");
        }
    }

    public class Designer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Creating Design...");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Take 15 mins break...");
        }
    }

    public class Manager : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Managing Team....");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Take 15 mins break...");
        }
    }

    public class WorkerTask
    {
        public static void Run()
        {
            var list = new List<IWorker>()
            {
                new Developer(),
                new Designer(),
                new Manager(),
            };

            foreach(var worker in list)
            {
                worker.Work();
                worker.TakeBreak();
            }
        }
    }
}