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

        [TestCaseSource(typeof(DeleteNElementsFromEndTestSource))]
        public void DeleteNElementsFromEndTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromEnd(n);

            Assert.AreEqual(expectedList, actualList);
        } //7

        [TestCaseSource(typeof(DeleteNElementsFromBeginTestSource))]
        public void DeleteNElementsFromBeginTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromBegin(n);

            Assert.AreEqual(expectedList, actualList);
        } //8

        [TestCaseSource(typeof(DeleteNElementsFromIndexTestSource))]
        public void DeleteNElementsFromIndexTest(int n, int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromIndex(n, index);

            Assert.AreEqual(expectedList, actualList);
        } //9

        [TestCaseSource(typeof(GetElementByIndexTestSource))]
        public void GetElementByIndexTest(int index, MyArrayList list, int expected)
        {
            int actual = list.GetElementByIndex(index);
            Assert.AreEqual(expected, actual);
        } //11

        [TestCase(typeof(GetIndexByElementTestSource))]
        public void GetIndexByElementTest(int value, MyArrayList list, int expected)
        {
            int actual = list.GetElementByIndex(value);
            Assert.AreEqual(expected, actual);
        } //12


    }




}