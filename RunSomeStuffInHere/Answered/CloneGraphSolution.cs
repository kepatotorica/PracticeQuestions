// https://leetcode.com/problems/clone-graph/

public class CloneGraphSolution
{
  Dictionary<Node, Node> nodeMap = new Dictionary<Node, Node>();

  public Node CloneGraph(Node node)
  {
    if (node == null) return null;

    CopyNodes(node);

    return nodeMap[node];
  }
  private Node CopyNodes(Node node)
  {
    var nodeExists = nodeMap.TryGetValue(node, out var copiedNode);//Try to get the current node from our list

    if (!nodeExists)
    {
      copiedNode = new Node(node.val, new List<Node>());//If we don't have a node yet, add it to our list.
      nodeMap.Add(node, copiedNode);

      foreach (var neighbor in node.neighbors)//For all of the original neighbors go through the list
      {
        var neighborIsInList = nodeMap.TryGetValue(neighbor, out var neighborToAdd);//check to see if our neighbor exists yet
        if (!neighborIsInList)
        {
          neighborToAdd = CopyNodes(neighbor);//Otherwise we need to add the neighbor to the list.
        }
        Console.WriteLine($"node {copiedNode.val} : {neighborToAdd.val}");
        copiedNode.neighbors.Add(neighborToAdd);
      }
      return copiedNode;
    }
    return copiedNode;
  }
}