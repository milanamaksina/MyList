using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class GetIndexByElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 4;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 3;
            yield return new object[] { value, list, expected };

            value = -4;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expected = 5;
            yield return new object[] { value, list, expected };

            value = -7;
            list = new MyArrayList(new int[] { 6, -7, -9 });
            expected = 1;
            yield return new object[] { value, list, expected };

            value = 5;
            list = new MyArrayList(new int[] { 5, 5, 5, 5, 5 });
            expected = 0;
            yield return new object[] { value, list, expected };

            value = 3;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expected = 0;
            yield return new object[] { value, list, expected };
        }
    }
}
