using System;
///<summary>Queue Class </summary>
class Queue<T>
{
	public int count;
	public Node head;
	public Node tail;

///<summary>Checks if its a queue type </summary>

	public Type CheckType()
	{
		return typeof(T);
	}
	public class Node
	{
		private T value;
		public Node next = null;

		public Node(T q)
		{
			value = q;

		}
	}
	///<summary>ENqueue</summary>
	public void Enqueue(T value)
	{
		Node newnode = new Node(value);
		if (head == null)
		{
			head = newnode;
			tail = newnode;
		}
		else
		{
			tail.next = newnode;
			tail = newnode;
		}
		count++;
	}

	///<summary> count </summary>
	public int Count()
	{
		return count;
	}


}
