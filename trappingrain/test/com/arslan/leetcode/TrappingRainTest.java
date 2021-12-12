package com.arslan.leetcode;

import org.junit.jupiter.api.Test;

public class TrappingRainTest {

    @Test
    void test_trappingrain()
    {
        TrappingRain trappingRain = new TrappingRain();

        int result  = trappingRain.calculateTrappedRain(new int[]{2,0,2});

        assert (result == 2);

        result  = trappingRain.calculateTrappedRain(new int[]{3, 0, 2, 0, 4});

        assert (result == 7);

        result  = trappingRain.calculateTrappedRain(new int[]{0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});

        assert (result == 6);

        result  = trappingRain.calculateTrappedRainOptimized(new int[]{2,0,2});

        assert (result == 2);

        result  = trappingRain.calculateTrappedRainOptimized(new int[]{3, 0, 2, 0, 4});

        assert (result == 7);

        result  = trappingRain.calculateTrappedRainOptimized(new int[]{0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});

        assert (result == 6);


    }

}
