namespace Class_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example of constructor chaining
            Pokemon Whimsicott = new Pokemon("Whimsicott");
            Whimsicott.speak();


            Pikachu pikachu = new Pikachu("Pikachu", 4, 1200);
            pikachu.speak();
            pikachu.ThunderShock();
        }
    }
}
