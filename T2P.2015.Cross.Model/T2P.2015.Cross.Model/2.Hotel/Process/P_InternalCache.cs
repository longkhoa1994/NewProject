using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public sealed class P_InternalCache
    {
        private ConcurrentDictionary<long, string> _items;

        static readonly P_InternalCache _instance = new P_InternalCache();

        public static P_InternalCache Instance
        {
            get { return _instance; }
        }

        private P_InternalCache()
        {
            _items = new ConcurrentDictionary<long,string>();
        }
        public void AddItem(long key, string asName)
        {
            _items.TryAdd(key, asName);
        }
        public bool GetItemByKey(long key, out string asName)
        {
            return _items.TryGetValue(key, out asName);           
        }

        public bool RemoveItemByKey(long key, out string asName)
        {
            return _items.TryRemove(key, out asName);
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
