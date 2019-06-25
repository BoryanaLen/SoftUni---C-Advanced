using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public double DifferenceBetweenDates(string dateStart, string dateEnd)
        {
            List<int> firstDateInfo = dateStart.Split().Select(int.Parse).ToList();

            List<int> secondDateInfo = dateEnd.Split().Select(int.Parse).ToList();

            DateTime firstDate = new DateTime(firstDateInfo[0], firstDateInfo[1], firstDateInfo[2]);

            DateTime secondDate = new DateTime(secondDateInfo[0], secondDateInfo[1], secondDateInfo[2]);

            double days = 0;

            if (secondDate > firstDate)
            {
                days = (secondDate - firstDate).TotalDays;
            }
            else
            {
                days = (firstDate-secondDate).TotalDays;
            }


            return days;
        }
    }
}
