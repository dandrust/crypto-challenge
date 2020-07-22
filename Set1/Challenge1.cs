using System;
using System.Collections.Generic;

namespace Set1
{
    public class Challenge1
    {
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            var bytes = new List<byte>();
            
            for (int i=0; i<hexString.Length; i+=2) {
                // Isolate chunk of 2 characters
                string hexChunk = hexString.Substring(i, 2);
                // Convert pairs of hex to a byte, add to list
                bytes.Add(Convert.ToByte(hexChunk, 16));
            }

            return bytes.ToArray();
        }

        public static string HexToBase64(string hexString)
        {
            return Convert.ToBase64String(
                ConvertHexStringToByteArray(hexString)
            );
        }
    }
}
