// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


namespace Microsoft.AspNetCore.Authentication
{
    /// <summary>
    /// Name/Value representing a token.
    /// </summary>
    public class AuthenticationToken
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Value.
        /// </summary>
        public string Value { get; set; } = default!;
    }
}
