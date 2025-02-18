using System.Collections.Generic;

namespace CalculatorLibrary.Models
{

    public class Numbers
    {
        public List<int> nums { get; set; }

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