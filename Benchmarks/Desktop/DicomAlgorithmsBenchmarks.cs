using System;
using BenchmarkDotNet.Attributes;
using Dicom.Imaging.Algorithms;

namespace DICOM.Benchmarks.Desktop
{
    public class DicomAlgorithmsBenchmarks
    {
        private byte[] data;
        private int width, height;

        [Params(500)]
        public int InputSizePx;

        [Params(1000)]
        public int OutputSizePx;

        [GlobalSetup]
        public void Setup()
        {
            data = new byte[InputSizePx*InputSizePx];
            new Random().NextBytes(data);
        }

        [Benchmark]
        public void RescaleGrayscale_ParallelFor()
        {
            BilinearInterpolation.RescaleGrayscale(
                data, InputSizePx, InputSizePx, OutputSizePx, OutputSizePx);
        }

        // [Benchmark]
        // public void RescaleGrayscale_RegularForLoop()
        // {
        //     BilinearInterpolation.RescaleGrayscale_RegularForLoop(
        //         data, InputSizePx, InputSizePx, OutputSizePx, OutputSizePx);
        // }

        [Benchmark]
        public void RescaleGrayscale_UseMatrix()
        {
            BilinearInterpolation.RescaleGrayscaleUseFloat(
                data, InputSizePx, InputSizePx, OutputSizePx, OutputSizePx);
        }

        // [Benchmark]
        // public void RescaleGrayscale_UseMatrix_LessVars()
        // {
        //     BilinearInterpolation.RescaleGrayscale_UseMatrix_LessVars(
        //         data, InputSizePx, InputSizePx, OutputSizePx, OutputSizePx);
        // }
    }
}
