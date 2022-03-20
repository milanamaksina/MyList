﻿namespace MyLists
{
    public class ArrayList
    {
        public int Length { get; private set; } //длина для пользователя
        private int[] _array; //реальная длинна

        public ArrayList()
        {
            _array = new int[10];
            Length = 5;
        }

        public void AddToEnd(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value; //присваиваю значение 
            Length++; //увеличиваю
        } //1
        public void AddToBegin(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            Length++;
            int[] newArray = new int[Length];
            for (int i = 0; i < Length - 1; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
            _array[0] = value;
        } //2
        public void AddValueToIndex(int value, int index)
        {

            if (index == Length)
            {
                AddToEnd(value);
            }
            else if ((Length > 0) && (index < Length) && (index >= 0))
            {
                if (Length >= _array.Length)
                {
                    UpSize();
                }

                int[] newArray = new int[Length + 1];
                for (int i = 0; i < Length; i++)
                {
                    newArray[i] = _array[i];
                }
                for (int i = index; i < Length; i++)
                {
                    newArray[i + 1] = _array[i];
                }
                newArray[index] = value;
                _array = newArray;
                Length++;
            }

        } //3
        public void DeleteValueEnd()
        {
           Length--;
        } //4
        public void DeleteValueBegin()
        {
            int[] newArray = new int[Length];
            for (int i = 0; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];

            }
            _array = newArray;
             Length--;
        } //5
           



        private void DownSize()
        {
            int newLength = (int)(_array.Length - 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length - 1; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]}");
            }
            Console.WriteLine();
        }
    }
}