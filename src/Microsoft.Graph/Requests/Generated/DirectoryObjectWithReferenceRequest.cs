// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DirectoryObjectWithReferenceRequest.
    /// </summary>
    public partial class DirectoryObjectWithReferenceRequest : BaseRequest, IDirectoryObjectWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new DirectoryObjectWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DirectoryObjectWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <returns>The DirectoryObject.</returns>
        public System.Threading.Tasks.Task<DirectoryObject> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryObject.</returns>
        public async System.Threading.Tasks.Task<DirectoryObject> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DirectoryObject>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified DirectoryObject using POST.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <returns>The created DirectoryObject.</returns>
        public System.Threading.Tasks.Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate)
        {
            return this.CreateAsync(directoryObjectToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DirectoryObject using POST.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryObject.</returns>
        public async System.Threading.Tasks.Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DirectoryObject>(directoryObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <returns>The updated DirectoryObject.</returns>
        public System.Threading.Tasks.Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate)
        {
            return this.UpdateAsync(directoryObjectToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectoryObject.</returns>
        public async System.Threading.Tasks.Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DirectoryObject>(directoryObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DirectoryObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectWithReferenceRequest Expand(Expression<Func<DirectoryObject, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectWithReferenceRequest Select(Expression<Func<DirectoryObject, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

    }
}
