public class TreeBuilderForTesting
{
  public TreeNode RootNode { get; set; }

  public TreeBuilderForTesting(int[] listNodes)
  {
    RootNode = InsertLevelOrder(listNodes, 0);
  }

  public TreeNode InsertLevelOrder(int[] listNodes, int i)
  {
    TreeNode root = null;
    if (i < listNodes.Length)
    {
      root = new TreeNode(listNodes[i]);
      root.left = InsertLevelOrder(listNodes, 2 * i + 1);
      root.right = InsertLevelOrder(listNodes, 2 * i + 2);
    }
    return root;
  }
}