using CalculatorLibrary.Formulas;

Console.Write("first number: ");
BasicWithProperties.firstNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("second number: ");
BasicWithProperties.secondNumber = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(BasicWithProperties.getAddition());