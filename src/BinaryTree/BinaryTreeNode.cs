using System;

namespace Algorithms
{
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public T Value { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }

        public int CompareTo(T value)
        {
            return Value.CompareTo(value);
        }
    }
}
