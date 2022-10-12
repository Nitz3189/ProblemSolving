using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal class Class1
  {


    public int CalculateDayDifference(String date1, String date2)
    {
      var firstDate = GetDate(date1);
      var secondDate = GetDate(date2);

      var firstDateDaysUntilYearsEnd = GetDaysUntilYearEnds(firstDate);
      var secondDateDaysUntilYearsEnd = GetDaysUntilYearEnds(secondDate);

      var daysDifference = firstDateDaysUntilYearsEnd - secondDateDaysUntilYearsEnd;
      if (firstDate.Year != secondDate.Year)
      {
        daysDifference += firstDate.Year < secondDate.Year ? YearDiffInDays(firstDate.Year, secondDate.Year) :
          YearDiffInDays(secondDate.Year, firstDate.Year);
      }
      return daysDifference;
    }

    public Date GetDate(string date)
    {
      var dateArr = date.Split('-');
      var dateObj = new Date()
      {
        Day = Convert.ToInt32(dateArr[0]),
        Month = Convert.ToInt32(dateArr[1]),
        Year = Convert.ToInt32(dateArr[2])
      };
      return dateObj;
    }
    public int GetDaysUntilYearEnds(Date date)
    {
      int daysUntillYearEnd = getDaysInMonth(date.Month, date.Year) - date.Day;
      int monthpart = date.Month + 1;
      while (monthpart <= 12)
      {
        daysUntillYearEnd += getDaysInMonth(monthpart, date.Year);
        monthpart++;
      }
      return daysUntillYearEnd;
    }

    public int  getDaysInMonth(int month, int yearPart)
    {
      switch (month)
      {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12: 
          return 31;
        case 4:
        case 6:
        case 9:
        case 11:
          return 30;
        case 2:
          {
            if (IsLeapYears(yearPart))
              return 29;
            else return 28;
          }
          default : return 0;
      }
            
    }

    private bool IsLeapYears(int yearPart)
    {
      if (yearPart % 400 == 0)
        return true;
      if (yearPart % 100 == 0)
        return false;
      if (yearPart % 4 == 0)
        return true;
      return false;
    }

    public int YearDiffInDays(int year1, int year2)
    {
      int totalDays = 0;
      while (year1 < year2)
      {
        if (IsLeapYears(year1))
        {
          totalDays += 366;
        }
        else totalDays += 365;
        year1++;
      }
      return totalDays;
    }
  }
  public class Date
  {
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

  }
}
