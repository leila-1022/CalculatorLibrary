namespace CalculatorLibrary.Models
{

    public class Numbers
    {
        public List<int> nums { get; set; }

        public decimal average
        {
            get
            {
                var sum = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += nums[i];
                }

                return (decimal)sum / nums.Count;
            }
        }

        public void Add(int item)
        {
            nums.Add(item);
        }

        public Numbers()
        {
            nums = new List<int>();
        }
    }
}