class Program
{
    /// <summary>
    /// This program converts x feet and y inches into centimeters
    /// </summary>
    /// Formula:  1 inch = 2.54 cm
    /// 1 feet = 12 inches
    static void Main()
    {
        //Arithmetical Operators
        double feet = 0, inches = 0, resultInCentimeters = 0;

        System.Console.Write("Enter the height feet ");
        string inputValue1 = System.Console.ReadLine();

        // try to parse number. If not a number, tell user the input is wrong
        if (!System.Double.TryParse(inputValue1, out feet))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        // get inches input
        {
            System.Console.Write("Enter the height inches ");
            string inputValue2 = System.Console.ReadLine();

            // try to parse the inches input. If not a number, display message wrong input
            if (!System.Double.TryParse(inputValue2, out inches))
            {
                System.Console.WriteLine("Wrong input");
            }
            else
            // calculate feet and inches into centimeters
            {
                resultInCentimeters = (feet * 12 + inches) * 2.54;
                System.Console.WriteLine(feet + " feet " + inches + " inches equals " + resultInCentimeters + " centimeters");
            }
        }
        System.Console.WriteLine("Enter any key to and program.");
        System.Console.ReadKey();
    }
}