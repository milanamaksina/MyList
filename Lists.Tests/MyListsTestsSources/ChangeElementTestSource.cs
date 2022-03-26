using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class ChangeElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int value = 99;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 99, 4, 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 0;
            value = -99;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] { -99, -2, -2, -4, -5, -6, -7, -8 });
            yield return new object[] { index, value, list, expectedList };

            index = 3;
            value = 0;
            list = new MyArrayList(new int[] { 5, 6, 7, 8 });
            expectedList = new MyArrayList(new int[] { 5, 6, 7, 0 });
            yield return new object[] { index, value, list, expectedList };

            index = 2;
            value = 4;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 4, 0, 0 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
    public class ChangeElementNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 55;
            int index = -1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list };

            value = 55;
            index = 5;
            list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list };

            value = 55;
            index = -1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { value, index, list };

            value = 55;
            index = 1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { value, index, list };

            value = 55;
            index = -1;
            list = new MyArrayList(new int[] { });
            yield return new object[] { value, index, list };

            value = 55;
            index = 0;
            list = new MyArrayList(new int[] { });
            yield return new object[] { value, index, list };
        }
    }

}
