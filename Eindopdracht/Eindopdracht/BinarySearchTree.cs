using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    public class TreeNode<T>
    {
        // the data the node will contain
        public T data;
        // stores the node on the left
        public TreeNode<T> left;
        // stores the node on the right
        public TreeNode<T> right;

        /// <summary>
        /// Writes the data of this node to the console.
        /// </summary>
        public void displayNode()
        {
            Console.WriteLine(data);
        }

        /// <summary>
        /// Returns the data of this node as a generic T
        /// </summary>
        /// <returns>The data this node contains</returns>
        public T getData()
        {
            return data;
        }
    }

    class BinarySearchTree<T> where T : IComparable
    {
        public TreeNode<T> root;

        public BinarySearchTree()
        {
            // default root is null (nothing) until a node is made
            root = null; 
        }

        /// <summary>
        /// Insert a new node in the binarysearchtree
        /// </summary>
        /// <param name="data"> the data this new node will contain </param>
        public void Insert(T data)
        {
            // create new node
            TreeNode<T> newNode = new TreeNode<T>();
            // add given data to the new node
            newNode.data = data;

            bool go = true;
            try
            {
                // if root doesn't exist, this node will be the root. 
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    // create a temp current node, which holds the root. 
                    TreeNode<T> current = root;
                    // create a temp parent node, which is this node parent 
                    TreeNode<T> parent;

                    // loop through the tree to find a empty spot for the new node
                    while (go)
                    {
                        parent = current;
                        // if the new nodes data is lower than the parent, place it left of the parent
                        if (data.CompareTo(current.data) < 0)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = newNode;
                                // stop looping
                                go = false;
                            }
                        }
                        // if the new nodes data is equal to or higher than the parent, place it right of the parent
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                // stop looping
                                go = false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Order the tree by first printing the left subtree, then printing the root,
        /// and finally printing the right subtree 
        /// </summary>
        /// <param name="theRoot"> the root node of the search tree </param>
        public void inOrder(TreeNode<T> theRoot)
        {
            if(theRoot != null)
            {
                inOrder(theRoot.left);
                theRoot.displayNode();
                inOrder(theRoot.right);
            }
        }

        /// <summary>
        /// 'order' the tree by first printing the root, then the left subtree
        /// and finally the right subtree
        /// </summary>
        /// <param name="theRoot"> the root node of the search tree </param>
        public void preOrder(TreeNode<T> theRoot)
        {
            if (theRoot != null)
            {
                theRoot.displayNode();
                inOrder(theRoot.left);
                inOrder(theRoot.right);
            }
        }

        /// <summary>
        /// 'order' the tree by first printing left subtree, then the right subtree
        /// and finally the root
        /// </summary>
        /// <param name="theRoot"> the root node of the search tree </param>
        public void postOrder(TreeNode<T> theRoot)
        {
            if (theRoot != null)
            {
                inOrder(theRoot.left);
                inOrder(theRoot.right);
                theRoot.displayNode();
            }
        }

        /// <summary>
        /// finds the node with the lowest data and returns the data. 
        /// </summary>
        /// <returns>the lowest data</returns>
        public T findMin()
        {
            // start at the root
            TreeNode<T> current = root;
            // keep selecting the left node while it exists, this will always be the lowest
            while (current.left != null)
            {
                current = current.left;
            }
            return current.data;
        }

        /// <summary>
        /// finds the node with the highest data and returns the data
        /// </summary>
        /// <returns>the highest data</returns>
        public T findMax()
        {
            //start at the root
            TreeNode<T> current = root;
            // keep selecting the right node while it exists, this will always be the highest
            while (current.right != null)
            {
                current = current.right; 
            }
            return current.data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TreeNode<T> find(T key)
        {
            try
            {
                if (root != null)
                {
                    TreeNode<T> current = root;
                    while (current.data.CompareTo(key) != 0)
                    {
                        if (current.data.CompareTo(key) < 0)
                        {
                            current = current.left;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                    return current;
                }
                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
