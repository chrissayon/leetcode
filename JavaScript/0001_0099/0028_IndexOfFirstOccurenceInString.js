function IndexOfFirstOccurenceInStringSlidingWindow(haystack, needle) {
	let haystackLength = haystack.length;
	let needleLength = needle.length;
	let slidingPointerStart = 0;
	let slidingPointerEnd = 0;

	while (slidingPointerEnd < haystackLength) {
		for (let i = 0; i < needleLength; i++) {
			var slidingPointerIndex = slidingPointerStart + i;
			let reachedEndofHaystack = slidingPointerIndex >= haystackLength;

			if (reachedEndofHaystack || haystack[slidingPointerIndex] != needle[i]) {
				break;
			}

			if (i + 1 == needleLength) {
				return slidingPointerStart;
			}
		}

		slidingPointerStart++;
		slidingPointerEnd++;
	}

	return -1;
}
