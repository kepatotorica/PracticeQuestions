//https://leetcode.com/problems/validate-binary-search-tree/solution/
public class IsValidBSTSolution
{
  public bool IsValidBST(TreeNode root)
  {
    return Validate(root, null, null);
  }

  public bool Validate(TreeNode root, int? small, int? large)
  {
    if (root == null) return true;

    if ((small != null && small >= root.val) || (large != null && root.val >= large)) return false;

    return Validate(root.right, root.val, large) && Validate(root.left, small, root.val);
  }
}