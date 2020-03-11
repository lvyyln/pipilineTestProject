namespace Test.Domain
{
    public class Car
    {
        public Engine Engine { get; set; }

        public bool IsStopped { get; set; }

        public Car(Engine engine)
        {
            Engine = engine;
            IsStopped = true;
        }

        public object GetCar()
        {
            return new
            {
                this.Engine,
                this.IsStopped
            };
        }
        public void Start()
        {
            Engine.Start();
            IsStopped = false;
        }

        public void Stop()
        {
            Engine.Stop();
            IsStopped = true;
        }
    }
}