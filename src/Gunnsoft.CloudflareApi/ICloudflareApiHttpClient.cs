﻿using System.Threading;
using System.Threading.Tasks;

namespace Gunnsoft.CloudflareApi
{
    public interface ICloudflareApiHttpClient
    {
        Task DeleteAsync(DeleteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        Task<TResponse> GetAsync<TResponse>(GetRequest request,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<TResponse> PostAsync<TResponse>(PostRequest request,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}