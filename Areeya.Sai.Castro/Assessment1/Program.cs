namespace Assessment1NS
{
    public class Numbers
    {
        private int m_min;
        private int m_max;
        public string m_sorted;
        public string m_notSorted;

        public Numbers(int min, int max)
        {
            m_min = min;
            m_max = max;
        }
        public string Sorted
        {
            get { return m_sorted; }
        }
        public string NotSorted
        {
            get { return m_notSorted; }
        }
        public void NumbersAssessment1(int missingNum)
        {
            Random random = new Random();
            IEnumerable<int> range = Enumerable.Range(m_min, m_max).ToList().Where(x => !x.Equals(missingNum));
            
            //Sorting numbers
            foreach (int num in range)
            {
                m_sorted += num + " ";
            }

            //Shuffle numbers
            range = range.OrderBy(x => random.Next()).ToList();
            foreach (int num in range)
            {
                m_notSorted += num + " ";
            }
        }
        public static void Main()
        {
            Numbers numbers = new Numbers(1, 100);
            int missingNum = new Random((int)DateTime.Now.Ticks).Next(1, 100);
            numbers.NumbersAssessment1(missingNum);
            Console.WriteLine("Missing Number: " + missingNum + "\n");
            Console.WriteLine("Sorted: " + numbers.Sorted + "\n");
            Console.WriteLine("Not Sorted: " + numbers.NotSorted);
        }
    }
}