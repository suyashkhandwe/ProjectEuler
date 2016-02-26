using System;

namespace Problems._50 {
    public class Problem015 : IProblem {
        public void ProblemSolver() {
            const int gridSize = 20;
            var grid = new long[gridSize + 1, gridSize + 1];

            //Initialize the grid with boundary conditions
            for (var row = 0; row < gridSize; row++) {
                grid[row, gridSize] = 1;
                grid[gridSize, row] = 1;
            }
            for (var row = gridSize - 1; row >= 0; row--) {
                for (var col = gridSize - 1; col >= 0; col--) {
                    grid[row, col] = grid[row + 1, col] + grid[row, col + 1];
                }
            }
            Console.WriteLine("Grid size - {0} x {1} : Available paths - {2}", gridSize, gridSize, grid[0, 0]);
        }
    }
}