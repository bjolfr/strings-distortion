// Permutation.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Lib.h"
#include <iostream>

int main()
{
	string pattern, text;
	
	std::cout<<"Insert first line which contains pattern and next line which contains a text string:\n";

	std::getline(std::cin, pattern);
	std::getline(std::cin, text);

	std::cout << Lib::CalcPattern(pattern, text);
    return 0;
}

