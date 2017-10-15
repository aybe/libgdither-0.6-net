# libgdither-0.6-net

This is a C# wrapper for the [libgdither-0.6](https://github.com/aybe/libgdither-0.6) library.

## Usage

- binaries are [here](https://github.com/aybe/libgdither-0.6-net/releases)
- documentation is [here](https://github.com/aybe/libgdither-0.6/blob/master/gdither.h)
- different [overloads](https://github.com/aybe/libgdither-0.6-net/blob/master/libgdither-0.6-net/GDither.cs) available: `IntPtr`, `byte`, `short`, `int`, `float`, `double`
- `AnyCPU` build (you will therefore have to call `LoadLibrary` to load the right bitness of `libgdither-0.6.dll`)
