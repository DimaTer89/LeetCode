public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergeArray = new int[nums1.Length + nums2.Length];
		int arr_1Length = 0;
		int arr_2Length = 0;
		int mergeIndex = 0;
		while(arr_1Length < nums1.Length && arr_2Length < nums2.Length)
        {
			if(nums1[arr_1Length] < nums2[arr_2Length])
				mergeArray[mergeIndex++] = nums1[arr_1Length++];
			else 
				mergeArray[mergeIndex++] = nums2[arr_2Length++];
		}
		if(arr_1Length < nums1.Length)
        {
			while (arr_1Length < nums1.Length)
				mergeArray[mergeIndex++] = nums1[arr_1Length++];
        }
		else
        {
			while (arr_2Length < nums2.Length)
				mergeArray[mergeIndex++] = nums2[arr_2Length++];
        }
		if (mergeArray.Length % 2 == 0)
			return (mergeArray[mergeArray.Length / 2] + mergeArray[mergeArray.Length / 2 - 1]) / 2.0;
		return mergeArray[mergeArray.Length / 2];
    }
