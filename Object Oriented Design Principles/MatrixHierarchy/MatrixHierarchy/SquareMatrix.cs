using System;

namespace MatrixHierarchy
{
    public class SquareMatrix<T> : BaseMatrix<T>
    {
        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="size"></param>
        public SquareMatrix(int size) : base(size)
        {

        }

        public SquareMatrix(int size, T[,] array) : base(size, array)
        {

        }
        /// <summary>
        /// Check possibility to create square matrix
        /// </summary>
        /// <param name="size"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public override bool CheckExist(int size, T[,] array)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));

            if (Math.Sqrt(array.Length) != size)
                return false;

            return true;
        }
        /// <summary>
        /// Method starts after event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Info(object sender, MatrixEventArgs e) => Console.WriteLine($"Square matrix[{e.Rows},{e.Columns}] is changed !");
    }
}