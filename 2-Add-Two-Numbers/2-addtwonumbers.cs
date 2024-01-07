public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


// Minha primeira solução

public class Solution
{
    BigInteger[] v1 = new BigInteger[] { };
    BigInteger[] v2 = new BigInteger[] { };

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;

        if (l1 != null)
        {
            v1 = v1.Append<BigInteger>(l1.val).ToArray<BigInteger>();
        }
        if (l2 != null)
        {
            v2 = v2.Append<BigInteger>(l2.val).ToArray<BigInteger>();
        }

        if ((l1 != null && l1.next != null) || (l2 != null && l2.next != null))
        {
            head = AddTwoNumbers(l1?.next, l2?.next);
        }
        else
        {
            BigInteger sum1 = 0;
            BigInteger sum2 = 0;

            Array.Reverse(v1);

            sum1 = BigInteger.Parse(string.Join("", v1));

            Array.Reverse(v2);

            sum2 = BigInteger.Parse(string.Join("", v2));

            BigInteger totalSum = sum1 + sum2;
            char[] totalChar = totalSum.ToString().ToCharArray();

            head = new ListNode(totalChar[totalChar.Length - 1] - '0');
            ListNode current = head;

            for (int i = (totalChar.Length - 1); i != 0; i--)
            {
                current.next = new ListNode(totalChar[i - 1] - '0');
                current = current.next;
            }
        }

        return head;
    }
}

// Adicionei essa solução para estudo pois, utilizei várias funções embutidas sem necessidade 

// public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
//          var sur = 0;
//         var head = new ListNode(0);
//         var dum = head;
//         while (l1 != null || l2 != null || sur > 0)
//         {
//             if (l1 != null)
//             {
//                 sur += l1.val;
//                 l1 = l1.next;
//             }

//             if (l2 != null)
//             {
//                 sur += l2.val;
//                 l2 = l2.next;
//             }
//             head.next = new ListNode(sur % 10);
//             head = head.next;
//             sur /= 10;
//         }
//         return dum.next;  
//     }