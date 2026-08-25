public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>();

        //D = DOUBLE PREVIOUS SCORE
        //+ SUM OF PREVIOUS TWO SCORES
        //C INVALIDATE PREVIOUS SCORE (POP)

        for(int i = 0; i < operations.Length; i++){

            if(operations[i] == "D")
                scores.Add(scores[scores.Count-1] * 2);
            else if(operations[i] == "+")
                scores.Add(scores[scores.Count-1] + scores[scores.Count-2]);
            else if(operations[i] == "C"){
                Console.Write("Last element of scores:" + scores[scores.Count - 1]);
                scores.RemoveAt(scores.Count-1);
            }
            else
                scores.Add(Convert.ToInt32(operations[i]));

            Console.Write("[" + String.Join(" ", scores) + "]\n");
        }

        int sum = 0;
        foreach(int num in scores){
            sum += num;
        }

        return sum;
    }
}

