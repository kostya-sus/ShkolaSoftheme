using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_Araay3
{
    class ArrayExtension
    {


        public int[] Array { get; set; }



        public ArrayExtension(int[] array)
        {
            Array = array;
        }



        public void Add(int item)
        {
           int[] arr = new int[Array.Length];
            Array.CopyTo(arr, 0);
            Array = new int[arr.Length + 1];
            arr.CopyTo(Array, 0);
            Array[arr.Length] = item;
        }



        public bool Contains(int element)
        {
            
            
            foreach (var arr in Array)
            {
                if (arr.Equals(element))
                {
                    return true;
                }
            }
            return false;

        }



        public int GetByIndex(int index)
        {
            return Array[index];
        }
    }
}
