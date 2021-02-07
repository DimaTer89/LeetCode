public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode newListNode = new ListNode();
		ListNode firstNode = l1;
		ListNode secondNode = l2;
		ListNode currentNode = newListNode;
		int oneDigit, twoDigit, result;
		int remainder = 0;
		while (firstNode != null || secondNode != null)
        {
			oneDigit = firstNode != null ? firstNode.val : 0;
			twoDigit = secondNode != null ? secondNode.val : 0;
			result = remainder + oneDigit + twoDigit;
			remainder = result / 10;
			currentNode.next = new ListNode(result % 10);
			currentNode = currentNode.next;
			if (firstNode != null) firstNode = firstNode.next;
			if (secondNode != null) secondNode = secondNode.next;
        }
		if (remainder > 0)
			currentNode.next = new ListNode(remainder);
		return newListNode.next;
    }
