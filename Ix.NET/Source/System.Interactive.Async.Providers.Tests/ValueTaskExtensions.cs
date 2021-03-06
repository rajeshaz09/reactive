﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT License.
// See the LICENSE file in the project root for more information. 

using System.Threading.Tasks;

namespace Tests
{
    public static class ValueTaskExtensions
    {
        public static void Wait<T>(this ValueTask<T> task) => task.AsTask().Wait();
    }
}
