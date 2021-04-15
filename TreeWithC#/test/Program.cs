using System;


public class tree
{
    static Node root;

    public  static void Main(string[] args)
    {
        tree tree = new tree();
        tree.insert(4);
        tree.insert(5);
        tree.insert(10);
        tree.insert(6);
        tree.insert(7);
        tree.insert(9);
        tree.insert(8);


        TraverseFunction(root);
    }

    public class Node
    {
       public Node Right;
      public  Node Parent;
      public  Node Left;
     public   int container;

        public Node()
        {
        }

        public Node(int container)
        {
            Left = null;
             Right = null;
            Parent = null;
            this.container = container;
        }
    }

 
    public Node AddRecuriveNode(Node current, int value)
    {
        if (current == null)
        {
            current = new Node(value);
        }
        if (value < current.container)
        {
            current.Left = AddRecuriveNode(current.Left, value);

        }
        else if (value > current.container)
        {
            current.Right = AddRecuriveNode(current.Right, value);
        }
        else
        {
            return current;
        }

        return current;


    }

    //inserting the integers
    public void insert(int number)
    {
        root = AddRecuriveNode(root, number);
    }

    //tree traversal
    public static void TraverseFunction(Node Currentnode)
    {

        if (Currentnode != null)
        {
            //moving to the next left node
            TraverseFunction(Currentnode.Left);
            Console.WriteLine(" " + Currentnode.container);
            TraverseFunction(Currentnode.Right);

        }



    }
}








