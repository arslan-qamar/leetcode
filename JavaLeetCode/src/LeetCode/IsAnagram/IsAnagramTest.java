package LeetCode.IsAnagram;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

class IsAnagramTest {

    @Test
    void isAnagram() {

        assertThat(IsAnagram.isAnagram("abcd", "dcba")).isTrue();
        assertThat(IsAnagram.isAnagram("abcd", "dcb")).isFalse();
        assertThat(IsAnagram.isAnagram("racecar", "carrace")).isTrue();
    }
}