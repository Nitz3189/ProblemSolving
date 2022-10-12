namespace PracticeDSA
{
  public class RunningSumProb
  {
    public static int[] RunningSum(int[] nums)
    {
      var length = nums.Length;
      int[] outputs = new int[length];

      int sum = 0;
      for (int i = 0; i < length; i++)
      {
        sum += nums[i];
        outputs[i] = sum;
      }
      return outputs;
    }
  }
}
