namespace Facade
{
    /*
     O desing patern sem dúvidas também é um dos mais utilizados nas implementaçõe.
    Ele possui fácil compreensão e interface simples de ser lida, diminuindo a complexidade
    da aplicação.
     */
    public class Facade
    {
        public Door _door;
        public Roof _roof;

        public Facade(Door door, Roof roof) {
            _door= door;
            _roof= roof;
        }

        public string Object()
        {
            string objects = "Name Item\n";
            objects+= _door.Name();
            objects += _roof.Name();
            objects += "Description Item\n";
            objects += _door.Description();
            objects += _roof.Description();
            return objects;
        }
    }
}
