public int LengthOfLongestSubstring(string s) {
        int[] indexVisited = new int[128];
			int maxLenght = 0;
			for(int start = 0, end = 0; end < s.Length; end++)
            {
				start = Math.Max(indexVisited[s[end]], start);
				maxLenght = Math.Max(maxLenght, end - start + 1);
				indexVisited[s[end]] = end + 1;
            }
			return maxLenght;
    }
