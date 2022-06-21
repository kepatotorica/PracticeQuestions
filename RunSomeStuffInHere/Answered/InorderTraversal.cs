//https://leetcode.com/problems/binary-tree-inorder-traversal/

public class InorderTraversalSolution
{
  public IList<int> InorderTraversal(TreeNode root)
  {
    var orderdList = new List<int>();

    TraverseMe(root, orderdList);

    return orderdList;
  }

  public void TraverseMe(TreeNode root, List<int> list)
  {
    if (root != null)
    {
      TraverseMe(root.left, list);
      list.Add(root.val);
      TraverseMe(root.right, list);
    };
  }
}