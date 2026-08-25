# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:

        carry = 0;
        result =[]
        number1 = ""
        number2 = ""
        result = 0
        curr = l1;
        head = ListNode()

        while(curr != None ):
            number1+=str(curr.val)
            curr = curr.next;

        curr = l2;
        while(curr != None ):
            number2+=str(curr.val)
            curr = curr.next

        number1 = "".join(reversed(number1))
        number2 = "".join(reversed(number2))

        print(number1)
        print(number2)

        
        sum = int(number1) + int(number2)
        print(sum)
        r_sum = "".join(reversed(str(sum)))

        curr = head;
        for c in str(r_sum):
            print(curr.val)
            curr.next = ListNode(int(c))
            curr = curr.next

        head = head.next;

        return head;
            
            
           
        

        