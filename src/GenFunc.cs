using System;
namespace DungeonsAndDragons
{
  public class GenFunc
  {
    public bool openingQuestion()
    {
      bool validator = false;
      char response = 'x';
      while(validator == false)
      {
        Console.WriteLine("Would you like to make a Player Character? (y/n)");
        Console.ReadLine(response);
        if(response == 'y')
        {
          validator = true; // this is unnesssary but makes it make more sense to me
          return true;
        }
      }
    }
  }
}