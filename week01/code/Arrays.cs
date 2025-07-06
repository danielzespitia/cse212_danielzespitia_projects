using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan to solve MultiplesOf:
        // 1. Create a new array of doubles with the specified 'length'. This will be our result array.
        // 2. Use a 'for' loop that iterates from 0 up to (but not including) 'length'. This loop will control which position in the array we are filling.
        // 3. Inside the loop, for each index 'i', calculate the corresponding multiple. The multiple is the initial 'number' multiplied by (i + 1). 
        //    (We use i + 1 because array indices start at 0, but we want the first multiple to be number * 1, the second to be number * 2, and so on).
        // 4. Assign the calculated multiple to the array at the current index 'i'.
        // 5. After the loop has finished, return the fully populated array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan to solve RotateListRight:
        // 1. Determine the starting index of the segment that needs to be moved. This segment is at the end of the list.
        //    The start index will be the total count of items in the list minus the 'amount' to rotate.
        // 2. Create a new temporary list to hold the segment that will be moved.
        // 3. Use the GetRange() method to copy the last 'amount' of elements from the 'data' list into our new temporary list.
        // 4. Use the RemoveRange() method to delete that same segment from the original 'data' list. Now the 'data' list is shorter.
        // 5. Use the InsertRange() method to insert the elements from our temporary list at the very beginning (index 0) of the 'data' list.
        // 6. The function is complete, and the original 'data' list is now correctly rotated. No return is needed as the list is modified directly.

        // Handle cases where amount is 0 or the list is empty to prevent errors.
        if (amount <= 0 || data.Count == 0)
        {
            return;
        }

        int startIndex = data.Count - amount;
        
        // Get the part of the list to move to the front.
        List<int> rangeToMove = data.GetRange(startIndex, amount);
        
        // Remove that part from the end of the list.
        data.RemoveRange(startIndex, amount);
        
        // Insert the removed part at the beginning of the list.
        data.InsertRange(0, rangeToMove);
    }
}
