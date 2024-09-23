package LeetCode.IsAnagram;

import java.util.HashMap;

public class IsAnagram {


    public static boolean isAnagram(String s, String t) {

        if(s.length() != t.length())
        {
            return false;
        }

        HashMap<Character, Integer> sCharCount = calculateFreq(s);

        HashMap<Character, Integer> tCharCount = calculateFreq(t);

        return sCharCount.equals(tCharCount);
    }

    public static HashMap<Character, Integer> calculateFreq(String t) {
        HashMap<Character, Integer> tCharCount = new HashMap<>();

        for(int i = 0; i < t.length(); i++)
        {
            if(tCharCount.containsKey(t.charAt(i))) {
                tCharCount.put(t.charAt(i), tCharCount.get(t.charAt(i)) + 1);
            }
            else
            {
                tCharCount.put(t.charAt(i), 1);
            }
        }
        return tCharCount;
    }

}
