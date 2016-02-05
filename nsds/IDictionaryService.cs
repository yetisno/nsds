﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsds
{
    public interface IDictionaryService: ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
    {
        string DictionaryServiceId { get; }
        object this[string key] { get; set; }
        int Count { get; }
        ICollection<string> Keys { get; }
        void Add(string key, object value);
        bool ContainsKey(string key);
        bool Remove(string key);
        bool TryGetValue(string key, out object value);
    }
}