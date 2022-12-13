namespace linked_list_problem_solution;

public class Node
{
    public string Data { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(string data)
    {
        this.Data = data;
    }
}