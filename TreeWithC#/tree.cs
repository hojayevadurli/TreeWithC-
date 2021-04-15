using system;


public class tree {
    static Node root;

    public static void main(string[] args)
    {
        Tree tree=new Tree();
        tree.insert(4);
        tree.insert(5);
        tree.insert(10);
        tree.insert(6);
        tree.insert(7);
        tree.insert(9);
        tree.insert(8);


        TraverseFunction(root);
    }

       public class Node {
        Node Right;
        Node Parent;
        Node Left;
        int container;

        public Node( int container)
        {
            Left=null;
            Right=null;
            Parent =null;
            this.container=container;      
        }
    }


private Node addRecuriveNode ( Node current, int value)
{
    if (current==null)
    {
        current= new Node(value);
    }
    if (value < current.container)
    {
        current.Left=addRecuriveNode(current.Left, value);

    }
    else if(value>current.container)
    {
        current.Right=addRecuriveNode(current.Right, value);
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
   root = addRecuriveNode(root, number);
}

//tree traversal
public static void TraverseFunction(Node Currentnode){
    
    if(Currentnode!=null)
    {
        //moving to the next left node
        TraverseFunction(Currentnode.Left);
        console.writeline(" " + Currentnode.container);
        TraverseFunction(Currentnode.Right);

    }


               
}
}

    



        
    

