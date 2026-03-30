namespace G_NET_33_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Generic Class:
            // A generic class is a class that uses a type placeholder (like T)
            // instead of specifying a fixed data type.
            // This allows the same class to work with different data types (int, string, etc.)

            // Why use Generics?
            // 1- Type Safety: prevents type errors at compile-time instead of runtime
            // 2- Performance: avoids boxing/unboxing when using value types
            // 3- Code Reuse: write one class and use it with multiple data types
            // 4- Cleaner Code: makes code more readable and maintainable

            #endregion


            #region Question 2

            //  class Container<T>
            //   {
            //  private T item;
            //
            //  public void Add(T value)
            //  {
            //      item = value;
            //  }
            //
            //  public T Get()
            //  {
            //      return item;
            //  }
            //  }

            // Container<int> c = new Container<int>();
            // c.Add(10);
            // Console.WriteLine(c.Get()); // 10
            #endregion

            #region Question 3

            // means using more than one generic type (like TKey, TValue)
            // so the class can handle more than one data type at the same ti

            // Example:
            // class Pair<TKey, TValue>
            /*
             class Pair<TKey, TValue>
                {
                    public TKey Key { get; set; }
                    public TValue Value { get; set; }
                
                    public Pair(TKey key, TValue value)
                    {
                        Key = key;
                        Value = value;
                    }
                }
             */

            // Pair<string, int> p = new Pair<string, int>("Age", 23);

            // Console.WriteLine(p.Key);   =>  "Age"

            // Console.WriteLine(p.Value); => 25



            #endregion




        }
    }
}
