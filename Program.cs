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

        }
    }
}
