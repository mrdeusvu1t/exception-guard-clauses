using System;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo
#pragma warning disable CA1707

namespace ExceptionGuardClauses.Tests
{
    public class ThrowingExceptionsTests
    {
        [TestCase('G')]
        [TestCase('H')]
        [TestCase('Z')]
        public void ConvertHexCharToInteger_CharIsInvalid_ThrowsArgumentException(char c)
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.ConvertHexCharToInteger(c));
        }

        [TestCase('A', ExpectedResult = 10)]
        [TestCase('B', ExpectedResult = 11)]
        [TestCase('F', ExpectedResult = 15)]
        public int ConvertHexCharToInteger_CharIsValid_ReturnsInteger(char c)
        {
            return ThrowingExceptions.ConvertHexCharToInteger(c);
        }

        [Test]
        public void GenerateUserCode_CodeIsNullOrEmpty_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GenerateUserCode(null, 0));
        }

        [Test]
        public void GenerateUserCode_CodeLengthIsNotEqualsFour_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.GenerateUserCode("ABC", 0));
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(101)]
        public void GenerateUserCode_DayIsOutOfRange_ThrowsArgumentOutOfRangeException(int day)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ThrowingExceptions.GenerateUserCode("ABCD", day));
        }

        [TestCase("ABCD", 1, ExpectedResult = "ABCD1")]
        [TestCase("ABCD", 2, ExpectedResult = "ABCD2")]
        [TestCase("ABCD", 99, ExpectedResult = "ABCD99")]
        public string GenerateUserCode_ParametersAreValid_ReturnsUserCode(string code, int day)
        {
            return ThrowingExceptions.GenerateUserCode(code, day);
        }

        [Test]
        public void GetLastCharacter_StrIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GetLastCharacter(null));
        }

        [TestCase("a", ExpectedResult = 'a')]
        [TestCase("ab", ExpectedResult = 'b')]
        [TestCase("abc", ExpectedResult = 'c')]
        public char GetLastCharacter_ValidStr_ReturnsResult(string str)
        {
            return ThrowingExceptions.GetLastCharacter(str);
        }

        [TestCase(null)]
        [TestCase("")]
        public void GenerateGreeting_HelloIsNullOrEmpty_ThrowsArgumentNullException(string hello)
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GenerateGreeting(hello, Array.Empty<string>(), 0));
        }

        [Test]
        public void GenerateGreeting_AddresseeIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GenerateGreeting("Hello", null, 0));
        }

        [Test]
        public void GenerateGreeting_AddresseeIsEmpty_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.GenerateGreeting("Hello", Array.Empty<string>(), 0));
        }

        [TestCase(-1)]
        [TestCase(1)]
        public void GenerateGreeting_IndexIsOutOfRange_ThrowsArgumentNullException(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ThrowingExceptions.GenerateGreeting("Hello", new string[] { "world" }, index));
        }

        [TestCase("Hello", new string[] { "world", "universe" }, 0, ExpectedResult = "Hello, world!")]
        [TestCase("Hi", new string[] { "world", "universe" }, 1, ExpectedResult = "Hi, universe!")]
        public string GenerateGreeting_ParametersAreValid_ReturnsGreeting(string hello, string[] addressee, int index)
        {
            return ThrowingExceptions.GenerateGreeting(hello, addressee, index);
        }

        [Test]
        public void GetArrayValue_IndexArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GetArrayValue(null, 0, Array.Empty<string>()));
        }

        [Test]
        public void GetArrayValue_IndexArrayIsEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.GetArrayValue(Array.Empty<int>(), 0, Array.Empty<string>()));
        }

        [Test]
        public void GetArrayValue_ValueArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ThrowingExceptions.GetArrayValue(new int[] { 0 }, 0, null));
        }

        [Test]
        public void GetArrayValue_ValueArrayIsEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThrowingExceptions.GetArrayValue(new int[] { 0 }, 0, Array.Empty<string>()));
        }

        [TestCase(new int[] { -1 })]
        [TestCase(new int[] { 1 })]
        public void GetArrayValue_IndexArrayPositionIsOutOfRange_ThrowsIndexOutOfRangeException(int[] indexArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() => ThrowingExceptions.GetArrayValue(indexArray, 0, new string[] { "value" }));
        }

        [TestCase(new int[] { 0, 1 }, 0, new string[] { "value1", "value2" }, ExpectedResult = "value1")]
        [TestCase(new int[] { 0, 1 }, 1, new string[] { "value1", "value2" }, ExpectedResult = "value2")]
        public string GetArrayValue_ParametersAreValid_ReturnsValue(int[] indexArray, int indexArrayPosition, string[] valueArray)
        {
            return ThrowingExceptions.GetArrayValue(indexArray, indexArrayPosition, valueArray);
        }
    }
}
