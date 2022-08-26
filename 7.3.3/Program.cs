abstract class ComputerPart
{
    public abstract void Work();
}

class Processor : ComputerPart
{
    public override void Work() { }
}


class MotherBoard : ComputerPart
{
    public override void Work() { }
}

class GraficCard : ComputerPart
{
    public override void Work() { } 
}
