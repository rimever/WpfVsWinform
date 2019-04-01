using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace WpfVsWinForm.Benchmark.Tests
{
    /// <summary>
    /// <see cref="SimpleWindowBenchmark"/>をテストするクラスです。
    /// </summary>
    [TestFixture]
    public class SimpleWindowBenchmarkTest
    {
        [Test]
        public void LaunchWpfSimpleWindow()
        {
            var benchmark = new SimpleWindowBenchmark();
            benchmark.LaunchWpfSimpleWindow();
        }
        [Test]
        public void LaunchWinFormSimpleWindow()
        {
            var benchmark = new SimpleWindowBenchmark();
            benchmark.LaunchWinFormSimpleWindow();
        }
        [Test]
        public void LaunchWpfCoreSimpleWindow()
        {
            var benchmark = new SimpleWindowBenchmark();
            benchmark.LaunchWpfCoreSimpleWindow();
        }
        [Test]
        public void LaunchWinFormsSimpleWindow()
        {
            var benchmark = new SimpleWindowBenchmark();
            benchmark.LaunchWinFormCoreSimpleWindow();
        }

    }
}
