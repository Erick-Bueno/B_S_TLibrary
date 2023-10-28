namespace B_S_TLibrary;
//welcome
//tree structure
public class BinarySearchTree<T> where T: IComparable<T>
{
    public T NodeValue { get; set; }
    //binary trees have nodes with at most two children
    private BinarySearchTree<T> leftNode { get; set; }
    private BinarySearchTree<T> rightNode { get; set; }

    public BinarySearchTree(T NodeValue)
    {
        this.NodeValue = NodeValue;
        leftNode = null;
        rightNode = null;
    }
    public void Insert(T value)
    {
        if (value.CompareTo(NodeValue) < 0)
        {
            if (leftNode == null)
            {
                leftNode = new BinarySearchTree<T>(value);
                return;
            }
            leftNode.Insert(value);
            return;
        }

        if (rightNode == null)
        {
            rightNode = new BinarySearchTree<T>(value);
            return;
        }

        rightNode.Insert(value);
        return;


    }
    public BinarySearchTree<T> find(T value)
    {
        if (value.Equals(NodeValue))
        {
            return this;
        }
        if (value.CompareTo(NodeValue) < 0 )
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
