// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     Represents a database function parameter in an <see cref="IDbFunction" />.
    /// </summary>
    public interface IDbFunctionParameter
    {
        /// <summary>
        ///     Gets the <see cref="IDbFunction" /> to which this parameter belongs.
        /// </summary>
        IDbFunction Function { get; }

        /// <summary>
        ///     Gets the parameter name.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Gets the parameter type.
        /// </summary>
        Type ClrType { get; }

        /// <summary>
        ///     Gets the store type of this parameter.
        /// </summary>
        string StoreType { get; }

        /// <summary>
        ///     Gets the <see cref="RelationalTypeMapping" /> for this parameter.
        /// </summary>
        RelationalTypeMapping TypeMapping { get; }
    }
}
