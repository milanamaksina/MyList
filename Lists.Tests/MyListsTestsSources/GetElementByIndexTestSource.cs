using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class GetElementByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 4;
            yield return new object[] { index, list, expected };

            index = 4;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expected = -5;   
            yield return new object[] { index, list, expected};

            index = 2;
            list = new MyArrayList(new int[] { 6,-7,-9 });
            expected = -9;
            yield return new object[] { index, list, expected};

            index = 2;
            list = new MyArrayList(new int[] { 5, 5, 5, 5, 5 });
            expected = 5;
            yield return new object[] { index, list, expected};

            index = 3;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expected = 0;
            yield return new object[] { index, list, expected};
        }
    }
}
