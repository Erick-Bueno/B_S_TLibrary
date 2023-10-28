namespace B_S_TLibrary;
//tree structure

public class BinarySearchTree
{
    public int NodeValue { get; set; }
    //binary trees have nodes with at most two children
    private BinarySearchTree leftNode { get; set; }
    private BinarySearchTree rightNode { get; set; }

    public BinarySearchTree(int NodeValue)
    {
        this.NodeValue = NodeValue;
        leftNode = null;
        rightNode = null;
    }
    public void Insert(int value)
    {
        if (value < NodeValue)
        {
            if (leftNode == null)
            {
                leftNode = new BinarySearchTree(value);
                return;
            }
            leftNode.Insert(value);
            return;
        }

        if (rightNode == null)
        {
            rightNode = new BinarySearchTree(value);
            return;
        }

        rightNode.Insert(value);
        return;


    }
    public BinarySearchTree find(int value)
    {
        if (value == NodeValue)
        {
            return this;
        }
        if (value < NodeValue)
        {
            if (leftNode != null)
            {
                return leftNode.find(value);
            }
            return null;
            
        }
        if(rightNode != null){
            return rightNode.find(value);
        }
        return null;
    }

 
}