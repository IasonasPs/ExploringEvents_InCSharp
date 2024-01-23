namespace ContinueWith
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var result = 0;

            var task = Task.Run(() => { return GetSquareNumber(10); });

            //result = task.Result;

            task.ContinueWith(
                ( task ) =>
                {
                    result = task.Result;
                    Console.WriteLine($"Result : {result}");
                },TaskContinuationOptions.NotOnCanceled);

            while(result == 0)
            {
                Console.WriteLine("Waiting for the result...");
                Thread.Sleep(500);
            }
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");

            //ChainingTasks.Chain();
            ChainingTasks.BetterChain();


            Console.ReadLine();
        }

        static int GetSquareNumber( int x )
        {
            Thread.Sleep(3000);
            return x * x;
        }
    }
}