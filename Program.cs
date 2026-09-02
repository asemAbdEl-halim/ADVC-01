namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
             * 1) What is a generic class? Why use generics?
             * ==> Answer <==
             * ==> A generic class is a class that can work with different data types without specifying the type when creating the class.
             * ==> Code Reusability: Write the code once and use it with different types.
             * Type Safety: Prevents using the wrong data type.
             * Less Casting: No need to convert objects between types.
             * **/

            #endregion

            #region Question02

            /*
             * 2) Write a generic class Container<T> with Add and Get methods.
             * **/

            #endregion

            #region Question03

            /*
             * 3) What are multiple type parameters? Write Pair<TKey, TValue>.
             * **/

            #endregion

            #region Question04

            /*
             * 4) What is a generic method? Write Swap<T> method.
             * ==> Answer <==
             * ==> A generic method is a method that can operate on different data types without specifying the type when calling the method.
             * static void Swap<T>(ref T a, ref T b)
               {
                       T temp = a;
                       a = b;
                       b = temp;
                   }
            * **/

            #endregion

            #region Question05

            /*
             * 5) Write a generic method FindMax<T> that finds maximum value
             * => Answer <==
             * static T FindMax<T>(T a, T b) where T : IComparable<T>
              {
                  if (a.CompareTo(b) > 0)
                      return a;
              
                  return b;
              }
            * **/

            #endregion

            #region Question06

            /*
             * 6) What is a generic interface? Write IRepository<T>.
             * => Answer <==
             * => A generic interface is an interface that can work with different data types using a type parameter like T.
            * **/

            #endregion

            #region Question07

            /*
             * 7) What is the 'struct' constraint? Write an example.
             * => Answer <==
             * => The struct constraint means that the generic type T must be a value type, such as int, double, bool, or a struct.
            * **/

            #endregion

            #region Question08

            /*
             * 8) What is the 'class' constraint? Write an example.
             * => Answer <==
             * ==> The class constraint means that the generic type T must be a reference type (class).
            * **/

            #endregion

            #region Question09

            /*
             * 9) What is the 'new()' constraint? Write an example.
             * => Answer <==
             * ==> The new() constraint means that the generic type T must have a parameterless constructor.
            * **/

            #endregion

            #region Question10

            /*
             * 10) What is the interface constraint? Write an example.
             * => Answer <==
             * ==> The interface constraint means that the generic type T must implement a specific interface.
            * **/

            #endregion

            #region Question11

            /*
             * 11) What is the base class constraint? Write an example.
             * => Answer <==
             * ==> The base class constraint means that the generic type T must inherit from a specific class.
            * **/

            #endregion

            #region Question12

            /*
             * 12) How do you apply multiple constraints? Write an example.
             * => Answer <==
             * ==> Multiple constraints mean that we can apply more than one constraint to the same generic type T.
            * **/

            #endregion

            #region Question13

            /*
             * 13) What does the 'default' keyword do in generics?
             * => Answer <==
             * ==> The default keyword returns the default value of a generic type T.
             * static T GetDefault<T>()
            {
                return default(T);
            }
            * **/

            #endregion

            #region Question14

            /*
             * 14) Write a SafeList<T> that returns default when the index is invalid.
            * **/

            #endregion

            #region Question15

            /*
             * 15) What is covariance? Explain the out keyword?
             * => Answer <==
             * ==> Covariance allows a method to return a more derived type than originally specified. 
             * The out keyword is used to specify that a generic type parameter is covariant.
            * **/

            #endregion

            #region Question16

            /*
             * 16) What is contravariance? Explain the 'in' keyword.
             * => Answer <==
             * ==> Contravariance allows a method to accept parameters of a less derived type than originally specified.
             * The 'in' keyword is used to specify that a generic type parameter is contravariant.
            * **/

            #endregion

            #region Question17

            /*
             * 17) What is the difference between covariance and contravariance?
             * => Answer <==
             * ==> Covariance allows a method to return a more derived type than originally specified,
             * while contravariance allows a method to accept parameters of a less derived type than originally specified.
            * **/

            #endregion

            #region Question18

            /*
             * 18) How do static members work in generic types?
             * => Answer <==
             * ==> Static members in generic types are shared across all instances of the same closed constructed type.
             * Each closed constructed type has its own copy of static members.
            * **/

            #endregion

            #region Question19

            /*
             * 19) How can you inherit from a generic class?
             * => Answer <==
             * ==> You can inherit from a generic class by specifying the type parameter when defining the derived class.
            * **/

            #endregion

            #region Question20

            /*
             * 20) Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support.
             * => Answer <==
             * Cache<int, string> cache = new Cache<int, string>();

              cache.Add(1, "Hello", TimeSpan.FromSeconds(10));
              cache.Add(2, "World", TimeSpan.FromSeconds(5));
              
              Console.WriteLine(cache.Get(1));
              
              Console.WriteLine(cache.Contains(1));
              
              cache.Remove(1);
              
              Console.WriteLine(cache.Contains(1));
              
              Console.WriteLine(cache.Get(5));
            * **/

            #endregion

        }
    }
}
