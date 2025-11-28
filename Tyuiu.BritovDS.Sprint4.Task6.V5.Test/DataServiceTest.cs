using Tyuiu.BritovDS.Sprint4.Task6.V5.Lib;

namespace Tyuiu.BritovDS.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCountStringArray()
        {
            DataService ds = new DataService();

            string[] array = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            int result = ds.Calculate(array);
            int expected = 1;

            Assert.AreEqual(expected, result);
        }
    }
}