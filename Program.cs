﻿using System;

public class HeapSort
{
	public void sort(int[] arr)
	{
		int n = arr.Length;

		
		for (int i = n / 2 - 1; i >= 0; i--)
			heapify(arr, n, i);

		for (int i = n - 1; i > 0; i--)
		{
			
			int temp = arr[0];
			arr[0] = arr[i];
			arr[i] = temp;

			heapify(arr, i, 0);
		}
	}

	
	void heapify(int[] arr, int n, int i)
	{
		int largest = i; 
		int l = 2 * i + 1; 
		int r = 2 * i + 2; 

	
		if (l < n && arr[l] > arr[largest])
			largest = l;

		if (r < n && arr[r] > arr[largest])
			largest = r;

		
		if (largest != i)
		{
			int swap = arr[i];
			arr[i] = arr[largest];
			arr[largest] = swap;

			
			heapify(arr, n, largest);
		}
	}
	static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");
		Console.Read();
	}

	
	public static void Main()
	{
		int[] arr = { 67, 78, 1, 51, 36, 47 };
		int n = arr.Length;

		HeapSort ob = new HeapSort();
		ob.sort(arr);

		Console.WriteLine("Sorted array is");
		printArray(arr);
	}
}


