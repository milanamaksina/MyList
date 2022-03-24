using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class DeleteAllByValueSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };

            value = -2;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5 });
            expectedList = new MyArrayList(new int[] { -1, -4, -5 });
            expectedNumber = 2;
            yield return new object[] { value, list, expectedList, expectedNumber };

            value = 0;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { });
            expectedNumber = 5;
            yield return new object[] { value, list, expectedList, expectedNumber };


        }
    }

}
