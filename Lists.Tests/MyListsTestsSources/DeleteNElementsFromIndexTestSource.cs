using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLists;

namespace Lists.Tests.MyListsTestsSources
{
    public class DeleteNElementsFromIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 2;
            int index = 1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 4, 5 });
            yield return new object[] { n, index, list, expectedList };

            n = 3;
            index = 2;
            list = new MyArrayList(new int[] { -1, -2, -2, -4, -5, -6, -7, -8 });
            expectedList = new MyArrayList(new int[] { -1, -2, -6, -7, -8 });
            yield return new object[] { n, index, list, expectedList };

            n = 2;
            index = 2;
            list = new MyArrayList(new int[] { 0, 0, 0, 0, 0 });
            expectedList = new MyArrayList(new int[] { 0, 0, 0 });
            yield return new object[] { n, index, list, expectedList };

            n = 1;
            index = 0;
            list = new MyArrayList(new int[] { 5, 5, 4, 5 });
            expectedList = new MyArrayList(new int[] { 5, 4, 5 });
            yield return new object[] { n, index, list, expectedList };

        }
    }

    public class DeleteNElementFromIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 1;
            int index = -1;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { n, index, list };

            n = 5;
            index = 5;
            list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { n, index, list };

            n = 1;
            index = 1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { n, index, list };

            n = 1;
            index = -1;
            list = new MyArrayList(new int[] { 1 });
            yield return new object[] { n, index, list };

            n = -1;
            index = -1;
            list = new MyArrayList(new int[] { });
            yield return new object[] { n, index, list };

            n = 0;
            index = 0;
            list = new MyArrayList(new int[] { });
            yield return new object[] { n, index, list };

            n = -2;
            index = 3;
            list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { n, index, list };

            n = 20;
            index = 3;
            list = new MyArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { n, index, list };

            n = 0;
            index = 0;
            list = new MyArrayList(new int[] { });
            yield return new object[] { n, index, list };
        }
    }


}




