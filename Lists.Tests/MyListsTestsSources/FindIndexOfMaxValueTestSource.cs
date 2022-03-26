using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class FindIndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 4;
            yield return new object[] { list, expected };

            list = new MyArrayList(new int[] { -2, -2, -4, -1, -5, -6, -7, -8 });
            expected = 3;
            yield return new object[] { list, expected };

            list = new MyArrayList(new int[] { 2 });
            expected = 0;
            yield return new object[] { list, expected };

            list = new MyArrayList(new int[] { 5, 5, 5, 5 });
            expected = 0;
            yield return new object[] { list, expected };

            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expected = 0;
            yield return new object[] { list, expected };

        }
    }
}
