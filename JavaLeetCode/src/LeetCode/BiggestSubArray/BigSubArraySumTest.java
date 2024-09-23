package LeetCode.BiggestSubArray;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

class BigSubArraySumTest {

    @Test
    void getSubArraySumLengthTest() {

        assertThat(BigSubArraySum.getSubArraySumLength(new int[] {5,4,1,1,1,1,1,1}, 14)).isEqualTo(7);

    }
}