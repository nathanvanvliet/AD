/*
 *      AUTEUR: Nathan van Vliet 
 *      SOURCE: McMillan, M. (2007). Data Structures and Algorithms Using C#. Cambridge, Groot-Brittannië: Cambridge University Press
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
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

    public class BinarySearchTree<T> where T : IComparable
    {
        public TreeNode<T> root;

        List<TreeNode<T>> nodes = new List<TreeNode<T>>();
        //fallback for catches with a T return
        T fail = default(T);
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
            try
            {
                // if there is a root
                if (theRoot != null)
                {
                    // print left
                    inOrder(theRoot.left);
                    // print root
                    nodes.Add(theRoot);
                    // print right
                    inOrder(theRoot.right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// 'order' the tree by first printing the root, then the left subtree
        /// and finally the right subtree
        /// </summary>
        /// <param name="theRoot"> the root node of the search tree </param>
        public void preOrder(TreeNode<T> theRoot)
        {
            try
            {
                // if there is a root 
                if (theRoot != null)
                {
                    // print root
                    nodes.Add(theRoot);
                    // print left
                    inOrder(theRoot.left);
                    // print right 
                    inOrder(theRoot.right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// 'order' the tree by first printing left subtree, then the right subtree
        /// and finally the root
        /// </summary>
        /// <param name="theRoot"> the root node of the search tree </param>
        public void postOrder(TreeNode<T> theRoot)
        {
            try
            {
                // if there is a root
                if (theRoot != null)
                {
                    // print left
                    inOrder(theRoot.left);
                    // print right
                    inOrder(theRoot.right);
                    // print root
                    nodes.Add(theRoot);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// finds the node with the lowest data and returns the data. 
        /// </summary>
        /// <returns>the lowest data</returns>
        public T findMin()
        {
            try
            {
                // start at the root
                TreeNode<T> current = root;
                if (current != null)
                {
                    // keep selecting the left node while it exists, this will always be the lowest
                    while (current.left != null)
                    {
                        current = current.left;
                    }
                    return current.data;
                }
                else
                {
                    return fail;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return fail;
            }
        }

        /// <summary>
        /// finds the node with the highest data and returns the data
        /// </summary>
        /// <returns>the highest data</returns>
        public T findMax()
        {
            try
            {
                //start at the root
                TreeNode<T> current = root;
                if (current != null)
                {
                    // keep selecting the right node while it exists, this will always be the highest
                    while (current.right != null)
                    {
                        current = current.right;
                    }
                    return current.data;
                }
                else
                {
                    return fail;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return fail;
            }

        }

        /// <summary>
        /// Find and return the node containing specific data
        /// </summary>
        /// <param name="key"> the data to be searched for </param>
        /// <returns>the node containing the data</returns>
        public TreeNode<T> find(T key)
        {
            try
            {
                if (root != null)
                {
                    // start at root
                    TreeNode<T> current = root;
                    // keep searching as long as node data does not match key
                    while (current.data.CompareTo(key) != 0)
                    {
                        // if the data is bigger than the key, search the left node
                        if (current.data.CompareTo(key) > 0)
                        {
                            current = current.left;
                        }
                        // if data is smaller than the key, search right node
                        else
                        {
                            current = current.right;
                        }
                        if (current == null)
                        {
                            // if nothing is found, return null
                            return null;
                        }
                    }
                    // return node
                    return current;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(TreeNode<T>);
            }
        }

        /// <summary>
        /// Delete the node with the given key
        /// </summary>
        /// <param name="key"> data of the node to be deleted </param>
        /// <returns>true if deleting was succesful, false if it wasn't </returns>
        public bool delete(T key)
        {
            TreeNode<T> current = root;
            TreeNode<T> parent = root;
            bool isLeftChild = true;
            try
            {
                while (current.data.CompareTo(key) != 0) //loop until the selected Node is found.
                {
                    parent = current;
                    if (current.data.CompareTo(key) > 0) // if the current node is a left node
                    {
                        isLeftChild = true;
                        current = current.right;
                    }
                    else // if it is a right node
                    {
                        isLeftChild = false;
                        current = current.right;
                    }
                    if (current == null) // the end is reached, no more nodes to check and nothing found
                    {
                        return false;
                    }
                }
                //the node is found.
                if (current.left == null && current.right == null) // if there are no more node further down
                {
                    if (current == root) // + AND the current is the root. (only a root without other nodes.)
                    {
                        root = null; //unset the root
                    }
                    else if (isLeftChild) // if the node is a leftnode (child)
                    {
                        parent.left = null; //delete this node and all other node below
                    }
                    else
                    {
                        parent.right = null;  //delete this node and all other node below
                    }
                }
                //if the node is a left node and there is no right node.
                else if (current.right == null) //if only the right node is empty
                {
                    if (current == root) // + AND the current is the root.
                    {
                        root = current.left; // the left node of the current is the root
                    }
                    else if (isLeftChild) //if the current is a left node
                    {
                        parent.left = current.left; //all children are assigned to the current node parent (unsetting the current)
                    }
                    else //if it is a right node of the parent
                    {
                        parent.right = current.right; //all children are assigned to the current node parent (unsetting the current)
                    }
                }
                //there is a right node but no left
                else if (current.left == null) //if there is only a right node
                {
                    if (current == root) // + AND the current is also the root
                    {
                        root = current.right; //unset the root by setting the right node as the root
                    }
                    else if (isLeftChild) // if this is the left node of the parent
                    {
                        parent.left = current.right; // swap the parents left and current right (balance the tree)
                    }
                    else
                    {
                        parent.right = current.right; // unset the current by assigning the children of the current to the parent
                    }
                }
                else
                {
                    TreeNode<T> successor = GetSuccessor(current); // get the successor of the current node
                    if (current == root) // if the current is the root
                    {
                        root = successor; //replace the root with the successor
                    }
                    else if (isLeftChild) // if the current is a left child of the parent
                    {
                        parent.left = successor; // set the make the current the sucessor (unsetting the current)
                    }
                    else
                    {
                        parent.right = successor; //if it is a right node of the parent, set the successor as the parent right node (unsetting the current)
                    }
                    successor.left = current.left; //set the left of the successor to the current left node
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Find node to replace the node to be deleted
        /// </summary>
        /// <param name="delNode"> node to be deleted </param>
        /// <returns>the node to replace the node to be deleted </returns>
        private TreeNode<T> GetSuccessor(TreeNode<T> delNode)
        {
            try
            {
                TreeNode<T> successorParent = delNode;
                TreeNode<T> successor = delNode;
                TreeNode<T> current = delNode.right;
                while (current != null)  //loop until the current is empty

                {
                    successorParent = current; //my parent is the current
                    successor = current; // my successor is the current also
                    current = current.left; // now my current is my left node
                }
                if (successor != delNode.right) //if my successor is not the right node of the parameter node
                {
                    successorParent.left = successor.right; //set the left node of my parent as the successor right node
                    successor.right = delNode.right; // the right node of my successor is the parameters node's right node
                }
                return successor; //return the successor
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default(TreeNode<T>);
            }
        }


        // Methods after this comment are just for testing and getting the nodes to the Form

        /// <summary>
        /// return the root node, for test purposes
        /// </summary>
        /// <returns>the root node</returns>
        public TreeNode<T> returnRoot()
        {
            try
            {
                return root;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // returns defauls when a error occurs
                return default(TreeNode<T>);
            }
        }


        /// <summary>
        /// clear the local list, this list is for test purposes
        /// </summary>
        public void clearList()
        {
            nodes.Clear();
        }

        /// <summary>
        /// add all nodes to the list, for test purposes. 
        /// </summary>
        /// <param name="node"> root node</param>
        public void getNodes(TreeNode<T> node)
        {
            try
            {
                if (node != null)
                {
                    nodes.Add(node);
                }
                if (node.left != null)
                {
                    getNodes(node.left);
                }
                if (node.right != null)
                {
                    getNodes(node.right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// get the local node list, for test purposes
        /// </summary>
        /// <returns> the node list </returns>
        public List<TreeNode<T>> getList()
        {
            try
            {
                return nodes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default(List<TreeNode<T>>);
            }
        }
    }
}
