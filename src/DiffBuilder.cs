﻿using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Egil.AngleSharp.Diffing.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egil.AngleSharp.Diffing
{
    public class DiffBuilder
    {
        private string _control = string.Empty;
        private string _test = string.Empty;

        public string Control { get => _control; set => _control = value ?? throw new ArgumentNullException(nameof(Control)); }

        public string Test { get => _test; set => _test = value ?? throw new ArgumentNullException(nameof(Test)); }

        private DiffBuilder(string control)
        {
            Control = control;
        }

        public DiffBuilder WithTest(string test)
        {
            Test = test;
            return this;
        }

        public static DiffBuilder Compare(string control)
        {
            return new DiffBuilder(control);
        }

        public DiffBuilder WithFilter(Func<ComparisonSource, bool> nodeFilter)
        {
            return this;
        }

        public IList<IDiff> Build()
        {
            //var context = BrowsingContext.New();
            //var htmlParser = context.GetService<IHtmlParser>();
            //var document = context.OpenNewAsync().Result;
            //var control = htmlParser.ParseFragment(Control, document.Body);
            //var test = htmlParser.ParseFragment(Test, document.Body);
            return Array.Empty<IDiff>();
        }
    }
}
