using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using FlaUI.UIA3;

namespace WpfVsWinForm.Benchmark
{
    [MarkdownExporter,CsvExporter]
    public class SimpleWindowBenchmark
    {
        /// <summary>
        /// 起動
        /// </summary>
        /// <param name="filePath"></param>
        public void Launch(string filePath)
        {
            var app = FlaUI.Core.Application.Launch(filePath);
            using (var automation = new UIA3Automation())
            {
                app.WaitWhileBusy();
                var window = app.GetMainWindow(automation);
                window.Close();
            }
        }

        public string RootDirectory
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"); }
        }

        [Benchmark]
        public void LaunchWpfSimpleWindow()
        {
            string path = Path.Combine(RootDirectory, "WpfSimpleWindow", "bin", "Release", "WpfSimpleWindow.exe");
            Launch(path);
        }

        [Benchmark]
        public void LaunchWinFormSimpleWindow()
        {
            string path = Path.Combine(RootDirectory, "WinFormSimpleWindow", "bin", "Release", "WinFormSimpleWindow.exe");
            Launch(path);
        }
    }
}
