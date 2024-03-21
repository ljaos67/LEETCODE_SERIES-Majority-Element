public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int e = nums[0];
        int cnt = 1;
        for(int i = 1; i < nums.Count(); i++)
        {
            if(cnt == 0)
            {
                e = nums[i];
                cnt++;
            }
            else
            {
                if(nums[i] == e)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }
            }
        }
        return e;
    }
}
