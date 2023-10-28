/*
* Name: Wai Lit Yeung 
* Program: Business Information Technology
* Course: ADEV-3009 Data Structure and Algorithms
* MileStone 1: 23 Oct 2023
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestLibrary
{
    public class Queue<T>
    {
        private Node<T> head; // top node in the queue
        private Node<T> tail; // last node in the queue
        private int size; // number of nodes in the queue

        /// <summary>
        /// Stack Class
        /// </summary>
        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Size => size; // size property using expression-bodied member

        public Node<T> Head => head; // head property using expression-bodied member

        public Node<T> Tail => tail; // tail property using express-bodied member

        /// <summary>
        /// IsEmpty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => size == 0;

        /// <summary>
        /// Enqueue
        /// </summary>
        /// <param name="element"></param>
        public void Enqueue(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }

        /// <summary>
        /// Front
        /// </summary>
        /// <returns></returns>
        public T Front()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue is empty");
            }

            return head.Element;
        }

        /// <summary>
        /// Dequeue
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T front = Front();
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            size--;
            return front;
        }

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear() 
        {
            head = null;
            tail = null;
            size = 0;
        }


    }
}
