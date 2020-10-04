﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using BenchmarkDotNet.Running;

namespace DICOM.Benchmarks.Desktop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<DicomAlgorithmsBenchmarks>();
            // BenchmarkRunner.Run<DicomClientBenchmarks>();
        }
    }
}
