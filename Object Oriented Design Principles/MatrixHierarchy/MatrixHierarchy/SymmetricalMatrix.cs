using System;

namespace MatrixHierarchy
{
    public class SymmetricalMatrix<T> : BaseMatrix<T>
    {
        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="size"></param>
        public SymmetricalMatrix(int size) : base(size)
        {
        }

        public SymmetricalMatrix(int size, T[,] array) : base(size, array)
        {
        }

        /// <summary>
        /// Checks a possibility to create symmetric matrix
        /// </summary>
        /// <param name="size">size of matrix</param>
        /// <param name="array">existing matrix</param>
        /// <returns>true in case possibility to create symmetric matrix based on existing matrix else false</returns>
        public override bool CheckExist(int size, T[,] array)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));

            if (Math.Sqrt(array.Length) != size)
                return false;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (!Equals(array[i, j], array[j, i]))
                        return false;

            return true;
        }

        protected override void Info(object sender, MatrixEventArgs e) => Console.WriteLine($"Symmetric matrix[{e.Rows},{e.Columns}] is changed !");
    }
}