using System;

namespace Finder.Object
{
  public class DayFinder
  {

    private int[] _epoch = {1, 1, 1900}; //Epoch date is 1/1/2000
    private string[] _daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; //Array organized with day of Epoch Date at index 0
    private int[] monthDefs = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; // Number of days in each month, Jan, Feb, March, etc;
    private string _inputDate;
    private int[] _splitInputDate;
    private int _daysSinceEpoch;
    private bool _isInputLeapYear;

    public DayFinder(string input)
    {
      ParseInput(input);
      _inputDate = input;
      _isInputLeapYear = IsLeapYear(_splitInputDate[2]);
    }

    public int GetDaysSinceEpoch()
    {
      return _daysSinceEpoch;
    }

    public void ParseInput(string userInput)
    {
      string[] input = (userInput.Split('/'));
      int[] strToNum = new int[3];
      for (int i = 0; i < input.Length; i++)
      {
        strToNum[i] = int.Parse(input[i]);
      }
      _splitInputDate = strToNum;
    }

    public bool IsLeapYear(int year)
    {
      return ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0));
    }

    public void Counter()
    {
      //Calculate days * years
      int yearDifference = _splitInputDate[2] - _epoch[2];
      // System.Console.WriteLine("Year Difference: " + yearDifference);
      for (int i = 0; i < yearDifference; i++)
      {
        _daysSinceEpoch += (IsLeapYear(_epoch[2] + i )) ? 366 : 365;
      }
      //Calculate days * months
      int monthDifference = _splitInputDate[0] - _epoch[0];
      // System.Console.WriteLine("Month Difference: " + monthDifference);
      for (int i = 0; i < monthDifference; i++)
      {
        _daysSinceEpoch += (monthDefs[i]);
      }
      if (_isInputLeapYear && _splitInputDate[0] > 2)
      {
        _daysSinceEpoch += 1;
      }
      //Calculate days * days
      int dayDifference = _splitInputDate[1] - _epoch[1];
      // System.Console.WriteLine("Day Difference: " + dayDifference);
      _daysSinceEpoch += dayDifference;
    }

    public string GetDayOfWeek()
    {
      return _daysOfWeek[_daysSinceEpoch % 7];
    }
  }
}
