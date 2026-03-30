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

            #region Question 4
            // A method that uses a type parameter (like T)
            // so it can work with different data types without rewriting it

            /*
             public static void Swap<T>(ref T a, ref T b)
                {
                    T temp = a;
                    a = b;
                    b = temp;
                }
             */

            // int x = 100, y = 200;
            // Swap(ref x, ref y);
            // Console.WriteLine($"x: {x}, y: {y}"); // x: 200, y: 100


            #endregion

            #region Question 5
            // Find Max Value in an Array using Generics

            // method returns the maximum value between two values
            // we use constraint IComparable<T> so we can compare values

            /*
             public static T Max<T>(T a, T b) where T : IComparable<T>
                {
                    return a.CompareTo(b) > 0 ? a : b;
                }
             */

            // int max = FindMax(100, 200);
            // Console.WriteLine(max);  200

            #endregion

            #region Question 6

            /* Q6: What is a generic interface
             * A generic interface is a contract that uses a type parameter (e.g., <T>), 
             * allowing it to work with any data type while ensuring type safety 
             * and code reusability.
            */

            //public interface IRepository<T> where T : class
            //        {
            //            T GetById(int id);
            //            IEnumerable<T> GetAll();
            //            void Add(T entity);
            //            void Update(T entity);
            //            void Delete(int id);
            //            void Save();
            //        }
            #endregion

            #region Question 7
            /* * Q7: What is the 'struct' constraint? 
               * The 'struct' constraint ensures that the type argument (T) must be a 
               * non-nullable value type (e.g., int, double, bool, or any custom struct). 
               * It prohibits reference types (classes) and nullable value types.
            */

            //public class ValueHandler<T> where T : struct
            //        {
            //            public T Value { get; set; }
            //
            //            public void Reset()
            //            {
            //                Value = default(T);
            //            }
            //        }
            #endregion

            #region Question 8

            /* Q8: What is the 'class' constraint? 
             * The 'class' constraint ensures that the type argument (T) must be a reference type (e.g., class, interface, delegate). 
             * It prohibits value types (structs) and nullable value types.
            */
            //public class ReferenceHandler<T> where T : class
            //        {
            //            public T Reference { get; set; }
            //
            //            public void Clear()
            //            {
            //                Reference = null;
            //            }
            //


            #endregion

            #region Question 9
            /* Q9: What is the 'new()' constraint? 
             * The 'new()' constraint ensures that the type argument (T) must have a public parameterless constructor. 
             * This allows you to create instances of T using the new operator within the generic class or method.
            */
            //public class Factory<T> where T : new()
            //        {
            //            public T CreateInstance()
            //            {
            //                return new T();
            //            }
            //
            #endregion

            #region Question 10

            // Interface Constraint => 
            // Restricts the generic type to implement a specific interface
            // This allows us to call the interface methods safely on T


            /*
             public interface IPrintable
                    {
                        void Print();
                    }

                    public class Printer<T> where T : IPrintable
                    {
                            public void Show(T item)
                            {
                                item.Print();
                            }
                    }

                    public class Document : IPrintable
                    {
                        public string Text { get; set; } = "";
                        public void Print()
                    {
                        Console.WriteLine(Text);
                    }
                  }
            */
            #endregion

            #region Question 11

            /* 
             * The base class constraint specifies that the generic type argument (T) 
             * must be of a specific class type or inherit from that specific base class. 
             * This allows the generic code to access members (properties/methods) defined in that base class.
            */

            //public class Animal
            //        {
            //            public string Name { get; set; }
            //        }
            //
            //        public class AnimalHandler<T> where T : Animal
            //        {
            //            public void PrintAnimalName(T animal)
            //            {
            //                Console.WriteLine(animal.Name);
            //            }
            //        }

            #endregion

            #region Question 12
            /*  
             * You apply multiple constraints by listing them after the 'where' keyword, 
             * separated by commas. 
             * Important: The base class must come first, followed by any interfaces, 
             * and the 'new()' constraint must always be the last one.
            */

            //public class Container<T> where T : class, IComparable<T>, new()
            //        {
            //            // T must be:
            //            // 1. A reference type (class)
            //            // 2. Implement the IComparable interface
            //            // 3. Have a public parameterless constructor (new())
            //
            //            public T CreateInstance() => new T();
            //        }
            #endregion

            #region Question 13

            // Returns the default value for a generic type T
            // For reference types: null
            // For value types: 0, false, or equivalent default
            // Useful when you want a "zero" value without knowing T

            //public class ValueOrDefault<T>
            //        {
            //            private T? _value;
            //            private bool _hasValue;
            //
            //            // Returns stored value or default(T) if none
            //            public T GetValueOrDefault()
            //            {
            //                return _hasValue ? _value! : default!;
            //            }
            //
            //            // Returns stored value or fallback if none
            //            public T GetValueOrDefault(T fallback)
            //            {
            //                return _hasValue ? _value! : fallback;
            //            }
            //        }
            //
            // Usage:
            // default(int)     // 0
            // default(bool)    // false
            // default(string)  // null
            #endregion

            #region Question 14
            // SafeList<T>:
            // A generic list wrapper that returns default(T) instead of throwing an exception
            // when accessing an invalid index

            //      public class SafeList<T>
            //            {
            //                private List<T> _items = new List<T>();
            //    
            //                public void Add(T item)
            //                {
            //                    _items.Add(item);
            //                }
            //    
            //                public T Get(int index)
            //                {
            //                    if (index < 0 || index >= _items.Count)
            //                        return default!;
            //                    return _items[index];
            //                }
            //    
            //                // Count property
            //                public int Count => _items.Count;
            //            }

            //        SafeList<int> list = new SafeList<int>();
            //        list.Add(10);
            //        list.Add(20);
            //        Console.WriteLine(list.Get(1)); // 20

            #endregion

            #region Question 15
            // Allows a generic type to use a more derived type than originally specified
            // This means you can assign a derived type to a base type reference safely

            // The 'out' keyword marks the type parameter as covariant
            // Covariant type parameters can only appear in output positions (return types)
            // They cannot be used as method arguments (input)

            #endregion

            #region Question 16
            // Q16: What is contravariance? Explain the 'in' keyword.
            // Contravariance allows a generic type to use a less derived type than originally specified
            #endregion

            #region Question 17
            // Q17: What is the difference between covariance and contravariance?

            // convariance => 


            // Direction: Derived → Base
            // Allows assignment of a more derived type to a less derived type reference
            // Only allowed in output positions (return values)

            // Contravariance =>

            // Direction: Base => Derived
            // Allows assignment of a less derived type to a more derived type reference
            // Only allowed in input positions (method parameters)

            #endregion

            #region Question 18
            //Q18: How do static members work in generic types ?
            // Static members in generic types are shared across all instances of the same closed constructed type (same type arguments).


            #endregion

        }
    }
}
