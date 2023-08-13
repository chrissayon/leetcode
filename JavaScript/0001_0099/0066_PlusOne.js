function PlusOneSimple(digits) {
	// We create a new array because the digits parameters is pass by reference
	// We don't want to mess with the original array
	let newArray = [...digits];
	let length = digits.length;

	for (let i = length - 1; i >= 0; i--) {
		if (digits[i] != 9) {
			newArray[i]++;
			return newArray;
		} else {
			newArray[i] = 0;
		}
	}

	// We only reach this point if we the 1 is carried all the way to the beginning, like having a 99 or 999 input
	let carriedAllTheWayArray = new Array(length + 1).fill(0);
	carriedAllTheWayArray[0] = 1;

	return carriedAllTheWayArray;
}
