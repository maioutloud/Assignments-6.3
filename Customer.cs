using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_6._3
{
      /*-----------------------------------*/
     /*          CUSTOMER CLASS           */
    /*-----------------------------------*/
    // class representing Customer properties
    public class Customer   
    {
        public string Name { get; }
        public string PhoneNumber { get; }
        // constructor to initialize customer detail
        public Customer(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
      /*-----------------------------------------------*/
     /*     QUEUE CLASS USING LINKED LIST METHOD      */
    /*-----------------------------------------------*/
    // class representing NODE in the linked list
    class Node
    {
        public Customer value;  // change to Customer class value
        public Node next;
        // constructor to initialize node with customer value and reference to next node
        public Node(Customer value, Node next)  // change to Customer value
        {
            this.value = value;
            this.next = next;
        }
    }
    // class representing Queue of customers
    public class Q
    {
        Node front;     // point to front of Q
        Node rear;      // point to rear of Q
        int size;       // store size of Q
        
        // constructor to initialize Q
        public Q()
        {
            front = null;
            rear = null;
            size = 0;
        }

        // property to get length of Q
        public int Length
        {
            get { return size; }
        }
        
        // property to check if Q is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // method to enqueue
        public void Enqueue(Customer customer)      // changed from integer to Customer class values
        {
            Node newest = new Node(customer, null); // changed to customer
            if(IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }
            rear = newest;
            size++;
        }
        // method to dequeue
        public Customer Dequeue()                   // changed void to Customer
        {
            if(IsEmpty())
            {
                Console.WriteLine("Q is empty");
                return null;
            }
            Customer customer = front.value;        // changed to Customer values
            front = front.next;
            size--;
            if(IsEmpty())
            {
                rear = null;
            }
            return customer;                        // return customer
        }
    }
}
