//https://leetcode.com/problems/add-two-numbers/

public class AddTwoNumbersAttempt
{
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    var total = GetTotal(l1) + GetTotal(l2);//I need to set this up so it is reversed then put into nodes
    if (total < 10)
    {
      return new ListNode((int)total);
    }
    var tensPlaces = Math.Ceiling(Math.Log10(total)) - 1;
    var positionInNumber = ((long)Math.Pow(10, tensPlaces));
    ListNode previousNode = new ListNode();
    ListNode headerNode = new ListNode(-1);

    for (var i = tensPlaces; i >= 0; i--)
    {
      var numberInTheTensPlace = (int)(total / positionInNumber);
      var currentNode = new ListNode(numberInTheTensPlace);
      total -= numberInTheTensPlace * positionInNumber;
      if (i != tensPlaces)
      {
        currentNode.next = headerNode.next;
      }
      else
      {
        if (numberInTheTensPlace == 10)
        {
          currentNode = new ListNode(0);
          var special10Node = new ListNode(1);
          currentNode.next = special10Node;
        }
      }
      headerNode.next = currentNode;
      positionInNumber /= 10;
    }
    return headerNode.next; //I need to set this up so it is reversed then put into nodes
  }

  public long GetTotal(ListNode listNode)
  {
    long total = 0;
    long multiplier = 1;

    while (listNode.next != null)
    {
      total += multiplier * listNode.val;
      multiplier *= 10;
      listNode = listNode.next;
    }
    total += multiplier * listNode.val;
    return total;
  }
}