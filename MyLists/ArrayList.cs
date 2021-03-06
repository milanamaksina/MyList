namespace MyLists
{
    public class MyArrayList
    {
        public int Length { get; private set; } //длина для пользователя
        private int[] _array; //реальная длинна

        public MyArrayList()
        {
            _array = new int[10];
            Length = 0;
        }
        public MyArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
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
            if(index >= Length || index < 0)
            {
                throw new Exception("index cannot be less than length or be negative");
            }
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
            if (Length < 1)
            {
                throw new Exception("Length cannot be less than 1");
            }
            if (Length >= 0)
            {
                DownSize();
                Length--;
            }
        } //4
        public void DeleteValueBegin()
        {
            if (Length < 1)
            {
                throw new Exception("Length cannot be less than 1");
            }
            for (int i = 0; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
             Length--;
        } //5
        public void DeleteIndexElement(int index)
        {
            if(index < 0 || index >= Length)
            {
                throw new Exception("index cannot be negative and equal or be more than Lenght");
            }
            int[] newArray = _array;
            for (int i = index; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
            DownSize();
            Length--;

        } //6
        public void DeleteNElementsFromEnd(int n)
        {
            if(Length < 1 || n < 0 || n > Length)
            {
                throw new Exception(" length should be > 0 and N more than 0 and less than Length");
            }
            int[] newArray = _array;
            for (int i = 0; i < Length - n; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
            DownSize();
            Length=Length-n;
        } //7
        public void DeleteNElementsFromBegin(int n)
        {
            if (Length < 1 || n < 0 || n > Length)
            {
                throw new Exception(" length should be > 0 and N more than 0 and less than Length");
            }
            int[] newArray = new int[Length];
            for (int i = 0; i < Length - n; i++)
            {
                newArray[i] = _array[i + n];
            }
            _array = newArray;
            Length = Length - n;
        } //8
        public void DeleteNElementsFromIndex(int n, int index)
        {
            if(n > Length || n < 0|| index < 0 || index >= Length)
            {
                throw new Exception("n > Length || n < 0|| index < 0 || index > Length");
            }
            for (int i = index; i <= Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
            Length = Length - n;
        } //9   
        public int GetElementByIndex(int index)
        {
            if ((Length > 0) && (index < Length) && (index >= 0))
            {
                return _array[index];
            }
            else
            {
                throw new Exception("No value");
            }
            
        } //11
        public int GetIndexByElement(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    return i;
                }
            }
            return -1;
        } //12
        public void ChangeElement(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new Exception("index is out of range");
            }
             _array[index] = value;
        } //13 
        public void Reverse()
        {
            int[] newArray = new int[Length];
            for (int i = 0; i < Length / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[Length - (1 + i)];
                _array[Length - (1 + i)] = tmp;
            }
            newArray = _array;
        } //14
        public int GetMaxValue()
        {
            if (Length < 1)
            {
                throw new Exception(" Length cannot be less than 1");

            }
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }
            return max;
        } //15
        public int GetMinValue()
        {
            if (Length < 1)
            {
                throw new Exception(" Length cannot be less than 1");

            }
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }
            return min;
        } //16
        public int FindIndexOfMaxValue()
        {
            if (Length < 1)
            {
                throw new Exception(" Length cannot be less than 1");

            }
            int maxValue = GetMaxValue();
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == maxValue)
                {
                    return i;
                }
            }
            return -1;
        } //17
        public int FindIndexOfMinValue()
        {
            if (Length < 1)
            {
                throw new Exception(" Length cannot be less than 1");

            }
            int minValue = GetMinValue();
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == minValue)
                {
                    return i;
                }
            }
            return -1;
        } //18
        public void SortAscending()
        {
            int[] newArray = new int[Length];
            int tmp;
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length - 1 - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        tmp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tmp;
                    }
                }
            }
            newArray = _array;
        } //19
        public void SortDescending()
        {
            int[] newArray = new int[Length];
            int tmp;
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length - 1 - i; j++)
                {
                    if (_array[j] < _array[j + 1])
                    {
                        tmp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = tmp;
                    }
                }
            }
            newArray = _array;
        } //20
        public int DeleteTheFirstMeaning(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    Remove(i);
                    Length--;
                    return i;
                }
            }
            return -1;
        } //21
        public int DeleteAllByValue(int value)
        {
            int amount = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    amount++;
                }
                else
                {
                    _array[i-amount]=_array[i];
                }
            }
            Length-=amount;
            return amount;
        } //22
        public void AddListToEnd(MyArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException("list");
            }

            for (int i = 0; i < list.Length; i++)
            {
                this.AddToEnd(list[i]);
            }
        } //24
        public void AddListToBegin(MyArrayList list)
        {
            if (list == null)
            {
                throw new NullReferenceException("list");
            }

            for (int i = list.Length - 1; i >= 0; i--)
            {
                this.AddToBegin(list[i]);
            }
        } //25
        public void AddListByIndex(MyArrayList list, int index)
        {
            if (list == null)
            {
                throw new NullReferenceException("list");
            }
            for (int i = 0; i < list.Length; i++)
            {
                this.AddValueToIndex(list[i], index);
                index++;
            }
        } //26

        public override string ToString()
        {
            string result = " ";
            for (int i = 0; i < Length; i++)
            {
                result += $"{_array[i]}";
            }
            return result;
        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !(obj is MyArrayList))
            {
                return false;
            }
            MyArrayList list = (MyArrayList)obj;
            if (list.Length != this.Length) // длина того, кого мне передали и моя длинна
            {
                return false;
            }
            for (int i = 0; i < this.Length; i++)
            {
                if (list[i] != this[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void Remove(int index)
        {
            {
                for (int i = 0; i < index; i++)
                {
                    _array[i] = _array[i];
                }
                for (int i = index + 1; i < Length; i++)
                {
                    _array[i - 1] = _array[i];
                }
            }
        }
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