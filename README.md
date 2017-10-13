# libgdither-0.6-net

This project is a C# wrapper for [libgdither-0.6](https://github.com/aybe/libgdither-0.6).

- there are [overloads](https://github.com/aybe/libgdither-0.6-net/blob/master/libgdither-0.6-net/GDither.cs) for all numeric types but there is also good ol' `IntPtr`
- it's `AnyCPU` and you will need to call `LoadLibrary` to load the right *bitness* of `libgdither-0.6.dll`
- documentation is [here](https://github.com/aybe/libgdither-0.6/blob/master/gdither.h)
