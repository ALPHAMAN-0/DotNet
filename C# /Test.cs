using System;
class Program
{
	static void Main(string[] args)
	{
		int[][] myArray = new int[4][];
		myArray[0] = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
		myArray[1] = new int[3];
		myArray[2] = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
		myArray[3] = new int[3];

		for (int row = 0; row < 4; row += 2)
			for (int column = 0; column < myArray[row].Length; column += 3)
				Console.Write("{0} ", myArray[row][column]);
		Console.WriteLine();

		for (int index = 0; index < myArray[1].Length; index += 2)
			myArray[1][index] = myArray[0][index + 2] - myArray[0][index];

		for (int index = 0; index < myArray[3].Length; index++)
			myArray[3][index] = myArray[2][index] + myArray[2][index + 3];

		for (int row = 1; row < 4; row += 2)
			for (int column = 0; column < myArray[row].Length; column += 2)
				Console.Write("{0} ", myArray[row][column]);
		Console.WriteLine();
	}
}