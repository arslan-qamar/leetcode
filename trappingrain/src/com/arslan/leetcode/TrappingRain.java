package com.arslan.leetcode;

public class TrappingRain {


    public int calculateTrappedRainOptimized(int[] blockHeights) {

        int[] left = scanHeightFromLeft(blockHeights);

        int[] right = scanHeightFromRight(blockHeights);

        return calculateAccumulatedWater(blockHeights, left, right);

    }

    private int calculateAccumulatedWater(int[] blockHeights, int[] left, int[] right) {

        int waterAccumulated = 0;

        for (int i = 0; i < blockHeights.length; i++) {

            waterAccumulated += Math.min(left[i], right[i]) - blockHeights[i];
        }

        return  waterAccumulated;
    }

    private int[] scanHeightFromRight(int[] blockHeights) {
        int[] heightsPattern = new int[blockHeights.length];

        int highestSoFar = 0;
        for (int i = blockHeights.length - 1; i >= 0; i--) {

            if(blockHeights[i] > highestSoFar) {
                highestSoFar = blockHeights[i];
            }

            heightsPattern[i] = highestSoFar;
        }

        return heightsPattern;
    }

    private int[] scanHeightFromLeft(int[] blockHeights) {
        int[] heightsPattern = new int[blockHeights.length];

        int highestSoFar = 0;
        for (int i = 0; i < blockHeights.length; i++) {

            if(blockHeights[i] > highestSoFar) {
                highestSoFar = blockHeights[i];
            }

            heightsPattern[i] = highestSoFar;
        }

        return heightsPattern;
    }


    public int calculateTrappedRain(int[] blockHeights) {
        int tallestBlockSize = findTallestBlockSize(blockHeights);

        int[][] blockStructure = createBlockStructure(tallestBlockSize, blockHeights);

        return calculateRainTrapped(blockStructure);
    }


    private int calculateRainTrapped(int[][] blockStructure) {

        int validWaterCount = 0;

        for (int row = 0; row < blockStructure.length; row++) {
            int wall = 0;

            int possibleWaterCount = 0;

            for (int col = 0; col < blockStructure[0].length; col++) {

                if (blockStructure[row][col] == 1 && wall == 0) {
                    wall = 1;
                    continue;
                }

                if (blockStructure[row][col] == 0 && wall == 1) {
                    possibleWaterCount++;
                    continue;
                }

                if (blockStructure[row][col] == 1 && wall == 1) {
                    validWaterCount = validWaterCount + possibleWaterCount;
                    possibleWaterCount = 0;
                }
            }
        }
        return validWaterCount;
    }


    private int[][] createBlockStructure(int tallestBlockSize, int[] blockHeights) {

        int[][] blockStructure = new int[tallestBlockSize][blockHeights.length];

        for (int i = 0; i < blockHeights.length; i++) {
            for (int fill = tallestBlockSize - blockHeights[i]; fill < tallestBlockSize; fill++) {
                blockStructure[fill][i] = 1;
            }
        }

        return blockStructure;
    }

    private int findTallestBlockSize(int[] arr) {

        int tallestBlockSize = 1;

        for (int blockSize :  arr) {

            if (blockSize > tallestBlockSize)
                tallestBlockSize = blockSize;
        }

        return tallestBlockSize;
    }


}
