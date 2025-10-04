namespace FirstDuplicateNumber.Helpers
{
    public static class DuplicateFinder
    {
        public static int? FindFirstDuplicate(int[] numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));

            var seen = new HashSet<int>();

            foreach (var num in numbers)
            {
                if (seen.Contains(num))
                {
                    return num;
                }
                seen.Add(num);
            }

            return null;
        }
    }
}
