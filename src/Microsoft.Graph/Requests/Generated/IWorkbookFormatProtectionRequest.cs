// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookFormatProtectionRequest.
    /// </summary>
    public partial interface IWorkbookFormatProtectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookFormatProtection using POST.
        /// </summary>
        /// <param name="workbookFormatProtectionToCreate">The WorkbookFormatProtection to create.</param>
        /// <returns>The created WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> CreateAsync(WorkbookFormatProtection workbookFormatProtectionToCreate);        /// <summary>
        /// Creates the specified WorkbookFormatProtection using POST.
        /// </summary>
        /// <param name="workbookFormatProtectionToCreate">The WorkbookFormatProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> CreateAsync(WorkbookFormatProtection workbookFormatProtectionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookFormatProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookFormatProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookFormatProtection.
        /// </summary>
        /// <returns>The WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookFormatProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookFormatProtection using PATCH.
        /// </summary>
        /// <param name="workbookFormatProtectionToUpdate">The WorkbookFormatProtection to update.</param>
        /// <returns>The updated WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> UpdateAsync(WorkbookFormatProtection workbookFormatProtectionToUpdate);

        /// <summary>
        /// Updates the specified WorkbookFormatProtection using PATCH.
        /// </summary>
        /// <param name="workbookFormatProtectionToUpdate">The WorkbookFormatProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookFormatProtection.</returns>
        System.Threading.Tasks.Task<WorkbookFormatProtection> UpdateAsync(WorkbookFormatProtection workbookFormatProtectionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFormatProtectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFormatProtectionRequest Expand(Expression<Func<WorkbookFormatProtection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFormatProtectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFormatProtectionRequest Select(Expression<Func<WorkbookFormatProtection, object>> selectExpression);

    }
}
