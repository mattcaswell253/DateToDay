using Xunit;
using Date.Objects;
using System;
using System.Collections.Generic;

namespace Date
{
    public class DateTest
    {
        [Fact]
        public void SearchForDay_WhatDayIsIt_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(5, 1, 1900);
          //act
          string day = testDate.SearchForDay();
          //assert
          Assert.Equal(day,"Friday");
        }
        [Fact]
        public void SearchForDay_WhatDayIsItInMonth_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(20, 1, 1900);
          //act
          string day = testDate.SearchForDay();
          //assert
          Assert.Equal(day,"Saturday");
        }
        [Fact]
        public void SearchForDay_WhatDayIsItInFebuary_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(20, 2, 1900);
          //act
          string day = testDate.SearchForDay();
          //assert
          Assert.Equal(day,"Tuesday");
        }

        [Fact]
        public void SearchForDay_WhatDayIsItBetweenMarchAndAugust_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(22, 6, 1900);
          //act
          string day = testDate.SearchForDay();
          //assert
          Assert.Equal(day,"Friday");
        }
        [Fact]
        public void SearchForDay_WhatDayIsItBetweenMarchAndAugust2_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(31, 8, 1900);
          //act
          string day = testDate.SearchForDay();
          //assert
          Assert.Equal(day,"Friday");
        }

        [Fact]
        public void SearchForDay_WhatDayIsItForWholeYear_True()
        {
          //arrange
          DayOfChoice testDate = new DayOfChoice(13, 11, 1900);
          //act
          string day = testDate.SearchForDay();
          Console.WriteLine(day);
          //assert
          Assert.Equal(day,"Tuesday");
        }
    }
}
