using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpgaveFlexyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveFlexyBox.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void ReverseStringTest() // testing for true result
        {
            string input = "this is the text for testing";
            string output = Tools.ReverseString(input);
            string reversed = new string(input.Reverse().ToArray());
            if (output == reversed)
            {
                Assert.IsFalse(false, "String is reversed correctly");
                return;
            }
            Assert.IsFalse(true, "String not reversed");
        }

        [TestMethod()]
        public void IsPalindromeTest()
        {
            string input = "Never odd or even";
            bool output = Tools.IsPalindrome(input);
            if (output)
            {
                Assert.IsFalse(false, "Palindrome found");
                return;
            }
            Assert.IsFalse(true, "Palindrome not found");
        }

        [TestMethod()]
        public void IsNOTPalindromeTest()
        {
            string input = "This is not a palindrome";
            bool output = Tools.IsPalindrome(input);
            if (!output)
            {
                Assert.IsFalse(false, "Found out string wasn't a palindrome");
                return;
            }
            Assert.IsFalse(true, "Failed to notice string wasn't a palindrome");
        }

        [TestMethod()]
        public void MissingElementsTest()
        {
            Dictionary<int[], List<int>> testData = new Dictionary<int[], List<int>>(); // <input, expected>
            testData.Add(new int[] { 4, 6, 9 }, new List<int>() { 5, 7, 8 });
            testData.Add(new int[] { 2, 3, 4 }, new List<int>() { });
            testData.Add(new int[] { 1, 3, 4 }, new List<int>() { 2 });
            testData.Add(new int[] { }, new List<int>() { });

            foreach (var item in testData)
            {
                List<int> output = Tools.MissingElements(item.Key).ToList();
                if (!output.SequenceEqual(item.Value))
                {
                    Assert.IsFalse(true, "Testing failed at input: " + string.Join(",", item.Key));
                    return;
                }
            }
            Assert.IsFalse(false, "All test data passed");
        }
    }
}