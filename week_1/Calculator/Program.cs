// Topics Discussed

// Type Inference (var)
// Parsing
// Casting (implicit, explicit)
// Scopes (namespace, class, method, block)
// Single Responsibility (part of SOLID)
// DRY (don't repeat yourself)
// Method (signature, parameter, argument)
// Primitive Types (int, bool, string, float, double)
// Type Families (value, reference)

using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // input stuff
      var input1 = int.Parse(Console.ReadLine()); //123a, 123 // type inference, parsing
      var input2 = int.Parse(Console.ReadLine());

      // compute stuff
      int result1 = Add(input1, input2);
      int result2 = Subtract(input1, input2);

      // output stuff
      Print(result1, result2, result1, result2);
    }

    static void Add(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 + (int)input2; // type inference, casting
    }

    static void Subtract(int input1, int input2)
    {
      // compute stuff
      var compute = (int)input1 - (int)input2; // type inference, casting
    }

    static void Print(params int[] results)
    {
      // output stuff
      Console.WriteLine(result1, result2);
    }
  }
}
