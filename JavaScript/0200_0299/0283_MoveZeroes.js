function MoveZeroesLinear(nums) {
	let length = nums.length;
	let newArray = new int[length]();
	let newArrayPointer = 0;

	for (let i = 0; i < length; i++) {
		if (nums[i] != 0) {
			newArray[newArrayPointer] = nums[i];
			newArrayPointer++;
		}
	}

	for (let i = 0; i < length; i++) {
		nums[i] = newArray[i];
	}
}

function MoveZeroesTwoPointer(nums) {
	length = nums.length;
	swapIndex = 0;

	for (i = 0; i < length; i++) {
		if (nums[i] != 0) {
			temp = nums[i];
			nums[i] = nums[swapIndex];
			nums[swapIndex] = temp;
			swapIndex++;
		}
	}
}
