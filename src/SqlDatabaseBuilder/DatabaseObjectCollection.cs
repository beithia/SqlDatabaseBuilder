﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xtrimmer.SqlDatabaseBuilder
{
    public class DatabaseObjectCollection<T> where T : DatabaseObject
    {        
        protected List<T> list = new List<T>();

        public virtual DatabaseObjectCollection<T> Add(T item)
        {
            item.ThrowIfNull(nameof(item));
            list.Add(item);
            return this;
        }

        public DatabaseObjectCollection<T> AddAll(params T[] items)
        {
            Array.ForEach(items, c => Add(c));
            return this;
        }

        public void ForEach(Action<T> action) => list.ForEach(action);

        public bool isEmpty() => !list.Any();

        public T this[int index] => list[index];

        public int Count => list.Count;

        internal string SqlDefinition
        {
            get
            {
                return string.Join(", ", list.Select(c => c.SqlDefinition).ToList());
            }
        }
    }
}
