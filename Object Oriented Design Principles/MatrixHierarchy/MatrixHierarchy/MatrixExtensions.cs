using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixHierarchy
{
    public static class MatrixExtensions
    {
        /// <summary>
        /// Extension method which allaws to sum up two matrixes
        /// </summary>
        /// <typeparam name="T">type that closes method</typeparam>
        /// <param name="matrix">matrix whose functions is extended by this method</param>
        /// <param name="other">matrix which is added to existing</param>
        /// <param name="sum">the way of addition</param>
        /// <returns>new matrix which is sum of two matrixes</returns>
        public static BaseMatrix<T> Sum<T>(this BaseMatrix<T> matrix, BaseMatrix<T> other, ISum<T> sum)
        {
            if (ReferenceEquals(other, null))
                throw new ArgumentNullException(nameof(other));

            var result = new Addition<T>(other, sum);
            matrix.Accept(result);
            return result.Result;
        }

    }
}
