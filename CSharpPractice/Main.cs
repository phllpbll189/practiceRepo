using System;
using MaxVolume;
using Util;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      VolumeCalc calculator = new VolumeCalc();

      bool testResult = Sort.testSwap();
      Console.Write(testResult);
      // int[] arr = {1,2,3,4,4};
      // int retval = calculator.CalcVolume(arr);
      // Console.Write(retval);
    }
  }
}