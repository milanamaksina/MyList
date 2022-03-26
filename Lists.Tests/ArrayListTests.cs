using NUnit.Framework;
using MyLists;
using System.Collections;
using Lists.Tests.MyListsTestsSources;
using System;

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

        [TestCaseSource(typeof(AddValueToIndexNegativeTestSource))]
        public void AddValueToIndexTest_WhenIndexOutOfRangeList_ShouldThrowException(int value, int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.AddValueToIndex(value, index));
        } //3 negative 

        [TestCaseSource(typeof(DeleteValueEndTestSource))]
        public void DeleteValueEndTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteValueEnd();

            Assert.AreEqual(expectedList, actualList);
        } //4

        [Test]
        public void DeleteValueEndTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.DeleteValueEnd());

        } //4 negative

        [TestCaseSource(typeof(DeleteValueBeginTestSource))]
        public void DeleteValueBeginTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteValueBegin();

            Assert.AreEqual(expectedList, actualList);
        } //5

        [Test]
        public void DeleteValueBeginTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.DeleteValueBegin());
        } //5 negative

        [TestCaseSource(typeof(DeleteIndexElementTestSource))]
        public void DeleteIndexElementTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteIndexElement(index);

            Assert.AreEqual(expectedList, actualList);
        } //6 

        public void DeleteIndexElementTest_WhenIndexOutOfRangeList_ShouldThrowExeption(int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteIndexElement(index));
        } //6 negative 

        [TestCaseSource(typeof(DeleteNElementsFromEndTestSource))]
        public void DeleteNElementsFromEndTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromEnd(n);

            Assert.AreEqual(expectedList, actualList);
        } //7

        [TestCaseSource(typeof(DeleteNElementFromEndNegativeTestSource))]
        public void DeleteNElementsFromEndTest_WhenNisOutOfListRange_ShouldThrowException(int n, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsFromEnd(n));
        } //7 negative

        [TestCaseSource(typeof(DeleteNElementsFromBeginTestSource))]
        public void DeleteNElementsFromBeginTest(int n, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromBegin(n);

            Assert.AreEqual(expectedList, actualList);
        } //8

        [TestCase(typeof(DeleteNElementFromBeginNegativeTestSource))]
        public void DeleteNElementsFromBeginTest_WhenNisOutOfListRange_ShouldThrowException(int n, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsFromBegin(n));
        } //8 negative

        [TestCaseSource(typeof(DeleteNElementsFromIndexTestSource))]
        public void DeleteNElementsFromIndexTest(int n, int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteNElementsFromIndex(n, index);

            Assert.AreEqual(expectedList, actualList);
        } //9

        [TestCaseSource(typeof(DeleteNElementFromIndexNegativeTestSource))]
        public void DeleteNElementsFromIndexTest_WhenNandIndexAreOutOfListRange_ShouldThrowException(int n, int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsFromIndex(n, index));
        } //9 negative

        [TestCaseSource(typeof(GetElementByIndexTestSource))]
        public void GetElementByIndexTest(int index, MyArrayList list, int expected)
        {
            int actual = list.GetElementByIndex(index);
            Assert.AreEqual(expected, actual);
        } //11

        [TestCaseSource(typeof(GetElementByIndexNegativeTestSource))]
        public void GetElementByIndexTest_WhenIndexIsOutOfListRange_ShouldThrowException(int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetElementByIndex(index));
        } //11 negative 

        [TestCaseSource(typeof(GetIndexByElementTestSource))]
        public void GetIndexByElementTest(int value, MyArrayList list, int expected)
        {
            int actual = list.GetIndexByElement(value);
            Assert.AreEqual(expected, actual);
        } //12

        [TestCaseSource(typeof(ChangeElementTestSource))]
        public void ChangeElementTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.ChangeElement(index, value);

            Assert.AreEqual(expectedList, actualList);
        } //13

        [TestCaseSource(typeof(ChangeElementNegativeTestSource))]
        public void ChangeElementTest_WhenIndexIsOutOfRange_ShouldThrowException(int index, int value, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.ChangeElement(index, value));
        } //13 negative

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.Reverse();

            Assert.AreEqual(expectedList, actualList);
        } // 14

        [TestCaseSource(typeof(GetMaxValueTestSource))]
        public void GetMaxValueTest(MyArrayList list, int expected)
        {
            int actual = list.GetMaxValue();
            Assert.AreEqual(expected, actual);
        } //15 

        [Test]
        public void GetMaxValueTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.GetMaxValue());
        } // 15 negative 

        public void GetMinValueTest(MyArrayList list, int expected)
        {
            int actual = list.GetMinValue();
            Assert.AreEqual(expected, actual);
        } //16 

        public void GetMinValueTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.GetMinValue());
        } //16 negative 

        [TestCaseSource(typeof(FindIndexOfMaxValueTestSource))]
        public void FindIndexOfMaxValueTest(MyArrayList list, int expected)
        {
            int actual = list.FindIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        } //17

        [Test]
        public void FindIndexOfMaxValueTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.FindIndexOfMaxValue());
        } //17 negative

        [TestCaseSource(typeof(FindIndexOfMinValueTestSource))]
        public void FindIndexOfMinValueTest(MyArrayList list, int expected)
        {
            int actual = list.FindIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        } //18

        [Test]
        public void FindIndexOfMinValueTest_WhenListIsEmpty_ShouldThrowExeption()
        {
            MyArrayList list = new MyArrayList();
            Assert.Throws<Exception>(() => list.FindIndexOfMinValue());
        } //18 negative 

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.SortAscending();

            Assert.AreEqual(expectedList, actualList);
        } //19

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.SortDescending();

            Assert.AreEqual(expectedList, actualList);
        } //20

        [TestCaseSource(typeof(DeleteTheFirstMeaningTestSource))]
        public void DeleteTheFirstMeaningTest(int value, MyArrayList list, int indexExpected)
        {
            int actual = list.DeleteTheFirstMeaning(value);
            Assert.AreEqual(indexExpected, actual);
        } //21

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(MyArrayList list, MyArrayList Addedlist, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddListToEnd(Addedlist);

            Assert.AreEqual(expectedList, actualList);
        } // 24

        [TestCaseSource(typeof(AddListToEndNegativeTestSource))]
        public void AddListToEndTest_WhenListIsNull_ShouldThrowException(MyArrayList list, MyArrayList AddedList)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(AddedList));
        } // 24 negative

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(MyArrayList list, MyArrayList Addedlist, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddListToBegin(Addedlist);

            Assert.AreEqual(expectedList, actualList);
        } //25

        [TestCaseSource(typeof(AddListToBeginNegativeTestSource))]
        public void AddListToBeginTest_WhenListIsNull_ShouldThrowException(MyArrayList list, MyArrayList AddedList)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(AddedList));
        } //25 negative

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndex(MyArrayList list, MyArrayList Addedlist, int index, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddListByIndex(Addedlist, index);

            Assert.AreEqual(expectedList, actualList);
        } //26

        [TestCaseSource(typeof(AddListByIndexNegativeTestSource))]
        public void AddListByIndexTest_WhenListIsNull_ShouldThrowException(MyArrayList list, MyArrayList AddedList, int index)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListByIndex(AddedList, index));
        } //26 negative

    }
}