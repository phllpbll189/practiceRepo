namespace Sort{

    class Sort{
        static void Qsort(int[] arr){
            int pivotIndex = arr.length / 2;
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
        }

        
        private static swap(int[] arr, int leftInd, int rightInd){
            int tempLeft = arr[leftInd];
            arr[leftInd] = arr[rightInd];
            arr[rightInd] = tempLeft;  
        }
    }

    
}