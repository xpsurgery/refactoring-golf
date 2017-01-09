using System;
using System.Collections.Generic;

namespace Hole8After
{
	public class Stack<T> {

		private List<T> elements = new List<T>();

		public bool IsEmpty() {
			return elements.Count == 0;
		}

		public int Size() {
			return elements.Count;
		}

		public void Push(T element) {
			elements.Add(element);
		}

		public T Pop() {
			if (IsEmpty())
				throw new IndexOutOfRangeException();
			T element = elements[elements.Count-1];
			elements.RemoveAt(elements.Count - 1);
			return element;
		}

		public T Peek() {
			return elements[elements.Count-1];
		}

		public bool Contains(T elementToFind) {
			for (int i = 0; i < elements.Count; i++) {
				if (elementToFind.Equals(elements[i])) {
					return true;
				}
			}
			return false;
		}

		public int Search(T elementToFind) {
			for (int i = 1; i <= elements.Count; i++) {
				if (elementToFind.Equals(elements[elements.Count - i])) {
					return i;
				}
			}
			return -1;
		}

		public void ReplaceAll(T elementToFind, T newElement) {
			for (int i = elements.Count - 1; i >= 0; i--) {
				if (elementToFind.Equals(elements[i])) {
					elements[i] = newElement;
				}
			}
		}
	}

}
