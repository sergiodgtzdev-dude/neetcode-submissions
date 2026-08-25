/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode l1 = list1;
        ListNode l2 = list2;
        ListNode curr = head;

        while(l1 != null && l2 != null)
        {

            if(l1.val <= l2.val)
            {
                curr.next = l1;
                l1 = l1.next;
                curr = curr.next;
            }
            else if(l2.val < l1.val)
            {
                curr.next = l2;
                l2 = l2.next;
                curr = curr.next;
            }   
        }

         
        if(l1 != null)
        {
            curr.next = l1;
        }

        if(l2 != null)
        {
            curr.next = l2;
        }

        return head.next;
    }
}