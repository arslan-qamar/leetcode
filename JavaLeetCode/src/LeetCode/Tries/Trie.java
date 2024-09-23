package LeetCode.Tries;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Trie {
    // isEndOfWord is true if the node represents end of a word
    private boolean isEndOfWord;

    /* nodes store a map to child node */
    private HashMap<Character, Trie> map;

    /* function to make a new trie */
    Trie() {
        isEndOfWord = false;
        map = new HashMap<>();
    }

    String mockMethod(String abc){

        return "orginal";
    }

    /* function to insert in trie */
    void insert(String str) {
        Trie temp = this;
        for (int i = 0; i < str.length(); i++) {
            char x = str.charAt(i);

            /* make a new node if there is no path */
            if (!temp.map.containsKey(x))
                temp.map.put(x, new Trie());

            temp = temp.map.get(x);
        }
        temp.isEndOfWord = true;
    }

    /* function to search` in trie */
    static boolean search(Trie root, String str) {
        /* return false if Trie is empty */
        if (root == null)
            return false;

        Trie temp = root;
        for (int i = 0; i < str.length(); i++) {

            /* go to next node */
            if (!temp.map.containsKey(str.charAt(i)))
                return false;

            temp = temp.map.get(str.charAt(i));
        }

        return temp.isEndOfWord;
    }

    static Trie searchPartial(Trie root, String str) {
        /* return false if Trie is empty */
        if (root == null)
            return root;

        Trie temp = root;
        for (int i = 0; i < str.length(); i++) {

            /* go to next node */
            if (!temp.map.containsKey(str.charAt(i)))
                return temp;

            temp = temp.map.get(str.charAt(i));
        }
        return temp;
    }

    /* function to find all matching prefix words in trie */
    static void findAllWords(Trie root, String word, List<String> words) {
        /* return false if Trie is empty */
        if (root == null)
            return;

        if (root.isEndOfWord) {
            words.add(word);
            return;
        }

        for(Map.Entry<Character, Trie> r : root.map.entrySet())
        {
            findAllWords(r.getValue(), word + r.getKey(), words);
        }
    }

    /*Driver function*/

}

