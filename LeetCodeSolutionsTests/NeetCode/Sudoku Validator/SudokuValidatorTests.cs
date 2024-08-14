﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Sudoku_Validator.Tests
{
    [TestClass()]
    public class SudokuValidatorTests
    {
        [TestMethod()]
        public void validateRowsTest()
        {
            char[][] board = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '8', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            char[][] invalidBoard1 = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '4', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '1', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            char[][] invalidBoard2 = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '8', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            char[][] invalidBoard3 = new char[][]
                           {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '8', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '0', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                           };

            SudokuValidator.validateRows(board).Should().BeTrue();
            SudokuValidator.validateRows(invalidBoard1).Should().BeFalse();
            SudokuValidator.validateRows(invalidBoard2).Should().BeTrue();
            SudokuValidator.validateRows(invalidBoard3).Should().BeFalse();
        }

        [TestMethod()]
        public void validateColumnsTest()
        {
            char[][] board = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '8', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            char[][] invalidBoard = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '1', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '1', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            SudokuValidator.validateColumns(board).Should().BeTrue();
            SudokuValidator.validateColumns(invalidBoard).Should().BeFalse();
        }

        [TestMethod()]
        public void validateSubBoxes()
        {
            char[][] board = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '8', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            char[][] invalidBoard = new char[][]
                            {
                                new char[] { '1', '2', '.', '.', '3', '.', '.', '.', '.' },
                                new char[] { '4', '.', '.', '5', '.', '.', '.', '.', '.' },
                                new char[] { '.', '9', '1', '.', '.', '.', '.', '.', '3' },
                                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '4' },
                                new char[] { '.', '.', '.', '8', '.', '3', '.', '.', '5' },
                                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                                new char[] { '.', '.', '.', '.', '.', '.', '2', '.', '.' },
                                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '8' },
                                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                            };

            SudokuValidator.validateSubBoxes(board).Should().BeTrue();
            SudokuValidator.validateSubBoxes(invalidBoard).Should().BeFalse();
        }

        [TestMethod()]
        public void validateSudoku()
        {
            char[][] board = new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            SudokuValidator.IsValidSudoku(board).Should().BeTrue();

        }

    }
}