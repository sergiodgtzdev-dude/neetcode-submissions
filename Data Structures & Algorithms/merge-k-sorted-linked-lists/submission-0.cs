public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) {
            return null;
        }
        
        ListNode result = null;
        for (int i = 0; i < lists.Length; i++) {
            result = MergeTwoLists(result, lists[i]);
        }
        return result;
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                current.next = l1;
                l1 = l1.next;
            } else {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        
        current.next = (l1 != null) ? l1 : l2;
        return dummy.next;
    }
}