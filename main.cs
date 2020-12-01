using System;
using System.Collections;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    RunDayOne();
  }

  public static string[] GetDayInput(string day) {
      var lines = System.IO.File.ReadAllLines($"./Inputs/{day}.txt");
      return lines;
  }

  public static void RunDayOne() {
    DayOne dayOne = new DayOne();
    dayOne.Run();
  }
}