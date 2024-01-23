namespace GA_MethodOverloading_JuanHernandez
{
    internal class Program
    {
        //Juan Hernandez    
        //Guided Assignment: Method Overloading
        //01/22/2024

        // Understanding Method Overloading:
        //******************************************
        // Why Method Overloading in C#? 
        // Method overloading helps the user when trying to call a method and they not having enough information.
        //******************************************
        // Describe how method overloading works with different parameter types and counts.
        // for example a gradbook class may have a display method with only a name parameter as professor may not have 
        // a grade for the student, and another method may have a grade parameter therfore adding a grade for that student.
        //******************************************
        // Explain the benefits of using method overloading in a software application.
        // The benefits are that it gives the user multiple options on methods with less info required.
        //******************************************
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //MathOperations math = new MathOperations();
            //EmployeeDatabase database = new EmployeeDatabase();

            // Math operations
            //int sum1 = math.Add(10, 5);
            //Console.WriteLine($"Sum1: {sum1}");

            //double difference = math.Subtract(7.5, 3.2);
            //Console.WriteLine($"Difference: {difference}");

            //double product = math.Multiply(4.0, 2.5, 3.0);
            //Console.WriteLine($"Product: {product}");

            //try
            //{
            //double result = math.Divide(8.0, 2.0);
            //Console.WriteLine($"Division Result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //Console.WriteLine($"Error: {ex.Message}");
            //}

            // Employee database
            //database.AddEmployee("John Doe");
            //database.AddEmployee("Jane Smith", 30);
            //database.AddEmployee("Robert Johnson", 25, "HR");

            MathOperations math = new MathOperations();
            EmployeeDatabase database = new EmployeeDatabase();

            // Math operations
            int sum1 = math.Add(10, 5);
            Console.WriteLine($"Sum1: {sum1}");

            double difference = math.Subtract(7.5, 3.2);
            Console.WriteLine($"Difference: {difference}");

            double product = math.Multiply(4.0, 2.5, 3.0);
            Console.WriteLine($"Product: {product}");

            try
            {
                double result = math.Divide(8.0, 2.0);
                Console.WriteLine($"Division Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Employee database
            database.AddEmployee("John Doe");
            database.AddEmployee("Jane Smith", 30);
            database.AddEmployee("Robert Johnson", 25, "HR");
        }
    }
}// Done