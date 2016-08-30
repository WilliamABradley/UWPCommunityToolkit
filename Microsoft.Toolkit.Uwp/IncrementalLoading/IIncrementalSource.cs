﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp
{
    /// <summary>
    /// This class represents a data source which elements can be loaded incrementally.
    /// </summary>
    /// <typeparam name="TSource">Type of collection element.</typeparam>
    /// <seealso cref="IncrementalLoadingCollection{TSource, IType}"/>
    public interface IIncrementalSource<TSource>
    {
        /// <summary>
        /// Retrieves items based on <paramref name="pageIndex"/> and <paramref name="pageSize"/> arguments.
        /// </summary>
        /// <param name="pageIndex">
        /// The zero-based index of the page that corresponds to the items to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of <typeparamref name="TSource"/> items to retrieve for the specified <paramref name="pageIndex"/>.
        /// </param>
        /// <returns>
        /// Returns a collection of <typeparamref name="TSource"/>.
        /// </returns>
        Task<IEnumerable<TSource>> GetPagedItemsAsync(int pageIndex, int pageSize);

        /// <summary>
        /// Gets a value indicating whether the collection contains more items to retrieve.
        /// </summary>
        bool HasMoreItems { get; }
    }
}
