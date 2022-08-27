namespace Module_7
{
    public abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine = default;

        public abstract void ChangePart<TPart>(TPart newpart) where TPart : CarPart;

    }

    public class GasCar<TEngine> : Car<TEngine> where TEngine : Engine
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    public class ElectricCar<TEngine> : Car<TEngine> where TEngine : Engine
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    abstract public class Engine : CarPart
    {

    }

    abstract public class CarPart
    {

    }

    public class ElectricEngine : Engine
    {

    }

    public class GasEngine : Engine
    {

    }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    public class Record<T1, T2>
    {
        public T1 ID = default;
        public T2 Value = default;
        public DateTime Date = default;
    }
}