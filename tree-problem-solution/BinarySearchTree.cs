using System.Collections;

namespace tree_problem_solution;

public class BinarySearchTree : IEnumerable<int>{
    private Node? _root;

    public void Insert(int value) {

        Node newNode = new Node(value);

        if (_root is null)
            _root = newNode;
        else if (!_root.Contains(value))
        {
            _root.Insert(value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }
}