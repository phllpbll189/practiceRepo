namespace Util{

    class Sort{
        static int[] Qsort(int[] arr){
            int pivotIndex = arr.Length / 2;
            int leftBound = 0;
            int rightBound = arr.Length - 1;

            bool boundsNotCrossed = leftBound<rightBound;

            if(arr.Length <= 1){
                return arr;
            }

            //swap pivot with last element in the array
            int temp = arr[pivotIndex];
            arr[pivotIndex] = arr[arr.Length-1];
            arr[arr.Length-1] = temp;

            while(boundsNotCrossed){
                //if left bound is greater than pivot
                //left bound stays where it is
                if(!(arr[leftBound] > arr[pivotIndex])){
                    leftBound += 1;
                }

                //and right bound is less than pivot
                //right bound stays where it is
                if(!(arr[rightBound] < arr[pivotIndex])){
                    rightBound -= 1;
                }

                if(arr[leftBound] > arr[pivotIndex] && arr[rightBound] < arr[pivotIndex]){
                    int tempLeft = arr[leftBound];
                    arr[leftBound] = arr[rightBound];
                    arr[rightBound] = tempLeft;
                }

                //when they are both staying
                //switch

                //if bounds are crossed
                //swap pivot with left bound


                    //NOT SUDO CODE JUST NOTES
                    //this is because either left bound will stop on something greater
                    //and thus the element belongs in right array
                    //or right bound stopped on something smaller and left bound crossed
                    //thus the pivots position is right after the right bound
                    //this would be different if we moved the pivot to the beginning of the array instead of the end
            }
                    int[] defaultRet = {1,2,3,4};
                    return defaultRet;
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