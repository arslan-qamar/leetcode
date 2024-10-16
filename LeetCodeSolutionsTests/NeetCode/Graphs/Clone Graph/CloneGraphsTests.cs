using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs;
using LeetCodeSolutions.NeetCode.Graphs.Clone_Graph;
using Newtonsoft.Json;

namespace Clone_Graph.Tests
{
    [TestClass()]
    public class CloneGraphsTests
    {
        [TestMethod()]
        public void CloneGraphTest()
        {
            JsonSerializerSettings cycleIgnore = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Node node11 =  new Node(1);
            CloneGraphs.CloneGraph(node1).Should().BeEquivalentTo(new Node(1));

            Node node22 = new Node(2);
            node11.neighbors.Add(node22);
            node1.neighbors.Add(node2);            
            CloneGraphs.CloneGraph(node1).Should().BeEquivalentTo(node11);


            FluentAssertions.Equivalency.EquivalencyAssertionOptions options = new FluentAssertions.Equivalency.EquivalencyAssertionOptions()
                .IgnoringCyclicReferences().RespectingRuntimeTypes().ComparingByMembers<Node>();

            node2.neighbors.Add(node1);
            node22.neighbors.Add(node11);
            JsonConvert.SerializeObject(CloneGraphs.CloneGraph(node1), cycleIgnore).Should().BeEquivalentTo(JsonConvert.SerializeObject(node11, cycleIgnore));

            Node node33 = new Node(3);
            node2.neighbors.Add(node3);
            node22.neighbors.Add(node33);
            JsonConvert.SerializeObject(CloneGraphs.CloneGraph(node1), cycleIgnore).Should().BeEquivalentTo(JsonConvert.SerializeObject(node11, cycleIgnore));


            node3.neighbors.Add(node2);
            node33.neighbors.Add(node22);
            JsonConvert.SerializeObject(CloneGraphs.CloneGraph(node1), cycleIgnore).Should().BeEquivalentTo(JsonConvert.SerializeObject(node11, cycleIgnore));


        }
    }
}