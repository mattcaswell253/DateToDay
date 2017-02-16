using System;
using System.Collections.Generic;

 namespace Date.Objects
 {
     public class DayOfChoice
     // ^ this is a object.

     {
       private int _day;
       private int _month;
       private int _year;
       private Dictionary<int, string> _dayList = new Dictionary<int, string>()
       {
         {0, "Sunday"},
         {1, "Monday"},
         {2, "Tuesday"},
         {3, "Wednesday"},
         {4, "Thursday"},
         {5, "Friday"},
         {6, "Saturday"}
       };

       public DayOfChoice(int day, int month, int year)
       //^ this is a constructor of the Day of week object.
       {
         _day = day;
         _month = month;
         _year = year;
       }

       public string SearchForDay()
       // ^ this is the method of the DayOfWeek object.
       {
        //  if(GetMonth() > 8)
        //  {
        //    return AccessDictionary(((GetDay() + 59) + (((((GetMonth() - 3) / 2) + 1) * 31) + (((GetMonth() - 3) / 2) * 30)) + (((((GetMonth() - 8) / 2) + 1) * 31) + (((GetMonth() - 8) / 2) * 30))) % 7);
        //  }
        //  else
         if (GetMonth() < 9 && GetMonth() > 2)
         {
           return AccessDictionary(((GetDay() + 59) + (((((GetMonth() - 3) / 2) + 1) * 31) + (((GetMonth() - 3) / 2) * 30))) % 7);
         }
         else if(GetMonth() == 2)
         {
           return AccessDictionary((GetDay() + 31) % 7);
         }
         else
         {
           return AccessDictionary(GetDay() % 7);
         }
       }

       public int GetDay()
       {
         return _day;
       }

       public int GetYear()
       {
         return _year;
       }

       public int GetMonth()
       {
         return _month;
       }

       public string AccessDictionary(int key)
       {
         return _dayList[key];
       }
     }


 }
