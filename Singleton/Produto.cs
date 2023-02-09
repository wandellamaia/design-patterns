namespace Singleton
{
    public class Produto
    {
        private static Produto _instance;
        public Produto() {}

        public static Produto GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Produto();
            }
            return _instance;
        }
        public string Name { get; set; }

    }
}
