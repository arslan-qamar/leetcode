package LeetCode.GroupAnagram;

import org.junit.jupiter.api.Test;

import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;


class GroupAnagramTest {

    @Test
    void groupAnagrams() {

        List<List<String>> expected = List.of(
                List.of("hat"),
                List.of("act", "cat"),
                List.of("stop", "pots", "tops")

        );

        List<List<String>> result =  GroupAnagram.groupAnagrams(new String[]{"act","pots","tops","cat","stop","hat"});

        assertThat(result)
                .usingRecursiveComparison()
                .ignoringCollectionOrder().isEqualTo(expected);
    }
}