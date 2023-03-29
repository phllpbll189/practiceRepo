using System;
using MaxVolume;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      VolumeCalc calculator = new VolumeCalc();
      int[] arr = {1,2,3,4,4};
      
      int retval = calculator.CalcVolume(arr);
      Console.Write(retval);
    }
  }
}