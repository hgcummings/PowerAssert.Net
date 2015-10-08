﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PowerAssert.Extension
{
    public static class PAssertExtension
    {
        public static void PAssert<T>(this T target, Expression<Func<T, bool>> expression)
        {
            PowerAssert.PAssert.IsTrue(target, expression);
        }
    }
}