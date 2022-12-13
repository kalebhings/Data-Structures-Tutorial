using System.Collections;

namespace linked_list_problem_solution;

public class LinkedList : IEnumerable<string>
{
    private Node? _head;
    private Node? _tail;
    
    public void InsertHead(string value)
    {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else
        {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
    }

    public void InsertTail(string value)
    {
        // Create new node
        Node newNode = new Node(value);

        // If list is empty, point both head and tail to the new node.
        if (_tail is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, only the tail is affected.
        else
        {
            newNode.Prev = _tail; // Connect prev of the new node to the current tail
            _tail.Next = newNode; // Connect the next of the current tail to the new node
            _tail = newNode; // Update the tail to point to the new node
        }
    }
    
    public void InsertAfter(string value, string newValue)
    {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                // If the location of 'value' is at the end of the list,
                // then we can call insert_tail to add 'new_value'
                if (curr == _tail)
                {
                    InsertTail(newValue);
                }
                // For any other location of 'value', need to create a 
                // new node and reconnect the links to insert.
                else
                {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; // Connect new node to the node containing 'value'
                    newNode.Next = curr.Next; // Connect new node to the node after 'value'
                    curr.Next!.Prev = newNode; // Connect node after 'value' to the new node
                    curr.Next = newNode; // Connect the node containing 'value' to the new node
                }

                return; // We can exit the function after we insert
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }
    }
    
    public void RemoveHead()
    {
        // If the list has only one item in it, then set head and tail 
        // to null resulting in an empty list.  This condition will also
        // cover an empty list.  Its okay to set to null again.
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        // If the list has more than one item in it, then only the head
        // will be affected.
        else if (_head is not null)
        {
            _head.Next!.Prev = null; // Disconnect the second node from the first node
            _head = _head.Next; // Update the head to point to the second node
        }
    }
    
    public void RemoveTail()
    {
        if (_tail == _head)
        {
            _tail = null;
            _head = null;
        }
        else if (_tail is not null)
        {
            _tail.Prev!.Next = null;
            _tail = _tail.Prev;
        }
    }
    
    public void Remove(string value)
    {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                if (curr.Next is null) // If it's the last value, then we just remove the last value
                {
                    RemoveTail();
                    return;
                }
                else if (curr.Prev is null) // If it's the first value, just remove the head.
                {
                    RemoveHead();
                    return;
                }

                // Otherwise we remove the value from the middle and connect it accordingly
                curr.Next!.Prev = curr.Prev;
                curr.Prev!.Next = curr.Next;
                return; 
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }

    }
    
    public void Replace(string oldValue, string newValue)
    {
        // TODO Problem 4
        // Search for the node that matches 'oldValue' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == oldValue)
            {
                InsertAfter(oldValue, newValue);
                Remove(oldValue);
            }

            curr = curr.Next; // Go to the next node to search for 'oldValue'
        }
    }

    public IEnumerable Reverse()
    {
        Node? curr = _tail;
        while (curr is not null)
        { 
            yield return curr.Data;      
            curr = curr.Prev;
        }
    }

    public IEnumerator<string> GetEnumerator()
    {
        Node? curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr is not null)
        {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}