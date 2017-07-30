using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;
        private int _count;

        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddNode(_head, value);
            }

            _count++;
        }

        public void AddNode(BinaryTreeNode<T> node, T value)
        {
            if (node.Value.CompareTo(value) > 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddNode(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddNode(node.Right, value);
                }
            }
        }

        public BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            var current = _head;
            if (current.Value.CompareTo(value) > 0)
            {
                
            }
           else if (current.Value.CompareTo(value) < 0)
           {
               
           }
           else
           {
               
           }

        }
        public void RemoveNode(T value)
        {

        }
    }
}
