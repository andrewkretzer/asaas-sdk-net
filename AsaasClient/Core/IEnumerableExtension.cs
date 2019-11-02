﻿using System.Collections.Generic;
using System.Linq;

namespace AsaasClient.Core
{
    public static class IEnumerableExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }
    }
}