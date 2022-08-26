namespace Module_7
{
    public class Car<T>
    {
        public T Engine = default;

    }

    public class ElectricEngine
    {

    }

    public class GasEngine
    {

    }

    public class Record<T1, T2>
    {
        public T1 ID = default;
        public T2 Value = default;
        public DateTime Date = default;
    }
}