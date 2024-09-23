package LeetCode.Tries;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;


import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

@ExtendWith(MockitoExtension.class)
class TrieTest {

    @Test
    void getNewTrieNode() {
    }

    @Test
    void insert() {
    }

    @Test
    void search() {
    }


    @Mock
    Trie trieMock;

    @Test
    void findAllWords() {
        Trie trie = new Trie();

        trie.insert("ABC");
        trie.insert("ABD");
        trie.insert("ABE");
        trie.insert("AXE");

        List<String> words = new ArrayList<>();
        Trie.findAllWords(trie, "", words);

        assertThat(words).hasSize(4);
        assertThat(words).containsExactlyInAnyOrder("ABD","ABC", "ABE", "AXE");

        words.clear();
        Trie partialFind = Trie.searchPartial(trie, "AXX");
        Trie.findAllWords(partialFind, "AX", words);
    }
}
