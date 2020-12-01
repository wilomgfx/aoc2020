using System;
using System.Collections;
using System.Linq;
using System.Diagnostics;

class DayOne: IRunDay {

  public void Run() {
    Stopwatch stopwatch = Stopwatch.StartNew();
    Console.WriteLine ("--------- DayOne ---------");
    Part1();
    stopwatch.Stop();
    Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
    Console.WriteLine ("--------- DayOne Part2 ---------");
    stopwatch = Stopwatch.StartNew();
    Part2();
    stopwatch.Stop();
    Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
  }

  private void Part1() {
    var inputs = MainClass.GetDayInput("day1");
    var numbers = inputs.Select(Int32.Parse).ToList();
    foreach (var i in numbers) {
        foreach (var i2 in numbers) {
            var addition = i + i2;
            if(addition == 2020) {
                // Console.WriteLine($"Yes! {i} + {i2} == 2020");
                var result = i*i2;
                Console.WriteLine($"Result: {result}");
            }
        }
    }
  }

  private void Part2() {
    var inputs = MainClass.GetDayInput("day1.p2");
    var numbers = inputs.Select(Int32.Parse).ToList();
    foreach (var i in numbers) {
        foreach (var i2 in numbers) {
            foreach (var i3 in numbers) {
                var addition = i + i2 +i3;
                if(addition == 2020) {
                    // Console.WriteLine($"Yes! {i} + {i2} + {i3} == 2020");
                    var result = i*i2*i3;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
  }
}