var l1n3 = new ListNode(5);
var l1n2 = new ListNode(5/*, l1n3*/);
var l1 = new ListNode(0, l1n2);

var l2n3 = new ListNode(5);
var l2n2 = new ListNode(5/*, l2n3*/);
var l2 = new ListNode(0, l2n2);

Console.WriteLine(new Solution().AddTwoNumbers(l1n3, l2n3));

