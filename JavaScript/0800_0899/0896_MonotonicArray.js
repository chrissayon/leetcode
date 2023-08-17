function MonotonicArrayLinear(nums) {
	let up = null;

	for (i = 0; i < nums.length - 1; i++) {
		if (nums[i] == nums[i + 1]) {
			continue;
		} else if (up == null) {
			up = nums[i] < nums[i + 1];
		} else {
			if (up & (nums[i] > nums[i + 1])) {
				return false;
			} else if (!up & (nums[i] < nums[i + 1])) {
				return false;
			}
		}
	}

	return true;
}

function MonotonicArrayDoubleLoop(nums) {
	return Increasing(nums) || Decreasing(nums);
}

// Part of MonotonicArrayDoubleLoop
function Increasing(nums) {
	length = nums.length;

	for (i = 0; i < length - 1; i++) {
		if (nums[i] < nums[i + 1]) {
			return false;
		}
	}

	return true;
}

// Part of MonotonicArrayDoubleLoop
function Decreasing(nums) {
	length = nums.length;

	for (i = 0; i < length - 1; i++) {
		if (nums[i] > nums[i + 1]) {
			return false;
		}
	}

	return true;
}
