using AlgLab3.Structures;

namespace AlgLab3.TaskThree
{
    public class TreeExample
    {
        public static int Example(Tree root)
        {
            if (root == null) return 0;
            return root.Value + Example(root.Left) + Example(root.Right);
        }
    }
}