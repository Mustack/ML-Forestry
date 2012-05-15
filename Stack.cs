using System;

using System.Collections.Generic;
using System.Text;

namespace ML_Forest
{

    //So because WM6.5 enjoys making things hard for programmers,
    //I have to impliment my own stack. To do this, I use a circular array.
    //I didn't bother with generic data types, I only need int for this project.
    class Stack
    {
        int index;
        int limit;
        int[] stack;

        public Stack(int size)
        {
            index = 0;
            limit = size;
            stack = new int[limit];
        }

        //Push the thing!
        public void push(int thing)
        {
            stack[index % limit] = thing;
            index++;
        }

        //Pop the thing!
        public int pop()
        {
            if (index == 0) return -1;
            index--;
            return stack[index % limit];
        }
    }
}
