namespace TreesStructures.DataStructures;

public class BinarySearchTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public Node? Root { get; private set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    // Insert a value into the BST
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private Node InsertRecursive(Node? node, int value)
    {
        // If the tree is empty, create a new node
        if (node == null)
        {
            return new Node(value);
        }

        // Otherwise, recursively insert into the appropriate subtree
        if (value < node.Value)
        {
            node.Left = InsertRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = InsertRecursive(node.Right, value);
        }

        // Return the unchanged node pointer
        return node;
    }

    // Search for a value in the BST
    public bool Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(Node? node, int value)
    {
        // Base case: node is null or value is found
        if (node == null)
        {
            return false;
        }

        if (node.Value == value)
        {
            return true;
        }

        // Value is smaller, search in left subtree
        if (value < node.Value)
        {
            return SearchRecursive(node.Left, value);
        }

        // Value is greater, search in right subtree
        return SearchRecursive(node.Right, value);
    }

    // Delete a value from the BST
    public void Delete(int value)
    {
        Root = DeleteRecursive(Root, value);
    }

    private Node? DeleteRecursive(Node? node, int value)
    {
        // Base case: node is null
        if (node == null)
        {
            return null;
        }

        // Recursively find the node to delete
        if (value < node.Value)
        {
            node.Left = DeleteRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = DeleteRecursive(node.Right, value);
        }
        else
        {
            // Node to be deleted found

            // Case 1: Node with no children (leaf node)
            if (node.Left == null && node.Right == null)
            {
                return null;
            }

            // Case 2: Node with one child
            if (node.Left == null)
            {
                return node.Right;
            }

            if (node.Right == null)
            {
                return node.Left;
            }

            // Case 3: Node with two children
            // Find the minimum value in the right subtree (inorder successor)
            int minValue = FindMinValue(node.Right);
            node.Value = minValue;

            // Delete the inorder successor
            node.Right = DeleteRecursive(node.Right, minValue);
        }

        return node;
    }

    private int FindMinValue(Node node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node.Value;
    }

    // In-order traversal (left, root, right) - prints values in sorted order
    public void InOrderTraversal()
    {
        InOrderTraversalRecursive(Root);
        Console.WriteLine();
    }

    private void InOrderTraversalRecursive(Node? node)
    {
        if (node != null)
        {
            InOrderTraversalRecursive(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversalRecursive(node.Right);
        }
    }

    // Pre-order traversal (root, left, right)
    public void PreOrderTraversal()
    {
        PreOrderTraversalRecursive(Root);
        Console.WriteLine();
    }

    private void PreOrderTraversalRecursive(Node? node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrderTraversalRecursive(node.Left);
            PreOrderTraversalRecursive(node.Right);
        }
    }

    // Post-order traversal (left, right, root)
    public void PostOrderTraversal()
    {
        PostOrderTraversalRecursive(Root);
        Console.WriteLine();
    }

    private void PostOrderTraversalRecursive(Node? node)
    {
        if (node != null)
        {
            PostOrderTraversalRecursive(node.Left);
            PostOrderTraversalRecursive(node.Right);
            Console.Write(node.Value + " ");
        }
    }
}