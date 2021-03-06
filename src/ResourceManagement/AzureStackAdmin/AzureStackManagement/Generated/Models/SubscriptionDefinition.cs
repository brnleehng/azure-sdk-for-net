// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class SubscriptionDefinition
    {
        private IList<PlanReferenceDefinition> _acquiredPlans;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<PlanReferenceDefinition> AcquiredPlans
        {
            get { return this._acquiredPlans; }
            set { this._acquiredPlans = value; }
        }
        
        private string _delegatedProviderId;
        
        /// <summary>
        /// Optional. The provider ID under which the subscription exists.
        /// </summary>
        public string DelegatedProviderId
        {
            get { return this._delegatedProviderId; }
            set { this._delegatedProviderId = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _externalReferenceId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string ExternalReferenceId
        {
            get { return this._externalReferenceId; }
            set { this._externalReferenceId = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _offerDisplayName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string OfferDisplayName
        {
            get { return this._offerDisplayName; }
            set { this._offerDisplayName = value; }
        }
        
        private string _offerId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string OfferId
        {
            get { return this._offerId; }
            set { this._offerId = value; }
        }
        
        private string _offerName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string OfferName
        {
            get { return this._offerName; }
            set { this._offerName = value; }
        }
        
        private string _owner;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }
        
        private QuotaSyncState _quotaSyncState;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public QuotaSyncState QuotaSyncState
        {
            get { return this._quotaSyncState; }
            set { this._quotaSyncState = value; }
        }
        
        private IList<ServiceQuotaDefinition> _serviceQuotas;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<ServiceQuotaDefinition> ServiceQuotas
        {
            get { return this._serviceQuotas; }
            set { this._serviceQuotas = value; }
        }
        
        private SubscriptionState _state;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public SubscriptionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionDefinition class.
        /// </summary>
        public SubscriptionDefinition()
        {
            this.AcquiredPlans = new LazyList<PlanReferenceDefinition>();
            this.ServiceQuotas = new LazyList<ServiceQuotaDefinition>();
        }
    }
}
