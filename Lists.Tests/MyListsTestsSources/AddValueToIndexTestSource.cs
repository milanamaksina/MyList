using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class AddValueToIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 55;
            int index = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 55, 4, 5 });
            yield return new object[] { value, index, list, expectedList };

            value = -55;
            index = 0;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5 });
            expectedList = new MyArrayList(new int[] { -55, -1, -2, -2, -4, -5 });
            yield return new object[] { value, index, list, expectedList };

            value = 0;
            index = 2;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 0, 0, 0, 0 });
            yield return new object[] { value, index, list, expectedList };

            value = 0;
            index = 0;
            list = new MyArrayList(new int[] { });
            expectedList = new MyArrayList(new int[] { 0 });
            yield return new object[] { value, index, list, expectedList };

            value = 2;
            index = 5;
            list = new MyArrayList(new int[] { });
            expectedList = new MyArrayList(new int[] { });
            yield return new object[] { value, index, list, expectedList }; //? эксепшн



        }
    }
}
