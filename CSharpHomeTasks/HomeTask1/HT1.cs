/*
In this task you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
Examples:
ListFilterer.GetIntegersFromList(new List<object>(){1,2,'a','b'}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1,2,'a','b',0,15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){(1,2,'a','b','aasf','1','123',231}) => {1, 2, 231}
*/


using NUnit.Framework;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharpHomeTask
{
    public class HT1
    {
        [OneTimeSetUp]
        public static void BeforeAllTests()
        {
            Debug.WriteLine("Running action before all test");
        }

        [Test]
        public void Test1_NoIntegerInList()
        {
            var list = new List<object>() { "a", "b", "x", "y" };
            var expectedResult = new List<object>() { };
            var result = GetIntegersFromList(list);


            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_MixedList()
        {
            var list = new List<object>() { "E", "Hello", "7", 7, 8, 9 };
            var expectedResult = new List<object>() { 7, 8, 9 };
            var result = GetIntegersFromList(list);


            Assert.AreEqual(expectedResult, result);
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> intList = listOfItems
                  .Where(i => i.GetType() == typeof(int))
                  .Select(i => Convert.ToInt32(i))
                  .ToList();
            return intList;
        }

    }
}