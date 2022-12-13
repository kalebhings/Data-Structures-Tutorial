namespace tree_problem_solution;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }
    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2

        if (Data == value)
        {
            return true;
        }
        else if (Right is not null && Left is not null)
        {
            if (Right.Contains(value) || Left.Contains(value))
            {
                return true;
            }
        
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4

        int rHeight = 0;
        int lHeight = 0;
        
        if (Left is not null)
        {
            lHeight = Left.GetHeight();
        }

        if (Right is not null)
        {
            rHeight = Right.GetHeight();
        }
        return 1+ Math.Max(rHeight, lHeight);
    }
}