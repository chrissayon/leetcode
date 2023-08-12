function TwoSumBruteForce(nums, target) {
	let length = nums.length;
	let index1 = 0;
	let index2 = 1;
	let output = [index1, index2];

	while (index1 < length || index2 < length) {
		result = nums[index1] + nums[index2];

		if (result == target) {
			output[0] = index1;
			output[1] = index2;
			return output;
		}

		index2++;
		if (index2 >= length) {
			index1++;
			index2 = index1 + 1;
		}
	}

	return output;
}

function TwoSumHashTable(nums, target) {
	let map = new Map();
	let length = nums.length;

	for (let i = 0; i < length; i++) {
		let complement = target - nums[i];

		if (map.has(complement)) {
			return [map.get(complement), i];
		} else if (!map.has(nums[i])) {
			map.set(nums[i], i);
		}
	}

	return [];
}
