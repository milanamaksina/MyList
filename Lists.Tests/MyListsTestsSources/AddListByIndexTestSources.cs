using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList Addedlist = new MyArrayList(new int[] { 3, 9, 9 });
            int index = 2;
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 9, 9, 3, 4, 5 });
            yield return new object[] { list, Addedlist, index ,expectedList };

            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            Addedlist = new MyArrayList(new int[] { -3, -9, -9 });
            index = 0;
            expectedList = new MyArrayList(new int[] { -3, -9, -9, -1, -2, -2, -4, -5, -6, -7, -8 });
            yield return new object[] { list, Addedlist, index, expectedList };

            list = new MyArrayList(new int[] { 2, 5, 4 });
            Addedlist = new MyArrayList(new int[] { -3 });
            index = 2;
            expectedList = new MyArrayList(new int[] { 2, 5, -3, 4 });
            yield return new object[] { list, Addedlist, index, expectedList };

            list = new MyArrayList(new int[] { 5, 5, 5, });
            Addedlist = new MyArrayList(new int[] { 5, 5, 5, });
            index = 2;
            expectedList = new MyArrayList(new int[] { 5, 5, 5, 5, 5, 5 });
            yield return new object[] { list, Addedlist, index, expectedList };

            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            Addedlist = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            index = 1;
            expectedList = new MyArrayList(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            yield return new object[] { list, Addedlist, index, expectedList };

        }
    }

    public class AddListByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            MyArrayList list = new MyArrayList(new int[] { });
            MyArrayList Addedlist = null;
            int index = 0;
            yield return new object[] { list, Addedlist, index };
        }
    }
}
