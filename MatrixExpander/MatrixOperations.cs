namespace MatrixExpander
{
    public static class MatrixOperations
    {
        public static int[,] Expand(int multiplier, int[,] matrix)
        {
            int newN = matrix.GetLength(0) * multiplier;
            int[,] tmpMatrix = new int[newN, newN];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    tmpMatrix[(row * multiplier), (column * multiplier)] = matrix[row, column];
                    tmpMatrix[(row * multiplier), ((column * multiplier) + 1)] = matrix[row, column];
                    tmpMatrix[(row * multiplier) + 1, (column * multiplier)] = matrix[row, column];
                    tmpMatrix[(row * multiplier) + 1, ((column * multiplier) + 1)] = matrix[row, column];
                }
            }
            return tmpMatrix;
        }
    }
}
