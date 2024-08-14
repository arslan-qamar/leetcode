using System.Text;

namespace LeetCodeSolutions.NeetCode.Encode_Decode_Strings
{
    public class EncodeDecode
    {

        public static string Encode(IList<string> strs)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string str in strs)
            {
                stringBuilder.Append($"{str.Length}#").Append(str);
            }

            return stringBuilder.ToString();
        }

        public static List<string> Decode(string s)
        {
            List<string> words = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                int lastDelimiterIndex = s.IndexOf('#', i);

                int charsToRead = int.Parse(s.Substring(i, lastDelimiterIndex - i));

                string word = s.Substring(lastDelimiterIndex + 1, charsToRead);

                words.Add(word);

                i = lastDelimiterIndex + charsToRead;
            }
            return words;
        }

    }
}
