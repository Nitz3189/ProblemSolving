namespace PracticeDSA
{
  public class CountTheTeamLeetCode1395
  {

    //    There are n soldiers standing in a line.Each soldier is assigned a unique rating value.

    //You have to form a team of 3 soldiers amongst them under the following rules:

    //Choose 3 soldiers with index (i, j, k) with rating (rating[i], rating[j], rating[k]).
    //A team is valid if: (rating[i] < rating[j] < rating[k]) or(rating[i] > rating[j] > rating[k]) where(0 <= i<j<k<n).
    //Return the number of teams you can form given the conditions. (soldiers can be part of multiple teams).

    //Input: rating = [2,5,3,4,1]
    //Output: 3
    //Explanation: We can form three teams given the conditions. (2,3,4), (5,4,1), (5,3,1). 
    public static int CountTheTeams(int[] ratings)
    {
      int count = 0;
      var length = ratings.Length;
      for(int i =0;i<length;i++)
      {
        int[] left = new int[2];
        int[] right = new int[2];
        for (int j=0;j<length;j++)
        {
          if (ratings[i] > ratings[j])
            ++left[i > j ? 0 : 1];
          if (ratings[j] > ratings[i])
            ++right[j > i ? 1 : 0];
        }
        count += left[0] * right[1] + right[0] * left[1];
      }

      return count;
    }
  }
}
