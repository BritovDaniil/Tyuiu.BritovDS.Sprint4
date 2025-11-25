using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BritovDS.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array) =>
            Enumerable.Range(0, array.GetLength(0))
                .Select(i => array[i, array.GetLength(1) - 1])
                .Min();
    }
}