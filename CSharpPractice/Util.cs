namespace Util{

    class Sort{
        public static int[] Qsort(int[] arr){
            int pivotIndex = arr.Length / 2;
            int leftBound = 0;
            int rightBound = arr.Length - 1;

            if(arr.Length <= 1){
                return arr;
            }

            //swap pivot with last element in the array
            int temp = arr[pivotIndex];
            arr[pivotIndex] = arr[arr.Length-1];
            arr[arr.Length-1] = temp;
            pivotIndex = arr.Length-1;

            while(leftBound<=rightBound){
                if(arr[leftBound] >= arr[pivotIndex] && arr[rightBound] <= arr[pivotIndex]){
                    arr = swap(arr, leftBound, rightBound);
                }

                //check bounds and move them if necessary
                if(!(arr[leftBound] > arr[pivotIndex])){
                    leftBound += 1;
                }

                if(!(arr[rightBound] < arr[pivotIndex])){
                    rightBound -= 1;
                }
            }

            //swap pivot to its final location
            arr = swap(arr, leftBound, pivotIndex);

            //create new arrays for recursion.
            int[] left = new int[leftBound];
            int[] right = new int[arr.Length - leftBound];
            Array.Copy(arr, 0, left, 0, left.Length);
            Array.Copy(arr, leftBound, right, 0, arr.Length - leftBound);

            //Recursively sort those new arrays
            left = Qsort(left);
            right = Qsort(right);

            //construct new return array
            int[] returnArr = new int[arr.Length];
            Array.Copy(left, 0, returnArr, 0, left.Length);
           // returnArr[leftBound] = arr[leftBound];
            Array.Copy(right, 0, returnArr, left.Length, right.Length);

            return returnArr;
        }

        //will swap two positions in the array
        //doesn't return new array but instead changes the original array in place
        private static int[] swap(int[] arr, int leftInd, int rightInd){
            int[] newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);

            int tempLeft = newArr[leftInd];
            newArr[leftInd] = newArr[rightInd];
            newArr[rightInd] = tempLeft; 

            return newArr; 
        }

        //tests
        public static bool testSwap(){
            int[] expected = {5,2,3,4,1};
            int[] input = {1,2,3,4,5};
            int[] output;

            output = swap(input, 0, 4);

            for(int i = 0; i < expected.Length; i++){
                if(expected[i] != output[i]){
                    return false;
                }
            }
            return true;
        }
    }

    
}