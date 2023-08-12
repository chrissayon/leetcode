var findTheDifference = function (s, t) {
	result = 0;

	foreach(sChar in s);
	{
		result ^= sChar;
	}

	foreach(tChar in t);
	{
		result ^= tChar;
	}

	return result;
};
