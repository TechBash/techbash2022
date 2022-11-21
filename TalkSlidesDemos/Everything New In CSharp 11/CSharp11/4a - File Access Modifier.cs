namespace FileAccessModifier
{
    public class Foo
    {
        public void PrintTheAnswer()
        {
            var h = new FooHelper();
            Console.WriteLine("The Ultimate Answer Is " + h.GetTheAnswer());
        }
    }

    file class FooHelper
    {
        public int GetTheAnswer() => 42;
    }
}
