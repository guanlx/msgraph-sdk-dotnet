// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIdentityApiConnectorRequest.
    /// </summary>
    public partial interface IIdentityApiConnectorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityApiConnector using POST.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityApiConnector.</returns>
        System.Threading.Tasks.Task<IdentityApiConnector> CreateAsync(IdentityApiConnector identityApiConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IdentityApiConnector using POST and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToCreate">The IdentityApiConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> CreateResponseAsync(IdentityApiConnector identityApiConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IdentityApiConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IdentityApiConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IdentityApiConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityApiConnector.</returns>
        System.Threading.Tasks.Task<IdentityApiConnector> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IdentityApiConnector and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityApiConnector.</returns>
        System.Threading.Tasks.Task<IdentityApiConnector> UpdateAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IdentityApiConnector using PATCH and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityApiConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> UpdateResponseAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IdentityApiConnector using PUT.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IdentityApiConnector> PutAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IdentityApiConnector using PUT and returns a <see cref="GraphResponse{IdentityApiConnector}"/> object.
        /// </summary>
        /// <param name="identityApiConnectorToUpdate">The IdentityApiConnector object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IdentityApiConnector}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityApiConnector>> PutResponseAsync(IdentityApiConnector identityApiConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityApiConnectorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityApiConnectorRequest Expand(Expression<Func<IdentityApiConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityApiConnectorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityApiConnectorRequest Select(Expression<Func<IdentityApiConnector, object>> selectExpression);

    }
}
