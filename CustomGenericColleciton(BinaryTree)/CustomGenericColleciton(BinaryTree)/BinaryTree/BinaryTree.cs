using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericColleciton_BinaryTree_.BinaryTree
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public int Count { get; private set; }

        public void Add(T value)
        {
            if (root == null)
            {
                root = new BinaryTreeNode<T> { Value = value };
            }
            else
            {
                AddTo(root, value);
            }

            Count++;
        }
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (Comparer<T>.Default.Compare(value, node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T> { Value = value };
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T> { Value = value };
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public IEnumerable<T> PreOrderTraversal()
        {
            return PreOrderTraversal(root);
        }

        private IEnumerable<T> PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                yield return node.Value;

                foreach (var value in PreOrderTraversal(node.Left))
                {
                    yield return value;
                }

                foreach (var value in PreOrderTraversal(node.Right))
                {
                    yield return value;
                }
            }
        }

        public IEnumerable<T> InOrderTraversal()
        {
            return InOrderTraversal(root);
        }

        private IEnumerable<T> InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                foreach (var value in InOrderTraversal(node.Left))
                {
                    yield return value;
                }
                yield return node.Value;

                foreach (var value in InOrderTraversal(node.Right))
                {
                    yield return value;
                }
            }
        }

        public IEnumerable<T> PostOrderTraversal()
        {
            return PostOrderTraversal(root);
        }

        private IEnumerable<T> PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                foreach (var value in PostOrderTraversal(node.Left))
                {
                    yield return value;
                }

                foreach (var value in PostOrderTraversal(node.Right))
                {
                    yield return value;
                }
                yield return node.Value;
            }
        }
    }
}
