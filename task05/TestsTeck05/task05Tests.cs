using NUnit.Framework;

namespace TestsTeck05
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(1, 5, 0.0001, ExpectedResult = 1)]
		[TestCase(8, 3, 0.0001, ExpectedResult = 2)]
		[TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
		[TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
		[TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
		[TestCase(0.0081, 4, 0.0001, ExpectedResult = 0.3)]
		[TestCase(-0.008, 3, 0.001, ExpectedResult = -0.2)]
		[TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
		public double TestFindNthRoot(double num, int root, double eps)
		{
			var abc = new task05.task();

			return abc.FindNthRoot(num, root, eps);
		}
		[Test]
		public void TestBubbleSort()
		{
			var abc = new task05.task();

			int[][] a = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
			
			int[][] expected = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

			int[][] actual =  abc.BubbleSort(a, 1);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TestBubbleSort_2()
		{
			var abc = new task05.task();

			int[][] a = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

			int[][] expected = new int[][] { new int[] { 7, 8, 9 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 } };

			int[][] actual = abc.BubbleSort(a, -1);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TestBubbleSort_3()
		{
			var abc = new task05.task();

			int[][] a = new int[][] { new int[] { 1, 2, 30 }, new int[] { 4, 5, 6 }, new int[] { 7, 28, 9 } };

			int[][] expected = new int[][] { new int[] { 4, 5, 6 }, new int[] { 7, 28, 9 }, new int[] { 1, 2, 30 } };

			int[][] actual = abc.BubbleSort(a, 2);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TestBubbleSort_4()
		{
			var abc = new task05.task();

			int[][] a = new int[][] { new int[] { 1, 2, 30 }, new int[] { 4, 5, 6 }, new int[] { 7, 28, 9 } };

			int[][] expected = new int[][] { new int[] { 1, 2, 30 }, new int[] { 7, 28, 9 }, new int[] { 4, 5, 6 }, };

			int[][] actual = abc.BubbleSort(a, -2);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TestBubbleSort_5()
		{
			var abc = new task05.task();

			int[][] a = new int[][] { new int[] { 1, 2, 30 }, new int[] { 4, 5, 6 }, new int[] { 7, 28, 9 } };

			int[][] expected = new int[][] { new int[] { 1, 2, 30 }, new int[] { 4, 5, 6 }, new int[] { 7, 28, 9 }, };

			int[][] actual = abc.BubbleSort(a, 3);

			Assert.AreEqual(expected, actual);
		}
	}
}