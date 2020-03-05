using System;

namespace ClassIntro
{
  public class Car
  {
    // Fields
    // Fields don't have a get' set; and are typically private
    // Typically with an underscore in the front. A naming convention.
    private int _milesDriven = 0;

    //Properties
    // Properties have a get' set; and are typically public
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool NeedsMaintenance { get; set; } = false;
    public bool IsClean { get; set; } = false;

    // Computed Property
    // It's a read-only property. Cannot be set
    public string Description
    {
      get
      {
        return $"{Year} {Make} {Model}";
      }

    }

    // Methods (Functions)
    public void Drive(int miles)
    {
      _milesDriven += miles;

      if (_milesDriven > 10000)
      {
        NeedsMaintenance = true;
      }
    }

    public void Service()
    {
      NeedsMaintenance = false;
    }

    // Method Overloading
    // Shares a method name, but has different arguments
    public void Service(bool addCleaningService)
    {
      NeedsMaintenance = false;
      if (addCleaningService)
      {
        IsClean = addCleaningService;
      }
    }

    // This is a constructor. It doesn't have a return type
    //and the name of the method is the dame as the name of the class
    public Car(int milesDriven)
    {
      _milesDriven = milesDriven;
    }

    public Car(int milesDriven, string make, string model, int year)
    {
      _milesDriven = milesDriven;
      Make = make;
      Model = model;
      Year = year;
    }
  }
}