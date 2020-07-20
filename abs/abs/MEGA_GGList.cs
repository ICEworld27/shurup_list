using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace abs
{
    class MEGA_GGList
    {
        Dictionary<string, Komp_of_MEGA_GGList> s = new Dictionary<string, Komp_of_MEGA_GGList>();
        public MEGA_GGList(int len)
        {
            

            for (int i = 0; i < len; i++)
            {
                Komp_of_MEGA_GGList a = new Komp_of_MEGA_GGList(len);
                s.Add(Convert.ToString(i), a);
            }
        }
        public Komp_of_MEGA_GGList this[string key]
        {
            
            get { if (s.ContainsKey(key)) { return s[key]; } else { s.Add(key,new Komp_of_MEGA_GGList(1)); return s[key];}  }


        }
        public void Remove(string key)
        {

            s.Remove(key);
        }
        public int Len()
        {

            return s.Count;
        }
        public int this[string key, int index]
        {
            get {
                List<int> z = s[key].get();
                return z[index];
            }
            set
            {
                s[key].set(index, value);
            }
        }
        public override string ToString()
        {
            string v = "[";
            
            foreach (KeyValuePair<string, Komp_of_MEGA_GGList> s in s)
            {
                v += "\n{" + s.Value.ToString() + "}";
            }

            v += "]";
            return v;
        }
    }
}

