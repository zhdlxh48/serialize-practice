#include <string.h>
#include "test_struct.h"

#define MAX_STR_LEN 16

extern "C" __declspec(dllexport) double DLL_Sum(double a, double b) {
	return a + b;
}

extern "C" __declspec(dllexport) void DLL_UpdateTestStructure(struct TestStruct* ts, int a, float b, char* c) {
	ts->a = a;
	ts->b = b;
	strcpy_s(ts->c, MAX_STR_LEN, c);
}