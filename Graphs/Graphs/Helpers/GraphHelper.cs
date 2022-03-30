namespace Graphs.Helpers
{
    public static class GraphHelper
    {
        public static int PathWeight(int[,] nodes, int vertex1, int vertex2, List<int> checkedVertices, int currentWeight)
        {
            if(IsThereADirectPath(nodes, vertex1, vertex2))
            {
                return currentWeight + nodes[vertex1, vertex2];
            }

            checkedVertices.Add(vertex1);

            for (int i = 0; i < nodes.GetLength(1); i++)
            {
                if(IsThereADirectPath(nodes, vertex1, i)
                    && !checkedVertices.Contains(i))
                {
                    return PathWeight(nodes, i, vertex2, checkedVertices, currentWeight + nodes[vertex1, i]);
                }
            }

            return 0;
        }

        public static bool IsThereADirectPath(int[,] nodes, int vertex1, int vertex2)
        {
            if (nodes[vertex1, vertex2] != 0)
            {
                return true;
            }

            return false;
        }
    }
}
