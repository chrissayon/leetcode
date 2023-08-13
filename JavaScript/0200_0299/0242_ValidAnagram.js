function ValidAnagramShortCircuit(s, t) {
	if (s.length != t.length) {
		return false;
	}

	let obj = {};
	let length = s.length;

	for (let i = 0; i < length; i++) {
		obj[s[i]] = (obj[s[i]] || 0) + 1;
		obj[t[i]] = (obj[t[i]] || 0) - 1;
	}

	return Object.values(obj).every((value) => value == 0);
}
