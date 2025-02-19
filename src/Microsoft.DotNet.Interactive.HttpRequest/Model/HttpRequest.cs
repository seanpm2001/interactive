﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.DotNet.Interactive.HttpRequest;

public class HttpRequest
{
    public string Method { get; }
    public string Version { get; }
    public Dictionary<string, string[]> Headers { get; }
    public string? Uri { get; }
    public HttpContent? Content { get; }

    public HttpRequest(
        string method,
        string version,
        Dictionary<string, string[]> headers,
        string? uri = null,
        HttpContent? content = null)
    {
        Method = method;
        Version = version;
        Headers = headers;
        Uri = uri;
        Content = content;
    }
}
