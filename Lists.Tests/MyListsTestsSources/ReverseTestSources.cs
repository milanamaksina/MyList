using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] { -8, -7, -6, -5, -4, -2, -2, -1 });
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
