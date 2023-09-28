using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    [RankColumn]
    public class Paginator
    {
        private readonly DataContext dataContext;
        private readonly int _totalItems;
        private readonly int _pageSize;

        public Paginator()
        {
            dataContext = new DataContext();
            _totalItems = dataContext.Entities.Count();
            _pageSize = 50;
        }

      //  [Benchmark]
        public void GetLastPage()
        {
            var pages = _totalItems / _pageSize;
            var skip = (pages - 1) * _pageSize;
            var page = dataContext.Entities.OrderBy(e => e.MyProperty).Skip(skip).Take(_pageSize).ToList();
        }

     //   [Benchmark]
        public void GetLastPagewithCursor()
        {
            var cursorid = _totalItems / _pageSize;
            var page = dataContext.Entities.Where(e => e.MyProperty >= cursorid).OrderBy(e => e.MyProperty).Take(_pageSize).ToList();
        }

    //    [Benchmark]
        public void Cursor()
        {
            int? lastEntity = null;

            while (true)
            {
                var page = dataContext.Entities.Where(e => lastEntity == null || e.MyProperty > lastEntity).OrderBy(e => e.MyProperty).Take(_pageSize).ToList();

                if (!page.Any()) break;

                lastEntity = page.Last().MyProperty;
            }
        }
    }
}
