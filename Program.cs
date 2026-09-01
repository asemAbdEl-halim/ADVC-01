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
        }
    }
}
