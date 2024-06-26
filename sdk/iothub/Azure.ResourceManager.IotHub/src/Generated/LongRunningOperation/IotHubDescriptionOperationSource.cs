// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IotHub
{
    internal class IotHubDescriptionOperationSource : IOperationSource<IotHubDescriptionResource>
    {
        private readonly ArmClient _client;

        internal IotHubDescriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        IotHubDescriptionResource IOperationSource<IotHubDescriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IotHubDescriptionData.DeserializeIotHubDescriptionData(document.RootElement);
            return new IotHubDescriptionResource(_client, data);
        }

        async ValueTask<IotHubDescriptionResource> IOperationSource<IotHubDescriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IotHubDescriptionData.DeserializeIotHubDescriptionData(document.RootElement);
            return new IotHubDescriptionResource(_client, data);
        }
    }
}
