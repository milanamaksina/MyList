using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 3, 3, 4, 5, 2 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 3, 4, 5 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { -1, -2, -2, -1, -5, -9, -7, -8 });
            expectedList = new MyArrayList(new int[] { -9, -8, -7, -5, -2, -2, -1, -1 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { 2 });
            expectedList = new MyArrayList(new int[] { 2 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { 5, 5, 5, 5 });
            expectedList = new MyArrayList(new int[] { 5, 5, 5, 5 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { });
            expectedList = new MyArrayList(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }
}
