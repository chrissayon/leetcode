function RepeatedSubstringPatternCheck(s) {
	for (let i = Math.floor(s.length / 2); i >= 1; i--) {
		if (s.length % i == 0) {
			let subString = s.substring(0, i);
			let repeatedSubString = subString.repeat(s.length / i);

			if (repeatedSubString === s) {
				return true;
			}
		}
	}

	return false;
}
