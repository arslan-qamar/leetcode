package LeetCode.GroupAnagram;

import LeetCode.IsAnagram.IsAnagram;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class GroupAnagram {

    public static List<List<String>> groupAnagrams(String[] strs) {

        HashMap<Integer, ArrayList<String>> groupedAnagrams = new HashMap<>();

        for(String str: strs) {

            HashMap<Character, Integer> x = IsAnagram.calculateFreq(str);

            if(groupedAnagrams.containsKey(x.hashCode())) {
                groupedAnagrams.get(x.hashCode()).add(str);
            }
            else
            {
                groupedAnagrams.put(x.hashCode(),new ArrayList<>(List.of(str)));
            }

        }

        return new ArrayList<>(groupedAnagrams.values());
    }
}
