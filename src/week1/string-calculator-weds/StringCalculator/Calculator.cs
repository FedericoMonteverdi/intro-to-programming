using System.Text;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "") {
            return 0;
        }
        
        if (numbers.Length > 0 && numbers.Length < 10 && !numbers.Contains(",") && !numbers.Contains("\n"))
        {
            return int.Parse(numbers);
        }

        char[] delimeters = new char[] { ',', '\n' };

        if (numbers.Contains(","))
        {
            string[] parts = numbers.Split(',');
            int sum = 0;
            foreach (string part in parts)
            {
                sum += int.Parse(part);
            }
            return sum;
        }


        return 0;
    }
}
