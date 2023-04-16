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

    public double Average0(int[] salary)
    {

        double sum = salary[0];
        double max = salary[0];
        double min = salary[0];

        for (int i = 1; i < salary.Length; i++)
        {
            if (salary[i] > max)
            {
                max = salary[i];
            }
            else if (salary[i] < min)
            {
                min = salary[i];
            }

            sum += salary[i];
        }

        double avergae = (sum - max - min) / (salary.Length - 2);

        return avergae;
    }
}