using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inventory_control
{
    class clsTools
    {
        public string encodingString = "ASDSERR~__~";

        public string formatInputString(string input)
        {
            return input.Trim().Replace("'", "''").ToString();
        }

        public string encryptString(string input)
        {
            string s1 = encodingString + input;
            return base64Encode(s1);
        }

        public string decryptString(string input)
        {
            string s1 = base64Decode(input);
            return s1.Replace(encodingString, "");
        }

        public string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }

        public string base64Decode(string data)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();

                byte[] todecode_byte = Convert.FromBase64String(data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Decode" + e.Message);
            }
        }
    }
}
