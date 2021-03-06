using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class DeleteIndexElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 5 });
            yield return new object[] { index, list, expectedList };

            index = 4;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] {-1, -2, -2, -4, -6, -7, -8 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new MyArrayList(new int[] { 2 });
            expectedList = new MyArrayList(new int[] { });
            yield return new object[] { index, list, expectedList };

            index = 2;
            list = new MyArrayList(new int[] { 5,5,5,5,5});
            expectedList = new MyArrayList(new int[] {5,5,5,5 });
            yield return new object[] {index, list, expectedList };

            index = 3;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 0, 0});
            yield return new object[] {index, list, expectedList };
        }
    }

    public class DeleteIndexElementNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = 5;
            list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = -1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { index, list };

            index = 1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { index, list };

            index = -1;
            list = new MyArrayList(new int[] { });
            yield return new object[] { index, list };

            index = 0;
            list = new MyArrayList(new int[] { });
            yield return new object[] {index, list};


        }
    }
}
