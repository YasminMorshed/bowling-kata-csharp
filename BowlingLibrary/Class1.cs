namespace UtilityLibraries;
public static class BowlingLibrary
{
    public static int CalculateScore(string bowlingString)
    {
        int score = 0;
        int frameIndex = 0;
        // int frame = 1;
        int roll = 1;
        int bonus = 0;
        foreach (char c in bowlingString)
        {
            if (c == 'X')
            {
                score += 10;
                frameIndex++;
                roll = 1;
                bonus = 0;
            }
            else if (c == '/')
            {
                score += 10 - bonus;
                frameIndex++;
                roll = 1;
                bonus = 0;
            }
            else if (c == '-')
            {
                frameIndex++;
                roll = 1;
                bonus = 0;
            }
            else
            {
                score += c - '0';
                if (roll == 1)
                {
                    bonus = c - '0';
                }
                else
                {
                    score += bonus;
                    bonus = 0;
                }
                roll++;
                if (roll > 2)
                {
                    frameIndex++;
                    roll = 1;
                }
            }
            if (frameIndex > 10)
            {
                break;
            }
        }
        return score;
    }

}
