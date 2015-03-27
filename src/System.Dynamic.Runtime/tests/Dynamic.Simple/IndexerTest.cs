﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace SampleDynamicTests
{
    public class IndexerTest
    {
        public int this[dynamic d = null, int i = 6]
        {
            get
            {
                if (d != null && i == 6)
                    return 2;
                else
                    return 3;
            }
        }
        [Fact]
        public static void IndexerTest_RunTest()
        {
            dynamic d = new IndexerTest();
            int x = d[d: new object()];

            Assert.Equal(2, x);
        }
    }
}
