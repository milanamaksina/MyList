﻿using MyLists;

ArrayList list = new ArrayList();


list.Write();
list.AddToEnd(1);
list.Write();
list.AddToEnd(2);
list.Write();
list.AddToEnd(3);
list.Write();
list.AddToEnd(4);
list.Write();
list.AddToEnd(3);
list.Write();
list.AddToEnd(4);
list.Write();
list.AddToBegin(5);
list.Write();
list.DeleteIndexElement(3);
list.Write();
//list.DeleteNElementsFromEnd(3);
//list.Write();
//list.DeleteNElementsFromBegin(2);
//list.Write();
list.DeleteNElementsFromIndex(2);
list.Write();
//int a = list.GetElementByIndex(2);
//Console.WriteLine(a);
//int b = list.GetIndexByElement(3);
//Console.WriteLine(b);
list.ChangeElement(2,6);
list.Write();
list.Reverse();
list.Write();
//int s = list.FindIndexOfMaxValue();
//Console.WriteLine(s);
list.SortAscending();
list.Write();
list.SortDescending();
list.Write();
list.DeleteTheFirstMeaning(5);
list.Write();
