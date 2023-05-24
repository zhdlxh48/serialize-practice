namespace ConsoleApp.Types
{
    [System.Serializable]
    public class TestClass
    {
        public int a;
        public float b;
        public string c;

        public override string ToString()
        {
            return $"a: {a}, b: {b}, c: {c}";
        }
    }
}
