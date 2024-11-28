using Tyuiu.KonstantinovaJN.Sprint1.TaskReview.V9.Lib;

namespace Tyuiu.KonstantinovaJN.Spprint1.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6.090;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}