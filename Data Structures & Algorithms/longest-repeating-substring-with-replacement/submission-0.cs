public class Solution {
    public int CharacterReplacement(string s, int k) {
                int l = 0;
        int res = 0;
        var freqMap = new Dictionary<char,int>();

        for (int r=0; r < s.Length; r++)
        {
            if (freqMap.ContainsKey(s[r]))
            {
                freqMap[s[r]]++;
            }
            else
            {
                freqMap.Add(s[r], 1);
            }

            if (r - l + 1 - freqMap.Values.Max() > k)
            {
                freqMap[s[l]]--;
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
