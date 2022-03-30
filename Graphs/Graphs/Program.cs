using Graphs.Helpers;

int[,] nodes = new int[,]{
    { 0, 8, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 4, 0 },
    { 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0 }
    };

List<int> checkedVertices = new List<int>();

Console.WriteLine(GraphHelper.PathWeight(nodes, 0, 4, checkedVertices, 0));

