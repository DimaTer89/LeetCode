public string LongestPalindrome(string s)
    {
        if(s.Length <= 1 )
            return s;
        int startPointer = 0;
	int endPointer = 0;
	int firstLen, secondLen, currentLen = 0, maxLen = 0;
	for(int i=0;i<s.Length;i++)
        {
		firstLen = PalindromSubstring(s, i, i);
		secondLen = PalindromSubstring(s, i, i + 1);
		maxLen = Math.Max(firstLen, secondLen);
		if(maxLen > endPointer - startPointer && maxLen > currentLen)
            	{
			startPointer = i - (maxLen - 1) / 2;
			endPointer = i + maxLen / 2;
                	currentLen = maxLen;
            	}
        }
	return s.Substring(startPointer, currentLen);
    }
    private int PalindromSubstring(string input, int left, int right)
    {
	while((left>=0 && right<input.Length) && input[left]==input[right])
        {
		left--;
		right++;
        }
	return right - left - 1;
    }
