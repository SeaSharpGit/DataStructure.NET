using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class MyString
    {
        private readonly char[] _Items = null;

        public char this[int index]
        {
            get => _Items[index];
            private set => _Items[index] = value;
        }

        public MyString(char[] items)
        {
            var length = items.Length;
            _Items = new char[length];
            for (int i = 0; i < length; i++)
            {
                _Items[i] = items[i];
            }
        }

        public MyString(MyString ms)
        {
            var length = ms.GetLength();
            _Items = new char[length];
            for (int i = 0; i < length; i++)
            {
                _Items[i] = ms[i];
            }
        }

        public MyString(int length)
        {
            _Items = new char[length];
        }

        public int GetLength() => _Items.Length;

        public int Compare(MyString ms)
        {
            var myLength = GetLength();
            var otherLength = ms.GetLength();
            int length = myLength <= otherLength ? myLength : otherLength;
            int i;
            for (i = 0; i < length; ++i)
            {
                if (this[i] != ms[i])
                {
                    break;
                }
            }
            if (i <= length)
            {
                return this[i] < ms[i] ? -1 : 1;
            }
            else if (myLength == otherLength)
            {
                return 0;
            }
            else if (myLength < otherLength)
            {
                return -1;
            }

            return 1;
        }

        public MyString Substring(int startIndex)
        {
            return Substring(startIndex, GetLength());
        }

        public MyString Substring(int startIndex, int length)
        {
            if (startIndex < 0 || length < 0 || startIndex + length > GetLength())
            {
                throw new Exception("Error");
            }
            var result = new MyString(length);
            for (int i = 0; i < length; i++)
            {
                result[i] = _Items[i + startIndex];
            }
            return result;
        }

        public MyString Concat(MyString ms)
        {
            var length = GetLength() + ms.GetLength();
            var result = new MyString(length);
            for (int i = 0; i < GetLength(); i++)
            {
                result[i] = this[i];
            }
            for (int i = 0; i < ms.GetLength(); i++)
            {
                result[i + GetLength()] = ms[i];
            }
            return result;
        }

        public MyString Insert(int index, MyString ms)
        {
            if (index < 0 || index + 1 > GetLength())
            {
                throw new Exception("Error");
            }

            var result = new MyString(GetLength() + ms.GetLength());
            for (int i = 0; i < index; i++)
            {
                result[i] = this[i];
            }
            for (int i = 0; i < ms.GetLength(); i++)
            {
                result[index + i] = ms[i];
            }
            for (int i = 0; i < GetLength() - index; i++)
            {
                result[index + ms.GetLength() + i] = this[index + i];
            }
            return result;
        }

        public MyString Delete(int index, int length)
        {
            if (index < 0 || length < 0 || index + length > GetLength())
            {
                throw new Exception("Error");
            }
            var result = new MyString(GetLength() - length);
            for (int i = 0; i < index; i++)
            {
                result[i] = this[i];
            }
            for (int i = index; i < GetLength() - length - index; i++)
            {
                result[i] = this[i + length];
            }
            return result;
        }
    }
}
