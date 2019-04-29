using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muliMapApp
{
    class MultiMap<T, V>
    {
        Dictionary<T, List<V>> _dictionary = new Dictionary<T, List<V>>();


        /// <summary>
        /// Add  element   to   Dictionary
        /// </summary>
        /// <param name="key">Dictionary Key</param>
        /// <param name="value">Dictionary Value</param>
        public void Add(T key, V value) {

            List<V> list;
            if (!this._dictionary.TryGetValue(key, out list))
            {
                list = new List<V>();
                list.Add(value);
                _dictionary[key] = list;

            }
            else {

                list.Add(value);

            }


        }


        /// <summary>
        /// remove   element of dictionary  by key
        /// </summary>
        /// <param name="key">dictionary   key </param>
        public void Remove(T key) {

            List<V> list;
            if (this._dictionary.TryGetValue(key, out list)) {

                _dictionary.Remove(key);
                Console.WriteLine("remuved elements by  key {0}",key);
            }


        }

        /// <summary>
        /// clear  all  elements of dictionary
        /// </summary>
        public void ClearAll() {

            _dictionary.Clear();
            Console.WriteLine("Dictionary  is cleared");


        }

        /// <summary>
        /// return dictionary keys array
        /// </summary>
        public IEnumerable<T> Keys
        {

            get {

                return _dictionary.Keys;

            }


        }


        /// <summary>
        /// Indexers  for  getting  values   by  key 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<V> this[T key] {

            get
            {
                // Get list at a key.
                List<V> list;
                if (!this._dictionary.TryGetValue(key, out list))
                {
                    list = new List<V>();
                    this._dictionary[key] = list;
                }
                return list;
            }


        }


       




    }
}
