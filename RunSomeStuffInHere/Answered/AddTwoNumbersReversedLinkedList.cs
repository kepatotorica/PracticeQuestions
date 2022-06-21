//https://leetcode.com/problems/add-two-numbers/

public class AddTwoNumbersReversedLinkedList
{

  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    var list1Done = false;
    var list2Done = false;
    var carryOver = 0;
    var previousNode = new ListNode(-1);
    var pointerToFront = new ListNode(-100);
    while (!list1Done || !list2Done)
    {
      var list1Value = 0;
      var list2Value = 0;
      if (l1.next == null && !list1Done)
      {
        list1Value = l1.val;
        list1Done = true;
      }
      else if (l1.next != null)
      {
        list1Value = l1.val;
        l1 = l1.next;
      }

      if (l2.next == null && !list2Done)
      {
        list2Value = l2.val;
        list2Done = true;
      }
      else if (l2.next != null)
      {
        list2Value = l2.val;
        l2 = l2.next;
      }
      var thisSpotValue = list1Value + list2Value + carryOver;
      carryOver = thisSpotValue / 10;
      thisSpotValue = thisSpotValue % 10;

      if (previousNode.val == -1)
      {
        previousNode = new ListNode(thisSpotValue);
        pointerToFront.next = previousNode;

      }
      else
      {
        previousNode.next = new ListNode(thisSpotValue);
        previousNode = previousNode.next;
      }
    }
    if (carryOver != 0)
    {
      previousNode.next = new ListNode(carryOver);
      previousNode = previousNode.next;
    }

    return pointerToFront.next;
  }
}