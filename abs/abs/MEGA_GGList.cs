using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace abs
{
    class MEGA_GGList
    {
        private GGList memas;
        private List<string> memaskey;
        public MEGA_GGList(int len)
        {
            memas = new GGList(len);
            memaskey = new List<string>();
            for (int i = 0; i < len; i++)
            {
                memaskey.Add("-");
            }
        }
        public GGList this[string key]
        {
            get { if (memaskey.Contains(key)) { return memas; } else { memaskey.Add(key); return memas; }  }
            set {}

        }
        public void Remove(string key)
        {

            memaskey.Remove(key);
        }
        public int Len()
        {

            return memaskey.Count;
        }
        public int this[string key, int index]
        {
            get {
                List<int> good = new List<int>(0);
                for (int i = 0; i < memaskey.Count; i++)
                {
                    if (memaskey[i] == key)
                    {
                        good.Add(i);
                    } 
                }
                if (good.Contains(index))
                {
                    return memas[index];
                }
                else
                {
                    return -404;
                }
            }
            set {
                List<int> good = new List<int>(0);
                for (int i = 0; i < memaskey.Count; i++)
                {
                    if (memaskey[i] == key)
                    {
                        good.Add(i);
                    }
                }
                if (good.Count>=index)
                {
                    memas[good[index]] = value;
                }
                }
        }
        public override string ToString()
        {
            string v = "[";
            int c;
            for (int i = 0; i < memaskey.Count - 1; i++)
            {
                v += " " + this.memaskey[i] + ",";
            }
            if (memaskey.Count > 1)
            {
                v += " " + this.memaskey[memaskey.Count - 1] + "]";
            }
            else
            {
                v += "]";
            }
            return v;
        }
    }
}
