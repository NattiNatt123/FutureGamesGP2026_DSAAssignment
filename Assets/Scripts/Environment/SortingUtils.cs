using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment
{
    public class GenericQueue<T> {
        private List<T> queue;
        public GenericQueue() {
            queue = new List<T>();
        }

        public void Enqueue(T InNewElement) {
            queue.Add(InNewElement);
        }
        public T Peek() {
            if(queue.Count == 0) {
                throw new Exception("The queue is empty, cannoy peek.");
            }
            return queue[0];
        }
        public T Dequeue()
        {
        if(queue.Count == 0)
        {
            throw new Exception("The queue is empty, cannot Dequeue.");
        }
        T topOfQueue = queue[0];
        queue.RemoveAt(index: 0);      
        }
   
    private static void Merge(int[] inArray, int Left, int Middle, int Right)
    {
        int sizeLeft = Middle - Left + 1;
        int sizeRight = Right - (Middle + 1) + 1;

        int[] tempLeft = new int[sizeLeft];
        int[] tempRight = new int[sizeRight];

        int i = 0;
        int j = 0;

        for(i = 0; i < sizeLeft; i++) {
            tempLeft[i] = inArray[i + Left];
        }
        for(j = 0; j < sizeRight; j++) {
            tempRight[j] = inArray[j + Middle + 1];
        }

        i = 0;
        j = 0;
        int k = Left;
        while(i < sizeLeft && j < sizeRight)
        {
            if(tempLeft[i] <= tempRight[j])
            {
                inArray[k] = tempLeft[i];
                i++;
            }
            else
            {
                inArray[k] = tempRight[j];
                j++;
            }
            k++;
        }

        while (i < sizeLeft)
        {
            inArray[k] = tempLeft[i];
            i++;
            k++;
        }
        while (j < sizeRight)
        {
            inArray[k] = tempRight[j];
            j++;
            k++;
        }
    }

    private static void MergeSort(
        int[] inArray, int Left, int Right)
    {
        if(Left < Right)
        {
            int Middle = Left + ((Right - Left) / 2);
            MergeSort(inArray, Left, Middle);
            MergeSort(inArray, Middle + 1, Right);
            Merge(inArray, Left, Middle, Right);
        }
    }
 }

}
