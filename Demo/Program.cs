namespace Demo
{
    enum Season : byte
    {
        Spring = 10,
        Winter = 100,
        Summer,
        Autumn
    }
    enum WeekDay
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Gender
    {
        M = 1,
        F = 2,
        Male = 1,
        Female = 2
    }
    [Flags]
    enum Permissions
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }
    internal class Program
    {
        #region Exeption Handling And Protective Code Functions
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                int[] Arr = { 1, 2, 3 };
                Arr[99] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally");
                // Disconnect | Dispose UnManaged Resource
            }
        }
        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;
            try
            {
                do
                {
                    Console.WriteLine("Enter First Number:");
                    Flag = int.TryParse(Console.ReadLine(), out X);
                } while (Flag == false);
                do
                {
                    Console.WriteLine("Enter Second Number:");
                    Flag = int.TryParse(Console.ReadLine(), out Y);
                } while (Flag == false || Y == 0);
                Z = X / Y;
                int[] Arr = { 1, 2, 3 };
                if (99 < Arr?.Length)
                {
                    Arr[99] = 10;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally");
                // Disconnect | Dispose UnManaged Resource
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Boxing&UnBoxing
            //Boxing And UnBoxing

            //Boxing : Casting From ValueType To ReferenceType
            //UnBoxing: Casting From ReferenceType To ValueType

            //object O1;
            //// O1 => Can Refer To Instance Of "Object" Or Any Instance Of Any Type

            //O1 = 1;
            //O1 = "Ahmed";
            //O1 = 3; //Cast From ValueType[Int] To ReferenceType[Object]=>Boxing
            //O1 = 1.5; //Cast From ValueType[Double] To ReferenceType[Object]=>Boxing
            //O1 = "A"; //Cast From ValueType[Char] To ReferenceType[Object]=>Boxing
            //O1 = true; //Cast From ValueType[Bool] To ReferenceType[Object]=>Boxing
            //O1 = new DateTime(); //Cast From ValueType[DateTime] To ReferenceType[Object]=>Boxing

            //int X = 5;
            //object O1 =/*(object)*/ X;

            //Implicit Casting
            //Safe Casting
            //Boxing
            //Parent=Child =>Child Is Parent
            //Animal =Dog =>Dog Is Animal

            //object O1 = 3;
            //int X = (int)O1;

            //Explicit Casting 
            //Unsafe Casting [May Throw Exception]
            //UnBoxing
            //Dog = (Dog) Animal => Animal Is Dog
            // Child =Parent=> Parent Is Child 
            #endregion

            #region Nullable Value Type
            //int X = 6;

            ////X = null; // Not Valid

            //// Nullable<Int> : Allow Int Value Or Null As Valid Value

            ////int? Age = 20;
            ////Age = null;

            //// Nullable<Int> : Allow Double Value Or Null As Valid Value
            //double? Salary = 4000.5;

            //Salary = null;

            //int X = 5;
            ////Y:Nullable<int>
            ////Y:Allow Int Value Or Null
            //int? Y = /*(int?)*/ X;

            ////Implicit Casting
            ////Safe Casting
            ///
            //int? X = 5;
            //X = null;
            //Y:Nullable<int>
            //Y:Allow Int Value Or Null
            //int Y = (int)X;

            //Implicit Casting
            //Safe Casting

            //Defensive Code


            //if (X != null) 
            //    Y = (int)X;
            //else
            //    Y = 0;

            //// =============
            //if (X is not null) // Y = X is not null ? X.Value : 0;
            //    Y = (int)X;
            //else
            //    Y = 0;

            //// =============
            //if (X.HasValue) //Y = X.HasValue ? X.Value : 0;
            //    Y = (int)X;
            //else
            //    Y = 0;
            //// =============

            ////Null Coalescing Operator ??
            //Y = X ?? 0; //Syntax Sugar :X Is Not Null ? X.Value:0 

            #region Nullable Reference Type[C# 10.0 .net 6.0]
            //string Message01 = null; //Required

            //string Message02 = null;//Nullable

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02);

            #endregion

            #endregion

            #region Null Propagation Operator ?
            //int[] Arr = default;//null
            //int[] Arr = { 1, 2, 3, 4, 5 };

            ////Best Practice
            //if(Arr is not null)
            //{
            //    for(int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //for (int i = 0;(Arr is not null)&& i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0; i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //E?.Department?.DeptName

            //int Len = Arr is not null ? Arr.Length : 0;

            //int? Len = Arr?.Length;

            //int Len = Arr is not null ? Arr.Length : 0;

            //int Len = Arr?.Length ?? -1;

            //Console.WriteLine(Len); 
            #endregion

            #region Exeption Handling And Protective Code
            //DoSomeCode();
            //DoSomeProtectiveCode();
            //Exception
            //1-SystemException;
            //1-1-FormatException;
            //1-2-InsufficientExecutionStackException;
            //1-3-NullReferenceException;
            //1-4-ArithmeticException;
            //1-4-1-OverflowException;
            //1-4-2-DivideByZeroException;
            //2-ApplicationException
            #endregion


            //Common.TypeA typeA = new TypeA(); Invalid Cause TypeA is Internal;
            //Common.TypeB typeB = new Common.TypeB(); //Invalid Cause TypeA is Internal;
            #region Enum
            //Enum: Value Types
            //     Stack

            //Season S01 = Season.Autumn;

            //S01 = Season.Spring;

            //Console.WriteLine(S01);

            //CLR Represent Enum As Integer Value In Memory

            //Gender G01 = (Gender)10;
            //Console.WriteLine(G01);

            //Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

            //Gender G01;
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);
            //G01 = (Gender)O1;
            //Console.WriteLine(G01);

            #endregion

            #region Enum Ex
            //Permissions Per01 = Permissions.Read;
            //Per01 ^= Permissions.Delete; //Toggle

            //Per01 |= Permissions.Delete; //Add Permession
            //Console.WriteLine(Per01); //Delete ,Read
            //Per01 ^= Permissions.Delete; //Toggle
            //Console.WriteLine(Per01); //Read

            //Console.WriteLine(Per01); //Delete ,Read

            //Per01 &= ~(Permissions.Delete); // ~ Not Bitwise

            //Console.WriteLine(Per01);
            //& ->Check Permissions

            //if ((Per01 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}
            #endregion

        }


    }
}
