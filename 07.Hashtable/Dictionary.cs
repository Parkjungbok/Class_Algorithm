using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Dictionary<Tkey, TValue> where Tkey : IEnumerable<Tkey>
    {
        private const int DefaultCapacity = 1000;

        private struct Entry
        {
            public enum State { None, Using, Deleted }

            public State state;
            public Tkey key;
            public TValue value;
        }

        private Entry[] table;
        private int usedcount;

        public Dictionary()
        {
            table = new Entry[DefaultCapacity];
            usedcount = 0;
        }

        public TValue this[Tkey key]
        {
            get
            {
                if (Find(key, out int index))
                {
                    return table[index].value;
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            set
            {
                if (Find(key, out int index))
                {
                    table[index].value = value;
                }
                else
                {
                    Add(key, value);
                }
            }
        }


        public void Add(Tkey key, TValue value)
        {
            if (Find(key, out int index)) // Find를 가지고 있는지 확인
            {
                throw new InvalidOperationException("Already exist key");
            }
            else
            {
                if (usedcount > table.Length * 0.7f)
                {
                    ReHashing();
                }

                table[index].key = key;
                table[index].value = value;
                table[index].state = Entry.State.Using;
                usedcount++;
            }

        }

        public bool Remove(Tkey key)
        {
            if (Find(key, out int index))
            {
                table[index].state = Entry.State.Deleted;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsKey(Tkey key)
        {
            if (Find(key, out int index))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Find(Tkey key, out int index)
        {
            index = Hash(key);  // 해싱 키값을 인덱스로 변환

            for (int i = 0; i < table.Length; i++)
            {
                if (table[index].state == Entry.State.None)
                {
                    return false;
                }
                else if (table[index].state == Entry.State.Using) // 사용중인데
                {
                    if (key.Equals(table[index].key)) // 일치했다
                    {
                        return true;
                    }
                    else  // 일치하지 않았다
                    {
                        index = Hash2(index); // 다음칸
                    }
                }
                else // if (table[index].state == Entry.State.Deleted)
                {
                    index = Hash2(index); // 다음칸
                }                
            }
            index = -1;
            throw new InvalidOperationException();
        }

        public int Hash(Tkey key)   // 해시함수
        {
            return Math.Abs(key.GetHashCode() % table.Length); // Abs 절대값
        }

        private int Hash2(int index)
        {
            // 선형 탐사
            return (index + 1) % table.Length;

            // 제곱 탐사
            // return (index + 1) * (index + 1) % table.Length;

            // 이중 해싱
            // return Math.Abs((index + 1).GetHashCode() % table.Length);

        }

        private void ReHashing()
        {
            Entry[] oldTable = table;
            table = new Entry[table.Length * 2];
            usedcount++;

            for (int i = 0; i < oldTable.Length; i++)
            {
                Entry entry = oldTable[i];
                if (entry.state == Entry.State.Using)
                {
                    Add(entry.key, entry.value);
                }
            }
        }
    }
}
