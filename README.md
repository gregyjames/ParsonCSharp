# ParsonCSharp
A C# wrapper for Parson built using SWIG.

Based off:
https://github.com/kgabis/parson

## Build
1. Change the swig and output path on the custom build tool (parson.i)
2. Compile Parson.i
3. Re-add parson_wrap.c and *.cs files back to respective projects.
