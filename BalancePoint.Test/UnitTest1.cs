namespace BalancePoint.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestEmptyArray()
        {
            var solution = new Solution();
            Assert.AreEqual(-1, solution.BalancePoint(new int[] { }));
        }

        [Test]
        public void TestOneElementArray()
        {
            var solution = new Solution();
            Assert.AreEqual(-1, solution.BalancePoint(new int[] { 1 }));
        }

        [Test]
        public void TestTwoElementArray()
        {
            var solution = new Solution();
            Assert.AreEqual(-1, solution.BalancePoint(new int[] { 1, 1 }));
        }

        [Test]
        public void TestThreeElementArray()
        {
            var solution = new Solution();
            Assert.AreEqual(1, solution.BalancePoint(new int[] { 1, 1, 1 }));
        }

        [Test]
        public void TestArraySample0()
        {
            var solution = new Solution();
            Assert.AreEqual(1, solution.BalancePoint(new int[] { 10, 7, 5, 5 }));
        }


        [Test]
        public void TestArraySample1()
        {
            var solution = new Solution();
            Assert.AreEqual(3, solution.BalancePoint(new int[] { 2, 7, 4, 5, -3, 8, 9, -1 }));
        }

        [Test]
        public void TestArraySample2()
        {
            var solution = new Solution();
            Assert.AreEqual(-1, solution.BalancePoint(new int[] { 10, 7, 5, 6 }));
        }

        [Test]
        [TestCase(new int[] { 10, 7, 5, 6 }, -1)]
        public void UnitTestCase(int[] input, int expected)
        {
            var solution = new Solution();
            Assert.That(solution.BalancePoint(input), Is.EqualTo(expected));
        }



    }
}