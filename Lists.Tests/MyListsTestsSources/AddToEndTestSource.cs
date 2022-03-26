using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class AddToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 4, 5, 3 });
            yield return new object[] { value, list, expectedList };

            value = -2;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8, -2 });
            yield return new object[] { value, list, expectedList };

            value = 2;
            list = new MyArrayList(new int[] { });
            expectedList = new MyArrayList(new int[] { 2 });
            yield return new object[] { value, list, expectedList };

            value = 0;
            list = new MyArrayList(new int[] { 5, 6, 7, 8 });
            expectedList = new MyArrayList(new int[] { 5, 6, 7, 8, 0 });
            yield return new object[] { value, list, expectedList };
        }
        
    }
}
