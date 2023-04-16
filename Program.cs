public class Solution
{
    public double Average00(int[] salary)
    => salary.Where(w => w != salary.Max() && w != salary.Min()).Average(s => s);

    public double Average01(int[] salary)
    {
        double avg = 0;
        foreach (var element in salary)
        {
            avg += element;
        }
        return avg / salary.Length;
    }
}