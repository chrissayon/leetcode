function mergeAlternately(word1, word2) {
	let word = '';
	let length1 = word1.length;
	let length2 = word2.length;
	let pointer1 = 0;
	let pointer2 = 0;

	while (pointer1 < length1 || pointer2 < length2) {
		if (pointer1 < length1) {
			word += word1[pointer1];
			pointer1++;
		}

		if (pointer2 < length2) {
			word += word2[pointer2];
			pointer2++;
		}
	}

	return word;
}
