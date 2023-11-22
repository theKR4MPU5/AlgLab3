using System;


class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}


class BinarySearchTree
{
    private Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertRec(root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public bool Search(int data)
    {
        return SearchRec(root, data);
    }

    private bool SearchRec(Node root, int data)
    {
        if (root == null)
        {
            return false;
        }

        if (data == root.Data)
        {
            return true;
        }

        if (data < root.Data)
        {
            return SearchRec(root.Left, data);
        }

        return SearchRec(root.Right, data);
    }

    public void InOrderTraversal()
    {
        InOrderTraversalRec(root);
        Console.WriteLine();
    }

    private void InOrderTraversalRec(Node root)
    {
        if (root != null)
        {
            InOrderTraversalRec(root.Left);
            Console.Write($"{root.Data} ");
            InOrderTraversalRec(root.Right);
        }
    }
}
