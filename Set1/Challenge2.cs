using System;
using System.Text;

namespace Set1{
    public class Challenge2
    {
        public static string FixedXOR(string stringOne, string stringTwo)
        {
            byte[] stringOneByteArray = Challenge1.ConvertHexStringToByteArray(stringOne);
            byte[] stringTwoByteArray = Challenge1.ConvertHexStringToByteArray(stringTwo);
            byte[] xorByteArray = new byte[stringOneByteArray.Length];

            for (int i=0; i<stringOneByteArray.Length; i++) {
                xorByteArray[i] = (byte)(stringOneByteArray[i] ^ stringTwoByteArray[i]);
            }

            return ConvertByteArrayToHexString(xorByteArray);
        }

        public static string ConvertByteArrayToHexString(byte[] byteArray)
        {
            StringBuilder hexString = new StringBuilder(byteArray.Length * 2);
            foreach (byte bite in byteArray) {
                hexString.AppendFormat("{0:x2}", bite);
            }
                
            return hexString.ToString();
        }
    }
}