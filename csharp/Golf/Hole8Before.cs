using System;

namespace Hole8Before
{
	public class Stack<T> {

		private static readonly int INITIAL_CAPACITY = 5;
		private T[] elements = new T[INITIAL_CAPACITY];
		private int count = 0;

		public bool IsEmpty() {
			return count == 0;
		}

		public int Size() {
			return count;
		}

		public void Push(T element) {
			if (count + 1 > elements.Length) {
				T[] temp = new T[2 * elements.Length];
				Array.Copy(elements, temp, elements.Length);
				elements = temp;
			}
			elements[count] = element;
			count++;
		}

		public T Pop() {
			if (IsEmpty())
				throw new IndexOutOfRangeException();
			T element = elements[count - 1];
			count--;
			return element;
		}

		public T Peek() {
			return elements[count - 1];
		}

		public bool Contains(T elementToFind) {
			for (int i = 0; i < count; i++) {
				if (elementToFind.Equals(elements[i])) {
					return true;
				}
			}
			return false;
		}

		public int Search(T elementToFind) {
			for (int i = 1; i <= count; i++) {
				if (elementToFind.Equals(elements[count - i])) {
					return i;
				}
			}
			return -1;
		}

		public void ReplaceAll(T elementToFind, T newElement) {
			for (int i = count - 1; i >= 0; i--) {
				if (elementToFind.Equals(elements[i])) {
					elements[i] = newElement;
				}
			}
		}
	}

}
