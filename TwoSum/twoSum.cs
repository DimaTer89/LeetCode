public int[] TwoSum(int[] nums, int target) {
        Hashtable digits = new Hashtable();
        int result = 0;
        for(int i=0;i<nums.Length;i++)
        {
            result = target - nums[i];
            if(digits.ContainsKey(result))
                return new []{(int)digits[result],i};
            else
                digits.Add(nums[i],i);
        }
        return new[]{-1,-1};
    }
