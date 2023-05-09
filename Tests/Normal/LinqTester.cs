namespace Tests.Normal
{
    internal class LinqTester
    {
        [Test]
        public void TestQuery()
        {
            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> results=from score in scores where score > 6 select score;
            foreach (var result in results)
            {
                Console.Write($"{result},");
            }
        }
        [Test]
        public void TestGroup() {
            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                orderby item[0]
                group item by item[0]
                ;
            foreach (IGrouping<char, string> item in queryFoodGroups)
            {
                Console.Write($"{item.Key}=>");
                foreach (var str in item)
                {
                    Console.Write($"{str},");
                }
                Console.WriteLine();
            }
        }
        [Test]
        public void TestMethod() {
            // QueryMethod1 returns a query as its value.
            IEnumerable<string> QueryMethod1(int[] ints) =>
                from i in ints
                where i > 4
                select i.ToString();

            // QueryMethod2 returns a query as the value of the out parameter returnQ
            void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
                returnQ =
                    from i in ints
                    where i < 4
                    select i.ToString();

            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // QueryMethod1 returns a query as the value of the method.
            var myQuery1 = QueryMethod1(nums);

            // Query myQuery1 is executed in the following foreach loop.
            Console.WriteLine("Results of executing myQuery1:");
            // Rest the mouse pointer over myQuery1 to see its type.
            foreach (var s in myQuery1)
            {
                Console.WriteLine(s);
            }

            // You also can execute the query returned from QueryMethod1
            // directly, without using myQuery1.
            Console.WriteLine("\nResults of executing myQuery1 directly:");
            // Rest the mouse pointer over the call to QueryMethod1 to see its
            // return type.
            foreach (var s in QueryMethod1(nums))
            {
                Console.WriteLine(s);
            }

            // QueryMethod2 returns a query as the value of its out parameter.
            QueryMethod2(nums, out IEnumerable<string> myQuery2);

            // Execute the returned query.
            Console.WriteLine("\nResults of executing myQuery2:");
            foreach (var s in myQuery2)
            {
                Console.WriteLine(s);
            }

            // You can modify a query by using query composition. In this case, the
            // previous query object is used to create a new query object; this new object
            // will return different results than the original query object.
            myQuery1 =
                from item in myQuery1
                orderby item descending
                select item;

            // Execute the modified query.
            Console.WriteLine("\nResults of executing modified myQuery1:");
            foreach (var s in myQuery1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
