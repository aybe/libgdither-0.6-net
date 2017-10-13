using System;
using System.Runtime.InteropServices;

namespace libgdither
{
    public static class GDither
    {
        public const string DllName = "libgdither-0.6.dll";

        private const CallingConvention Convention = CallingConvention.Cdecl;

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern IntPtr gdither_new(GDitherType type,
            uint channels, GDitherSize bitDepth, int ditherDepth = 0);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_free(IntPtr state);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, IntPtr x, IntPtr y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, float[] x, byte[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, float[] x, short[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, float[] x, int[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, float[] x, float[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_runf(IntPtr state, uint channel,
            uint length, float[] x, double[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, IntPtr x, IntPtr y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, double[] x, byte[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, double[] x, short[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, double[] x, int[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, double[] x, float[] y);

        [DllImport(DllName, CallingConvention = Convention)]
        public static extern void gdither_run(IntPtr state, uint channel,
            uint length, double[] x, double[] y);
    }
}