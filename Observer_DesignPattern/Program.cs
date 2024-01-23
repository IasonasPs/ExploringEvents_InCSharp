namespace Observer_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ConcreteObserver observer = new ConcreteObserver("First Observer");
            var observerNo2 = new ConcreteObserver("Second Observer");


            subject.Attach(observer);
            subject.ChangeState();
            subject.Attach(observerNo2);
            subject.ChangeState();
            subject.Detach(observer);

        }
    }
}
