using AbstractFactory.Door;
using AbstractFactory.Roof;
using AbstractFactory.Window;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractDoor CreateDoor();
        IAbstractWindow CreateWindow();
        IAbstractRoof CreateRoof();
    }
}
