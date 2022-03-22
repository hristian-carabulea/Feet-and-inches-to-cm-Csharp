class Program
{
//Instructions
//Transform feet and inches into centimeters
//Formula:  1 inch = 2.54 cm
//          1 feet = 12 inches
    static void Main()
    {
        //Arithmetical Operators
        double feet = 0, inches = 0, resultInCentimeters = 0;

        System.Console.Write("Enter the height feet ");
        string inputValue1 = System.Console.ReadLine();

        if (!System.Double.TryParse(inputValue1, out feet))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        {
            System.Console.Write("Enter the height inches ");
            string inputValue2 = System.Console.ReadLine();

            if (!System.Double.TryParse(inputValue2, out inches))
            {
                System.Console.WriteLine("Wrong input");
            }
            else
            {
                resultInCentimeters = (feet * 12 + inches) * 2.54;
                System.Console.WriteLine(feet + " feet " + inches + " inches equals " + resultInCentimeters + " centimeters");
            }
        }
        System.Console.WriteLine("Enter any key to and program.");
        System.Console.ReadKey();
    }
}