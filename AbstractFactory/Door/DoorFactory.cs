namespace AbstractFactory.Door
{
    public class DoorFactory : IAbstractDoor
    {
        public string GetName()
        {
            return "Sou uma porta";
        }
    }
}
