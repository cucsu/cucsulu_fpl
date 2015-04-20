using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Web;
using System.Net;
using System.Management;

namespace FPlus
{
    public static class Utilities
    {
        #region old
        private static Random _random;
        private static string _asciiIndex = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static Regex _isGuid = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);

        public static bool IsGuid(string candidate, out Guid output)
        {
            bool isValid = false;
            output = Guid.Empty;
            if (candidate != null)
            {
                if (_isGuid.IsMatch(candidate))
                {
                    output = new Guid(candidate);
                    isValid = true;
                }
            }
            return isValid;
        }

        public static bool IsGuid(string candidate)
        {
            bool isValid = false;
            if (candidate != null)
            {
                if (_isGuid.IsMatch(candidate))
                {
                    isValid = true;
                }
            }
            return isValid;
        }
        public static string trimInputSearch(string inputText)
        {
            inputText = inputText.Trim();
            string[] s = inputText.Split(' ');
            string result = "";
            foreach (string item in s)
            {
                if (item.Length > 0)
                    result += item.Trim() + " ";
            }
            return result.Trim();
        }
        public static string IdToAlpha(long id, int padUp)
        {
            char[] arrAsciiIndex = _asciiIndex.ToCharArray();
            int baseLength = _asciiIndex.Length;
            padUp--;
            if (padUp > 0)
            {
                id += (long)System.Math.Pow(baseLength, padUp);
            }
            StringBuilder outAlpha = new StringBuilder("");
            for (long t = (long)System.Math.Floor(System.Math.Log10(id) / System.Math.Log10(baseLength)); t >= 0; t--)
            {
                long a = (long)System.Math.Floor(id / System.Math.Pow(baseLength, t));
                outAlpha.Append(arrAsciiIndex[a].ToString());
                id = id - (a * (long)System.Math.Pow(baseLength, t));
            }
            return ReverseString(outAlpha.ToString());
        }

        public static long AlphaToId(string alphaStr, int padUp)
        {
            int baseLength = _asciiIndex.Length;
            string inStr = ReverseString(alphaStr);
            long outId = 0;
            int len = inStr.Length - 1;

            for (int t = 0; t <= len; t++)
            {
                long pow = (long)System.Math.Pow(baseLength, len - t);
                outId = outId + _asciiIndex.IndexOf(inStr.Substring(t, 1)) * pow;
            }

            padUp--;
            if (padUp > 0)
            {
                outId -= (long)System.Math.Pow(baseLength, padUp);
            }
            return outId;
        }

        public static string ReplaceAccentedChars(string unicodeString)
        {
            var strFormD = unicodeString.Normalize(NormalizationForm.FormD);
            var strBuilder = new StringBuilder();

            for (var index = 0; index < strFormD.Length; index++)
            {
                var uniCategory = CharUnicodeInfo.GetUnicodeCategory(strFormD[index]);
                if (uniCategory != UnicodeCategory.NonSpacingMark)
                {
                    strBuilder.Append(strFormD[index]);
                }
            }
            return (strBuilder.ToString().Normalize(NormalizationForm.FormC));
        }
        public static string RemoveUnicode(string input)
        {
            // UPPER CASE
            input = input.Replace("À", "A");
            input = input.Replace("Á", "A");
            input = input.Replace("Ả", "A");
            input = input.Replace("Ã", "A");
            input = input.Replace("Ạ", "A");

            input = input.Replace("Â", "A");
            input = input.Replace("Ấ", "A");
            input = input.Replace("Ầ", "A");
            input = input.Replace("Ẩ", "A");
            input = input.Replace("Ẫ", "A");
            input = input.Replace("Ậ", "A");

            input = input.Replace("Đ", "D");

            input = input.Replace("È", "E");
            input = input.Replace("É", "E");
            input = input.Replace("Ẻ", "E");
            input = input.Replace("Ẽ", "E");
            input = input.Replace("Ẹ", "E");

            input = input.Replace("Ê", "E");
            input = input.Replace("Ề", "E");
            input = input.Replace("Ế", "E");
            input = input.Replace("Ể", "E");
            input = input.Replace("Ễ", "E");
            input = input.Replace("Ệ", "E");

            input = input.Replace("Ì", "I");
            input = input.Replace("Í", "I");
            input = input.Replace("Ỉ", "I");
            input = input.Replace("Ĩ", "I");
            input = input.Replace("Ị", "I");

            input = input.Replace("Ò", "O");
            input = input.Replace("Ó", "O");
            input = input.Replace("Ỏ", "O");
            input = input.Replace("Õ", "O");
            input = input.Replace("Ọ", "O");

            input = input.Replace("Ô", "O");
            input = input.Replace("Ồ", "O");
            input = input.Replace("Ố", "O");
            input = input.Replace("Ổ", "O");
            input = input.Replace("Ỗ", "O");
            input = input.Replace("Ộ", "O");

            input = input.Replace("Ơ", "O");
            input = input.Replace("Ờ", "O");
            input = input.Replace("Ớ", "O");
            input = input.Replace("Ở", "O");
            input = input.Replace("Ỡ", "O");
            input = input.Replace("Ợ", "O");

            input = input.Replace("Ù", "U");
            input = input.Replace("Ú", "U");
            input = input.Replace("Ủ", "U");
            input = input.Replace("Ũ", "U");
            input = input.Replace("Ụ", "U");

            input = input.Replace("Ư", "U");
            input = input.Replace("Ừ", "U");
            input = input.Replace("Ứ", "U");
            input = input.Replace("Ử", "U");
            input = input.Replace("Ữ", "U");
            input = input.Replace("Ự", "U");

            input = input.Replace("Ỳ", "Y");
            input = input.Replace("Ý", "Y");
            input = input.Replace("Ỷ", "Y");
            input = input.Replace("Ỹ", "Y");
            input = input.Replace("Ỵ", "Y");

            // LOWER CASE
            input = input.Replace("à", "a");
            input = input.Replace("á", "a");
            input = input.Replace("ả", "a");
            input = input.Replace("ã", "a");
            input = input.Replace("ạ", "a");

            input = input.Replace("â", "a");
            input = input.Replace("ấ", "a");
            input = input.Replace("ầ", "a");
            input = input.Replace("ẩ", "a");
            input = input.Replace("ẫ", "a");
            input = input.Replace("ậ", "a");

            input = input.Replace("đ", "d");

            input = input.Replace("è", "e");
            input = input.Replace("é", "e");
            input = input.Replace("ẻ", "e");
            input = input.Replace("ẽ", "e");
            input = input.Replace("ẹ", "e");

            input = input.Replace("ê", "e");
            input = input.Replace("ề", "e");
            input = input.Replace("ế", "e");
            input = input.Replace("ể", "e");
            input = input.Replace("ễ", "e");
            input = input.Replace("ệ", "e");

            input = input.Replace("ì", "i");
            input = input.Replace("í", "i");
            input = input.Replace("ỉ", "i");
            input = input.Replace("ĩ", "i");
            input = input.Replace("ị", "i");

            input = input.Replace("ò", "o");
            input = input.Replace("ó", "o");
            input = input.Replace("ỏ", "o");
            input = input.Replace("õ", "o");
            input = input.Replace("ọ", "o");

            input = input.Replace("ô", "o");
            input = input.Replace("ồ", "o");
            input = input.Replace("ố", "o");
            input = input.Replace("ổ", "o");
            input = input.Replace("ỗ", "o");
            input = input.Replace("ộ", "o");

            input = input.Replace("ơ", "o");
            input = input.Replace("ờ", "o");
            input = input.Replace("ớ", "o");
            input = input.Replace("ở", "o");
            input = input.Replace("ỡ", "o");
            input = input.Replace("ợ", "o");

            input = input.Replace("ù", "u");
            input = input.Replace("ú", "u");
            input = input.Replace("ủ", "u");
            input = input.Replace("ũ", "u");
            input = input.Replace("ụ", "u");

            input = input.Replace("ư", "u");
            input = input.Replace("ừ", "u");
            input = input.Replace("ứ", "u");
            input = input.Replace("ử", "u");
            input = input.Replace("ữ", "u");
            input = input.Replace("ự", "u");

            input = input.Replace("ỳ", "y");
            input = input.Replace("ý", "y");
            input = input.Replace("ỷ", "y");
            input = input.Replace("ỹ", "y");
            input = input.Replace("ỵ", "y");
            return input;
        }
        public static string ToHexa(byte[] data)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < data.Length; i++)
                sb.AppendFormat("{0:X2}", data[i]);
            return sb.ToString();
        }

        public static string ToMd5(string data)
        {
            var md5 = new MD5CryptoServiceProvider();
            var encode = new UTF8Encoding();
            var hash = md5.ComputeHash(encode.GetBytes(data));
            return ToHexa(hash);
        }

        public static string Md5Encode(string data)
        {
            var md5Str = ToMd5(data);
            return md5Str.ToLower();
        }

        public static string ReverseString(string str)
        {
            char[] arrStr = str.ToCharArray();
            Array.Reverse(arrStr);
            return new string(arrStr);
        }

        private static bool IsEmptyObject(object source)
        {
            if (source == null ||
                String.IsNullOrEmpty(source.ToString()) ||
                (source is DBNull))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SerializeObject(object obj)
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            formatter.Serialize(stream, obj);
            var serializedString = Convert.ToBase64String(stream.ToArray());
            stream.Close();
            return serializedString;
        }

        public static object UnSerialize(string serializedString)
        {
            object obj = null;
            var formatter = new BinaryFormatter();
            byte[] data = (serializedString.Length > 0) ? Convert.FromBase64String(serializedString) : null;
            if (data != null)
            {
                MemoryStream stream = new MemoryStream(data);
                obj = formatter.Deserialize(stream);
                stream.Close();
            }
            return obj;
        }

        static Utilities()
        {
            DateTime dtCurrTime = DateTime.Now;
            int ms = dtCurrTime.Millisecond;
            int sc = dtCurrTime.Second;

            _random = new Random(ms * sc);
        }

        private static CultureInfo CultureEnglish()
        {

            return new CultureInfo("en-US");
        }

        private static CultureInfo CultureVietnamese()
        {

            return new CultureInfo("vi-VN");
        }

        private static string ReplaceEngNumberStirng(string number)
        {
            return number.Replace(',', '.');
        }

        public static int CountOccurrencesInString(string source, char value)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
                if (source[i] == value)
                    count++;
            return count;
        }

        public static int CountOccurrencesInString(string source, string subString)
        {
            int count = 0;
            int curIndex = 0;
            do
            {
                curIndex = source.IndexOf(subString, curIndex);
                if (curIndex != -1)
                {
                    count++;
                    curIndex += subString.Length;
                }
            }
            while (curIndex != -1);

            return count;
        }

        public static string[] SplitString(string source, params char[] separators)
        {
            string[] list = source.Split(separators,
                StringSplitOptions.RemoveEmptyEntries);
            ArrayList array = new ArrayList();
            foreach (string item in list)
            {
                if (item != null)
                {
                    string trimmed = item.Trim();
                    if (trimmed.Length > 0)
                        array.Add(trimmed);
                }
            }

            string[] result = new string[array.Count];
            array.CopyTo(result);
            return result;
        }

        public static string ConvertToString(object source)
        {
            if (IsEmptyObject(source))
                return String.Empty;
            else
                return source.ToString();
        }

        public static string ConvertToString(object source, string defaultValue)
        {
            if (IsEmptyObject(source))
                return defaultValue;
            else
                return source.ToString();
        }

        public static bool ConvertToBoolean(object source)
        {
            if (IsEmptyObject(source))
                return false;
            else
                return Convert.ToBoolean(source);
        }

        public static bool ConvertToBoolean(object source, bool defaultValue)
        {
            if (IsEmptyObject(source))
                return defaultValue;
            else
                return Convert.ToBoolean(source);
        }

        public static string ConvertToYesNo(object source)
        {
            if (IsEmptyObject(source))
                return "No";
            else
                return Convert.ToBoolean(source) ? "Yes" : "No";
        }

        public static string ConvertToYN(object source)
        {
            if (IsEmptyObject(source))
                return "N";
            else
                return Convert.ToBoolean(source) ? "Y" : "N";
        }

        public static decimal ConvertToDecimal(object source)
        {
            if (IsEmptyObject(source))
                return 0.0m;
            else
                return Convert.ToDecimal(source);
        }

        public static double ConvertToDouble(object source)
        {
            if (IsEmptyObject(source))
                return 0.0;
            else
                return Convert.ToDouble(source);
        }

        public static int ConvertToInt32(object source)
        {
            if (IsEmptyObject(source))
                return 0;
            else
                return Convert.ToInt32(source);
        }

        public static int RandomNumber(int limit)
        {
            int num = _random.Next(1, limit + 1);
            return num;
        }

        public static string RandomLettersOrDigits(int length)
        {
            Random r = new Random();

            string result = "";

            int valueOfBigA = Char.ConvertToUtf32("A", 0);
            int valueOfSmallA = Char.ConvertToUtf32("a", 0);
            for (int i = 0; i < length; i++)
            {
                int random = Utilities.RandomNumber(61);
                if (random <= 10)
                {
                    result += (random - 1).ToString();
                }
                else if (random <= 36)
                {
                    result += Char.ConvertFromUtf32(valueOfBigA + random - 11);
                }
                else
                {
                    result += Char.ConvertFromUtf32(valueOfSmallA + random - 37);
                }
            }

            return result;
        }

        public static string GetNameByLength(string name, int length)
        {
            if (name.Length <= length)
                return name;
            else
                return name.Substring(0, length) + "..";
        }

        public static string RandomNumberNDigits(int N)
        {
            Random r = new Random();
            string randomNumber = "";
            string num = "";
            for (int i = 1; i < N + 1; i++)
            {
                num = r.Next(0, 9).ToString();
                randomNumber += num;
            }
            return randomNumber;
        }

        public static bool IsStringInArray(string[] array, string text, bool ignoreCase)
        {
            if (array != null)
            {
                foreach (string content in array)
                {
                    if (String.Compare(content, text, ignoreCase) == 0)
                        return true;
                }
            }

            return false;
        }

        public static DateTime ConvertStringToDateTime(String datetime)
        {
            DateTime temp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.AddHours(1).Hour, 0, 0);
            try
            {
                if (!String.IsNullOrEmpty(datetime))
                {
                    temp = Convert.ToDateTime(datetime);
                }
                return temp;
            }
            catch (Exception)
            {
                return temp;
            }
        }
        public static Double ConvertStringToDoubleEnglish(string number)
        {
            return Convert.ToDouble(ReplaceEngNumberStirng(number), CultureEnglish());
        }

        public static Decimal ConvertStringToDecimalEnglish(string number)
        {
            return Convert.ToDecimal(ReplaceEngNumberStirng(number), CultureEnglish());
        }

        public static String RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        public static void FitImageInBox(Stream theImage, Int32 maxWidth, Int32 maxheight, string fullSavePath)
        {
            int intNewWidth;
            int intNewHeight;
            int qQuality = 80;
            Image inputImage = Image.FromStream(theImage);
            if (maxWidth < inputImage.Width || maxheight < inputImage.Height)
            {
                if (maxWidth >= maxheight)
                {
                    intNewWidth = ((int)((((double)(maxheight)) * (((double)(inputImage.Width)) / ((double)(inputImage.Height))))));
                    intNewHeight = maxheight;
                }
                else
                {
                    intNewWidth = maxWidth;
                    intNewHeight = ((int)((((double)(maxWidth)) * (((double)(inputImage.Height)) / ((double)(inputImage.Width))))));
                }
                if (intNewWidth > maxWidth)
                {
                    intNewWidth = maxWidth;
                    intNewHeight = ((int)((((double)(maxWidth)) * (((double)(inputImage.Height)) / ((double)(inputImage.Width))))));
                }
                if (intNewHeight > maxheight)
                {
                    intNewWidth = ((int)((((double)(maxheight)) * (((double)(inputImage.Width)) / ((double)(inputImage.Height))))));
                    intNewHeight = maxheight;
                }
            }
            else
            {
                intNewWidth = inputImage.Width;
                intNewHeight = inputImage.Height;
            }
            try
            {
                Bitmap outputBitMap = new Bitmap(inputImage, intNewWidth, intNewHeight);
                inputImage.Dispose();
                EncoderParameters eps = new EncoderParameters(1);
                eps.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qQuality);
                ImageCodecInfo ici = GetEncoderInfo("image/jpeg");
                outputBitMap.Save(fullSavePath, ici, eps);
                outputBitMap.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            j = 0;
            while (j < encoders.Length)
            {
                if (encoders[j].MimeType == mimeType)
                {
                    return encoders[j];
                }
                Interlocked.Increment(ref j);
            }
            return null;
        }
#endregion
        public static string GetHtml(string Url)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "GET";
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string str = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return str;
            }
            catch
            {
                return "";
            }
        }
        public static string GetCpuId()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            return Utilities.ToMd5(id);
        }
    }
}
