using System.Collections.Generic;

namespace AlgLab3.TaskThree
{
    public class ListExample
    {
        public static List<T> Example<T>(List<T> firstList, List<T> secondList)
        {
            List<T> result = new List<T>();
            foreach (T item in firstList)
            {
                if (secondList.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}