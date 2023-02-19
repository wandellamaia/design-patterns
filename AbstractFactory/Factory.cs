using AbstractFactory.Door;
using AbstractFactory.Roof;
using AbstractFactory.Window;

namespace AbstractFactory
{
    public class Factory : IAbstractFactory
    {
        public IAbstractDoor CreateDoor()
        {
            return new DoorFactory();
        }
        public IAbstractRoof CreateRoof()
        {
            return new RoofFactory();
        }
        public IAbstractWindow CreateWindow()
        {
            return new WindowFactory();
        }
    }
}
