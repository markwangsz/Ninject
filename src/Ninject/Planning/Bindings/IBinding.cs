﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IBinding.cs" company="Ninject Project Contributors">
//   Copyright (c) 2007-2010 Enkari, Ltd. All rights reserved.
//   Copyright (c) 2010-2019 Ninject Project Contributors. All rights reserved.
//
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   You may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Ninject.Planning.Bindings
{
    using System;

    /// <summary>
    /// Contains information about a service registration.
    /// </summary>
    public interface IBinding : IBindingConfiguration
    {
        /// <summary>
        /// Gets the binding configuration.
        /// </summary>
        /// <value>The binding configuration.</value>
        IBindingConfiguration BindingConfiguration { get; }

        /// <summary>
        /// Gets the service type that is controlled by the binding.
        /// </summary>
        Type Service { get; }
    }
}