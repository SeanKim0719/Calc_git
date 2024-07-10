using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_git_memory
{
    internal class CalcMemory
    {
        int index = 0;
        int[] memory;
        public CalcMemory():this(8) { }
        CalcMemory(int capacity)
        {
            memory = new int[capacity];
        }

        public void SAVE(int value)
        {
            if (index < 0 || index >= memory.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the bounds of the array.");
            }

            memory[index] = value;
            index = (index + 1) % 8;
        }

        public int LOAD(int idx)
        {
            if(idx < 0 || idx >= memory.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(idx), "Index is out of the bounds of the array.");
            }
            return memory[idx];
        }

        public void displayMemoryHistroy()
        {
            for (int i = 0; i < memory.Length && i < index; i++)
            {
                Console.WriteLine("계산기록: " + memory[i]);
            }
        }
    }
}
