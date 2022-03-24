using NUnit.Framework;
using MyLists;
using System.Collections;
using Lists.Tests.MyListsTestsSources;

namespace Lists.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(DeleteAllByValueSource))]
        public void DeleteAllByValueTest(int value, MyArrayList list, MyArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);
            MyArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        } //22

        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddToEnd(value);

            Assert.AreEqual(expectedList, actualList);
        } //1 

        [TestCaseSource(typeof(AddToEndBeginTestSource))]
        public void AddToBeginTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddToBegin(value);

            Assert.AreEqual(expectedList, actualList);
        } //2

        [TestCaseSource(typeof(AddValueToIndexTestSource))]
        public void AddValueToIndexTest(int value, int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddValueToIndex(value, index);

            Assert.AreEqual(expectedList, actualList);
        } //3

        [TestCaseSource(typeof(DeleteValueEndTestSource))]
        public void DeleteValueEndTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteValueEnd();

            Assert.AreEqual(expectedList, actualList);
        } //4

        [TestCaseSource(typeof(DeleteValueBeginTestSource))]
        public void DeleteValueBeginTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteValueBegin();

            Assert.AreEqual(expectedList, actualList);
        } //5

        [TestCaseSource(typeof(DeleteIndexElementTestSource))]
        public void DeleteIndexElementTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteIndexElement(index);

            Assert.AreEqual(expectedList, actualList);
        } //6 


    }



}