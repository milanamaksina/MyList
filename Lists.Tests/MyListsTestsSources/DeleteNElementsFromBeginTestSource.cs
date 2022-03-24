using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class DeleteNElementsFromBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 4, 5 });
            yield return new object[] { n, list, expectedList };

            n = 5;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] { -6, -7, -8 });
            yield return new object[] { n, list, expectedList };

            n = 0;
            list = new MyArrayList(new int[] { 2 });
            expectedList = new MyArrayList(new int[] { 2 });
            yield return new object[] { n, list, expectedList };

            n = 2;
            list = new MyArrayList(new int[] { 5, 5, 5, 5 });
            expectedList = new MyArrayList(new int[] { 5, 5 });
            yield return new object[] { n, list, expectedList };

            n = 4;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0 });
            yield return new object[] { n, list, expectedList };
        }

    }
}
