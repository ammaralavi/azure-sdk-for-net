// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of OSFamily and their operations over its parent. </summary>
    public partial class OSFamilyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOperatingSystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="OSFamilyCollection"/> class for mocking. </summary>
        protected OSFamilyCollection()
        {
        }

        /// <summary> Initializes a new instance of OSFamilyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OSFamilyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OSFamily> Get(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, location, osFamilyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSFamily(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OSFamily>> GetAsync(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, location, osFamilyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSFamily(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OSFamily> GetIfExists(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, location, osFamilyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<OSFamily>(null, response.GetRawResponse())
                    : Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OSFamily>> GetIfExistsAsync(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, location, osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<OSFamily>(null, response.GetRawResponse())
                    : Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, osFamilyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Name of the location that the OS family pertains to. </param>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string location, string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OSFamily> GetAll(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<OSFamily> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamilies(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OSFamily> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OSFamily> GetAllAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<OSFamily>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OSFamily>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OSFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OSFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, OSFamily, OSFamilyData> Construct() { }
    }
}
