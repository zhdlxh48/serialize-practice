#pragma once

extern "C" __declspec(dllexport) double DLL_Sum(double a, double b);
extern "C" __declspec(dllexport) void DLL_UpdateTestStructure(struct TestStruct* ts, int a, float b, char* c);