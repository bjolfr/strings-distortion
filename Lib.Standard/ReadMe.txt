﻿TASK 1:

	Having the following interface

	interface CharStream {
	  boolean hasNext();
	  char next();
	}

	implement bracket string validation, e.g. "()(([]))" is valid and "(]" is not. 
	Recursive implementation is required and you have the following signature:

	public boolean isValid(CharStream in) {
		// your code here
	}

TASK 2:

	You have a string str = "I love you". 
	Write a program to print the output as "you love I". Calculate the efficiency of your coding.

TASK 3:

	Write code to reverse a 
	char[] ar = {'A','R','G','E','N','T','I','N','A'} 
	without using any other array or creating objects

TASK 4:

	Double the array element if two elements are same make first element
	double and second element 0 move all zero to end
	I/P: 2,2,0,4,8,0,0
	O/P: 4,4,8,0,0,0,0
