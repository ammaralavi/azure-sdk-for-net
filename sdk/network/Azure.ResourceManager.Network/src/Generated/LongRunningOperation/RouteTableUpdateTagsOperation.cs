// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates a route table tags. </summary>
    public partial class RouteTableUpdateTagsOperation : Operation<RouteTable>
    {
        private readonly OperationOrResponseInternals<RouteTable> _operation;

        /// <summary> Initializes a new instance of RouteTableUpdateTagsOperation for mocking. </summary>
        protected RouteTableUpdateTagsOperation()
        {
        }

        internal RouteTableUpdateTagsOperation(ArmResource operationsBase, Response<RouteTableData> response)
        {
            _operation = new OperationOrResponseInternals<RouteTable>(Response.FromValue(new RouteTable(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override RouteTable Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RouteTable>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RouteTable>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
