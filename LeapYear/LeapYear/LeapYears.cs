using System;

namespace LeapYear
{
    public static class LeapYears
    {
        public static bool IsLeapYear(int year) {

            if (year % 4 == 0 && ((year>=1581&&(year%100 !=0|| year % 400 == 0)|| year <= 1581))) return true;
            return false;
        }
    }
}
