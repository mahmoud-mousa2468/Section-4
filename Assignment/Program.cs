namespace Assignment
{
    #region Q1
    enum WeekDays
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    #endregion

    #region Q2
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Q3
    [Flags]  // give Enum variable to have Multi Values 
    enum Permissions
    {
        Read = 8,
        Write = 4,
        Delete = 2,
        Execute = 1
    }
    #endregion

    #region Q4
    enum Color
    {
        Red,
        Green,
        Blue
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1-Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (var Day in Enum.GetValues<WeekDays>())
            //{
            //    Console.WriteLine(Day);
            //} 
            #endregion

            #region Q2
            //2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding
            //month range for that season. Note range for seasons ( spring march to may , summer june to august ,
            //autumn September to November , winter December to February)
            //Season Spring = Season.Spring;
            //Season Summer = Season.Summer;
            //Season Autumn = Season.Autumn;
            //Season Winter = Season.Winter;
            //Console.WriteLine("Enter Season Name");
            //string SeasonName = Console.ReadLine();
            //if (SeasonName.ToLower() == Spring.ToString().ToLower())
            //{
            //    Console.WriteLine("Range Is From march to may");
            //}
            //else if (SeasonName.ToLower() == Summer.ToString().ToLower())
            //{
            //    Console.WriteLine("Range Is From june to august");
            //}
            //else if (SeasonName.ToLower() == Autumn.ToString().ToLower())
            //{
            //    Console.WriteLine("Range Is From September to November");
            //}
            //else if (SeasonName.ToLower() == Winter.ToString().ToLower())
            //{
            //    Console.WriteLine("Range Is From December to February");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season Name");
            //}
            #endregion

            #region Q3
            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //●	Create Variable from previous Enum to Add and Remove Permission from variable,
            //Permissions P01 = Permissions.Read;
            //P01 |= Permissions.Write; //Add
            //Console.WriteLine(P01); //Write ,Read
            //P01 ^= Permissions.Write;// Toggle if it Exist remove it else Add it
            //Console.WriteLine(P01); //Read
            //P01 &= ~(Permissions.Write);// Not Bit Wise Remove the Value
            //Console.WriteLine(P01); //Read
            ////check if specific Permission is existed inside variable

            //if ((P01 & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exist");
            //}

            #endregion

            #region Q4
            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating
            //whether the input color is a primary color or not.
            //Color Red = Color.Red;
            //Color Green = Color.Green;
            //Color Blue = Color.Blue;
            //Console.WriteLine("Enter Your Color");
            //string ColorInp = Console.ReadLine();
            //if ((ColorInp.ToLower() == (Red.ToString().ToLower())) || (ColorInp.ToLower() == (Green.ToString().ToLower())) || (ColorInp.ToLower() == (Blue.ToString().ToLower())))
            //{
            //    Console.WriteLine("primary color");
            //}
            //else
            //{
            //    Console.WriteLine("Not primary color");
            //}
            #endregion
        }
    }
}
