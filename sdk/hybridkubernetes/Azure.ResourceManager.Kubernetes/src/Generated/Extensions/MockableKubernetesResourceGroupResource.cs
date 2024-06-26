// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableKubernetesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableKubernetesResourceGroupResource"/> class for mocking. </summary>
        protected MockableKubernetesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableKubernetesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableKubernetesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ConnectedClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ConnectedClusterResources and their operations over a ConnectedClusterResource. </returns>
        public virtual ConnectedClusterCollection GetConnectedClusters()
        {
            return GetCachedClient(client => new ConnectedClusterCollection(client, Id));
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConnectedClusterResource>> GetConnectedClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetConnectedClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConnectedClusterResource> GetConnectedCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetConnectedClusters().Get(clusterName, cancellationToken);
        }
    }
}
