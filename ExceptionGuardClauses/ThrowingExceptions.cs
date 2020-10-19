using System;
using System.Globalization;

namespace ExceptionGuardClauses
{
    public static class ThrowingExceptions
    {
        public static int ConvertHexCharToInteger(char c)
        {
            if (int.TryParse($"{c}", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
            {
                return result;
            }

            throw new Exception("c is not a hex char.");
        }

        public static char GetLastCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ApplicationException($"{nameof(str)} is null.");
            }

            return str[^1];
        }

        public static string GenerateUserCode(string code, int day)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception($"{nameof(code)} is null.");
            }

            if (code.Length != 4)
            {
                throw new Exception($"{nameof(code)} has {code.Length} chars.");
            }

            if (day <= 0 || day >= 100)
            {
                throw new ApplicationException($"{nameof(day)} should be greater than zero and less than 100");
            }

            return code + day.ToString(CultureInfo.InvariantCulture);
        }

        public static string GenerateGreeting(string hello, string[] addressee, int index)
        {
            if (string.IsNullOrEmpty(hello))
            {
                throw new NullReferenceException($"{nameof(hello)} is null.");
            }

            if (addressee is null)
            {
                throw new NullReferenceException($"{nameof(addressee)} is null.");
            }

            if (addressee.Length == 0)
            {
                throw new ApplicationException($"array is empty");
            }

            if (index < 0 || index >= addressee.Length)
            {
                throw new IndexOutOfRangeException($"{index} is out of range");
            }

            return $"{hello}, {addressee[index]}!";
        }

        public static string GetArrayValue(int[] indexArray, int indexArrayPosition, string[] valueArray)
        {
            if (indexArray is null)
            {
                throw new NullReferenceException($"{nameof(indexArray)} is null");
            }

            if (indexArray.Length == 0)
            {
                throw new InvalidProgramException($"{nameof(indexArray)} is empty.");
            }

            if (valueArray is null)
            {
                throw new NullReferenceException($"{nameof(valueArray)} is null");
            }

            if (valueArray.Length == 0)
            {
                throw new InvalidProgramException($"{nameof(valueArray)} is empty.");
            }

            if (indexArrayPosition < 0 || indexArrayPosition >= indexArray.Length)
            {
                throw new IndexOutOfRangeException($"{nameof(indexArrayPosition)} is out of range.");
            }

            int position = indexArray[indexArrayPosition];

            if (position < 0 || position >= valueArray.Length)
            {
                throw new AccessViolationException("position is out of range.");
            }

            return valueArray[position];
        }
    }
}
