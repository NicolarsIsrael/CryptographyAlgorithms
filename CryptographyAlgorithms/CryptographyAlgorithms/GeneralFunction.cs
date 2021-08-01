using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography.Algorithms
{
    public class GeneralFunction
    {
        public string ByteArrayToString(byte[] byteValue)
        {
            return BitConverter.ToString(byteValue).Replace("-", string.Empty);
        }

        public byte[] StringToByteArray(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        public string ConvertToText(byte[] hash)
        {
            string cipherText = "";
            for (int i = 0; i < 8; ++i)
                cipherText = cipherText + hash[i] + "x2";

            return cipherText;
        }

        public T[][] ToJaggedArray<T>(T[,] twoDimensionalArray)
        {
            int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
            int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
            int numberOfRows = rowsLastIndex + 1;

            int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
            int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
            int numberOfColumns = columnsLastIndex + 1;

            T[][] jaggedArray = new T[numberOfRows][];

            for (int i = rowsFirstIndex; i <= rowsLastIndex; i++)
            {
                jaggedArray[i] = new T[numberOfColumns];

                for (int j = columnsFirstIndex; j <= columnsLastIndex; j++)
                {
                    jaggedArray[i][j] = twoDimensionalArray[i, j];
                }
            }

            return jaggedArray;
        }

        public bool ValidateHexadecimal(string hex)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(hex, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    }
}
