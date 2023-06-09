public abstract class Vegetable : Food
{
    private int growPercent = 0;
    public int GrowPercent
    {
        get => growPercent;
        set
        {
            growPercent = value;
            if (growPercent > 100)
            {
                growPercent = 100;
            }
        }
    }

    public abstract void AddPercent();
}
