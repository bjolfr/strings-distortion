#include "stdafx.h"
#include "CppUnitTest.h"
#include "lib.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace SearchPatternsTest
{		
	TEST_CLASS(PermutationFixture)
	{
	public:
		
		TEST_METHOD(FunctionMustReturnYes)
		{
			Lib::CalcPattern("use", "question");
		}

	};
}