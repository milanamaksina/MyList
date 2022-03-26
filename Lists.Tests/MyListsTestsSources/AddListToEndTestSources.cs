using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class AddListToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList Addedlist = new MyArrayList(new int[] { 3, 9, 9 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 4, 5, 3, 9, 9 });
            yield return new object[] { list, Addedlist, expectedList };

            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            Addedlist = new MyArrayList(new int[] { -3, -9, -9 });
            expectedList = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8, -3, -9, -9 });
            yield return new object[] { list, Addedlist, expectedList };

            list = new MyArrayList(new int[] { 2 });
            Addedlist = new MyArrayList(new int[] { -3 });
            expectedList = new MyArrayList(new int[] { 2, -3 });
            yield return new object[] { list, Addedlist, expectedList };

            list = new MyArrayList(new int[] { 5, 5, 5, });
            Addedlist = new MyArrayList(new int[] { 5, 5, 5, });
            expectedList = new MyArrayList(new int[] { 5, 5, 5, 5, 5, 5 });
            yield return new object[] { list, Addedlist, expectedList };

            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            Addedlist = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            yield return new object[] { list, Addedlist, expectedList };

        }
    }

    public class AddListToEndNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            MyArrayList list = new MyArrayList(new int[] { });
            MyArrayList Addedlist = null;
            yield return new object[] { list, Addedlist};
        }
    }

}

