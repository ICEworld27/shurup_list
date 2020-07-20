using System;
using System.Collections.Generic;
using System.Text;

namespace abs
{
    class Komp_of_MEGA_GGList
    {
        
        private List<int> zn;
        public Komp_of_MEGA_GGList(int len)
        {
            zn = new List<int>();
        }
        public void Add(int q)
        {
            zn.Add(q);
        }
        public void Remove(int q)
        {
            zn.Remove(q);
        }
        public List<int> get()
        {
            return zn;
        }
        public void set(int index, int znach)
        {
            if (zn.Count > index)
            {
                zn[index] = znach;
            }
            
        }
        public override string ToString()
        {
            string v = "[";
            int c;
            for (int i = 0; i < zn.Count - 1; i++)
            {
                v += " " + this.zn[i] + ",";
            }
            if (zn.Count >= 1)
            {
                v += " " + this.zn[zn.Count - 1] + "]";
            }
            else
            {
                v += "]";
            }
            return v;
        }
    }

}
