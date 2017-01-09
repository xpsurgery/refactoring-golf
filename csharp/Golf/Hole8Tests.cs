using NUnit.Framework;
using System;

namespace Hole8After
{
	[TestFixture]
	public class Hole8Tests
	{

		[Test]
		public void emptyWhenCreated()
		{
			var stack = new Stack<string>();
			Assert.IsTrue(stack.IsEmpty());
		}

		[Test]
		public void returnTheNumberOfItems()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Push("2");
			Assert.AreEqual(2, stack.Size());
		}

		[Test]
		public void emptyWhenPushAndPopOneItem()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Pop();
			Assert.IsTrue(stack.IsEmpty());
		}

		[Test]
		public void notEmptyWhenPush()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			Assert.IsFalse(stack.IsEmpty());
		}

		[Test]
		public void pushAndPopOneItem()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			Assert.AreEqual("1", stack.Pop());
		}

		[Test]
		public void popTheLastWhenTwoItems()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Push("2");
			Assert.AreEqual("2", stack.Pop());
		}

		[Test]
		public void pushAndPopTwoItems()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Push("2");
			stack.Pop();
			Assert.AreEqual("1", stack.Pop());
		}

		[Test]
		public void returnOneItemWithoutRemovingIt()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Peek();
			Assert.AreEqual("1", stack.Peek());

		}

		[Test]
		public void returnThePositionWhereAnItemExits() {
			var stack = new Stack<string>();
			stack.Push("1");
			stack.Push("2");
			stack.Push("3");
			stack.Push("4");
			Assert.AreEqual(3, stack.Search("2"));
		}

		[Test]
		public void returnMinusOneWhenItemDoesntExits()
		{
			var stack = new Stack<string>();
			Assert.AreEqual(-1, stack.Search("1"));
		}

		[Test]
		public void containAndItemAlreadyPushed()
		{
			var stack = new Stack<string>();
			stack.Push("1");
			Assert.IsTrue(stack.Contains("1"));
		}

		[Test]
		public void notContainAnItemNotPushed()
		{
			var stack = new Stack<string>();
			Assert.IsFalse(stack.Contains("1"));
		}

		[Test]
		public void replaceTheValueOfAnElement()
		{
			var stack = new Stack<string>();
			stack.Push("6");
			stack.Push("2");
			stack.Push("6");
			stack.ReplaceAll("6", "1");
			Assert.AreEqual("1", stack.Pop());
			stack.Pop();
			Assert.AreEqual("1", stack.Pop());
		}

		[Test]
		public void throwExceptionWhenEmptyAndPop()
		{
			var stack = new Stack<string>();
			try
			{
				stack.Pop();
				Assert.Fail();
			}
			catch (IndexOutOfRangeException e)
			{
			}
		}
	}
}
