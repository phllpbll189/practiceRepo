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

      int[] testArr = {17, 4, 7, 12, 9};

      int[] testResult = Sort.Qsort(testArr);

      foreach(int num in testResult){
        Console.WriteLine(num);
      }
      // int[] arr = {1,2,3,4,4};
      // int retval = calculator.CalcVolume(arr);
      // Console.Write(retval);
    }
  }
}