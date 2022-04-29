// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SiteGetByPathRequestBuilder.
    /// </summary>
    public partial class SiteGetByPathRequestBuilder : BaseFunctionMethodRequestBuilder<ISiteGetByPathRequest>, ISiteGetByPathRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SiteGetByPathRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="path">A path parameter for the OData method call.</param>
        public SiteGetByPathRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string path)
            : base(requestUrl, client)
        {
            this.SetParameter("path", path, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISiteGetByPathRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new SiteGetByPathRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for SiteAddRequestBuilder.
        /// </summary>
        /// <param name="value">A value parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteAddRequestBuilder"/>.</returns>
        public ISiteAddRequestBuilder Add(
            IEnumerable<Site> value)
        {
            return new SiteAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                value);
        }
        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByIntervalRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval()
        {
            return new SiteGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByIntervalRequestBuilder.
        /// </summary>
        /// <param name="startDateTime">A startDateTime parameter for the OData method call.</param>
        /// <param name="endDateTime">A endDateTime parameter for the OData method call.</param>
        /// <param name="interval">A interval parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime,
            string endDateTime,
            string interval)
        {
            return new SiteGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client,
                startDateTime,
                endDateTime,
                interval);
        }
        /// <summary>
        /// Gets the request builder for SiteGetApplicableContentTypesForListRequestBuilder.
        /// </summary>
        /// <param name="listId">A listId parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetApplicableContentTypesForListRequestBuilder"/>.</returns>
        public ISiteGetApplicableContentTypesForListRequestBuilder GetApplicableContentTypesForList(
            string listId)
        {
            return new SiteGetApplicableContentTypesForListRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getApplicableContentTypesForList"),
                this.Client,
                listId);
        }
        /// <summary>
        /// Gets the request builder for SiteGetByPathRequestBuilder.
        /// </summary>
        /// <param name="path">A path parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetByPathRequestBuilder"/>.</returns>
        public ISiteGetByPathRequestBuilder GetByPath(
            string path)
        {
            return new SiteGetByPathRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getByPath"),
                this.Client,
                path);
        }
        /// <summary>
        /// Gets the request builder for SiteRemoveRequestBuilder.
        /// </summary>
        /// <param name="value">A value parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteRemoveRequestBuilder"/>.</returns>
        public ISiteRemoveRequestBuilder Remove(
            IEnumerable<Site> value)
        {
            return new SiteRemoveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.remove"),
                this.Client,
                value);
        }
        /// <summary>
        /// Gets the request builder for Analytics.
        /// Analytics about the view activities that took place in this site.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsRequestBuilder"/>.</returns>
        public IItemAnalyticsRequestBuilder Analytics
        {
            get
            {
                return new ItemAnalyticsRequestBuilder(this.AppendSegmentToRequestUrl("analytics"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Columns.
        /// The collection of column definitions reusable across lists under this site.
        /// </summary>
        /// <returns>The <see cref="IColumnDefinitionRequestBuilder"/>.</returns>
        public IColumnDefinitionRequestBuilder Columns
        {
            get
            {
                return new ColumnDefinitionRequestBuilder(this.AppendSegmentToRequestUrl("columns"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for ContentTypes.
        /// The collection of content types defined for this site.
        /// </summary>
        /// <returns>The <see cref="IContentTypeRequestBuilder"/>.</returns>
        public IContentTypeRequestBuilder ContentTypes
        {
            get
            {
                return new ContentTypeRequestBuilder(this.AppendSegmentToRequestUrl("contentTypes"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Drive.
        /// The default drive (document library) for this site.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl("drive"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Drives.
        /// The collection of drives (document libraries) under this site.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder Drives
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl("drives"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for ExternalColumns.
        /// The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.
        /// </summary>
        /// <returns>The <see cref="IColumnDefinitionRequestBuilder"/>.</returns>
        public IColumnDefinitionRequestBuilder ExternalColumns
        {
            get
            {
                return new ColumnDefinitionRequestBuilder(this.AppendSegmentToRequestUrl("externalColumns"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Items.
        /// Used to address any item contained in this site. This collection cannot be enumerated.
        /// </summary>
        /// <returns>The <see cref="IBaseItemRequestBuilder"/>.</returns>
        public IBaseItemRequestBuilder Items
        {
            get
            {
                return new BaseItemRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Lists.
        /// The collection of lists under this site.
        /// </summary>
        /// <returns>The <see cref="IListRequestBuilder"/>.</returns>
        public IListRequestBuilder Lists
        {
            get
            {
                return new ListRequestBuilder(this.AppendSegmentToRequestUrl("lists"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Onenote.
        /// Calls the OneNote service for notebook related operations.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        public IOnenoteRequestBuilder Onenote
        {
            get
            {
                return new OnenoteRequestBuilder(this.AppendSegmentToRequestUrl("onenote"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Operations.
        /// The collection of long running operations for the site.
        /// </summary>
        /// <returns>The <see cref="IRichLongRunningOperationRequestBuilder"/>.</returns>
        public IRichLongRunningOperationRequestBuilder Operations
        {
            get
            {
                return new RichLongRunningOperationRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Permissions.
        /// The permissions associated with the site. Nullable.
        /// </summary>
        /// <returns>The <see cref="IPermissionRequestBuilder"/>.</returns>
        public IPermissionRequestBuilder Permissions
        {
            get
            {
                return new PermissionRequestBuilder(this.AppendSegmentToRequestUrl("permissions"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Sites.
        /// The collection of the sub-sites under this site.
        /// </summary>
        /// <returns>The <see cref="ISiteRequestBuilder"/>.</returns>
        public ISiteRequestBuilder Sites
        {
            get
            {
                return new SiteRequestBuilder(this.AppendSegmentToRequestUrl("sites"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for TermStore.
        /// The termStore under this site.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.TermStore.IStoreRequestBuilder"/>.</returns>
        public Microsoft.Graph.TermStore.IStoreRequestBuilder TermStore
        {
            get
            {
                return new Microsoft.Graph.TermStore.StoreRequestBuilder(this.AppendSegmentToRequestUrl("termStore"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for TermStores.
        /// The collection of termStores under this site.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.TermStore.IStoreRequestBuilder"/>.</returns>
        public Microsoft.Graph.TermStore.IStoreRequestBuilder TermStores
        {
            get
            {
                return new Microsoft.Graph.TermStore.StoreRequestBuilder(this.AppendSegmentToRequestUrl("termStores"), this.Client);
            }
        }
    }
}
