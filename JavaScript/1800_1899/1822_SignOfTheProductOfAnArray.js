function SignOfTheProductOfAnArrayLinear(nums) {
	let minusCount = 0;

	for (let num of nums) {
		if (num == 0) return 0;
		if (num < 0) minusCount++;
	}

	return minusCount % 2 == 0 ? 1 : -1;
}
