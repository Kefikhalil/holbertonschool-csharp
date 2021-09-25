
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
		public T value;
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

  ///<summary>delete the last node</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			tail.value = head.value;
			head = head.next;
			count--;
			return tail.value;
		}
	}
    ///<summary>returns the value of the first node of the queue</summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}
    ///<summary>prints the queue, starting from the head</summary>
	public void Print()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
            tail = head;
            while(tail != null)
            {
			    Console.WriteLine(tail.value);
         	       tail = tail.next;
            }
		}
	}
	///<summary> concatenates all values in the queue only if the queue is of type String or Char</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string s = "";
        Node h = head;
        while (h != null)
        {
            s = s + h.value.ToString();
            if (h != tail && typeof(T) == typeof(string))
                s += h.value;
            h = h.next;
        }
        return (s);
	}
}
