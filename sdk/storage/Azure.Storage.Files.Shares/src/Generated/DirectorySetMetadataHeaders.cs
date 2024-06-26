// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class DirectorySetMetadataHeaders
    {
        private readonly Response _response;
        public DirectorySetMetadataHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
    }
}
