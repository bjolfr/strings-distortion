#include "stdafx.h"
#include "Lib.h"

const string Lib::YES = "YES";

const string Lib::NO = "NO";

string Lib::CalcPattern(std::string pattern, std::string text)
{
	size_t p = 0, m = 0,
		   pl = pattern.length(),
		   tl = text.length();

	for (size_t i = 0; i < pl; i++) p += pattern[i]; //Calc pattern

	for (size_t i = 0; i < tl - (pl - 1) && m != p; i++, m = m == p ? m : 0)
		for (size_t j = i; j < i + pl; j++)
			m += text[j];
	return m == p ? YES : NO;
}
