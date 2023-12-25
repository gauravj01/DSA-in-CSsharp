using DSA_in_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class BinarySearchTree
    {
        public TreeNode root;
        public int leftHeight = 0;
        public int rightHeight = 0;
        public void insert(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                insertNode(root, value);
            }
        }
        public void insertNode(TreeNode node, int value)
        {
            if(value > node.value)
            {
                if(node.right == null)
                {
                    node.right = new TreeNode(value); ;
                }
                else
                {
                    insertNode(node.right, value);
                }
            }
            else
            {
                if (node.left == null)
                {
                    node.left = new TreeNode(value); ;
                }
                else
                {
                    insertNode(node.left, value);
                }
            }
        }
        public void remove(int value)
        {
            if(root == null) {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                removeNode(root, value);
            }
        }
        public void removeNode(TreeNode node,int value)
        {
            //if(value < node.value && node.left != null)
            //{
            //    removeNode(node.left, value);
            //}

            //if(value > node.value && node.right != null)
            //{
            //    removeNode(node.right, value);
            //}
        }
        public void emptyCondition(string operation)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                if (operation == "inorder")
                {
                    inorderTraversal(root);
                }

                if (operation == "preorder")
                {
                    preorderTraversal(root);
                }

                if(operation == "postorder")
                {
                    postorderTravseral(root);
                }
            }
        }
        public void inorderTraversal(TreeNode node)
        {
            if (node.left != null)
            {
                inorderTraversal(node.left);
            }
            Console.Write($"{node.value} ");

            if (node.right != null)
            {
                inorderTraversal(node.right);
            }
        }
        public void preorderTraversal(TreeNode node)
        {
            Console.Write($"{node.value} ");
            if(node.left != null)
            {
                preorderTraversal(node.left);
            }
            if(node.right != null)
            {
                preorderTraversal(node.right);
            }
        }
        public void postorderTravseral(TreeNode node)
        {
            if(node.left != null)
            {
                postorderTravseral(node.left);
            }
            if(node.right != null)
            {
                postorderTravseral(node.right);
            }
            Console.Write($"{node.value} ");
        }
        public int calculateHeight()
        {
            int height = 0;
            if(root != null)
            {
                height = treeHeight(root);
            }
            return height;
        }
        public int treeHeight(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            int leftHeight = treeHeight(node.left);
            int rightHeight = treeHeight(node.right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
}
