public class LinkedListBuilderForTesting
{
  public ListNode headerNode = new ListNode();

  public LinkedListBuilderForTesting(int[] listNodes)
  {
    ListNode previousNode = new ListNode(-1);
    for (int i = 0; i < listNodes.Count(); i++)
    {
      var newNode = new ListNode(listNodes[i]);
      previousNode.next = newNode;
      previousNode = newNode;
      if (i == 0)
      {
        headerNode.next = previousNode;
      }
    }
  }
}