﻿/* Copyright 2010-2013 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver.Internal;

namespace MongoDB.Driver.Communication.Security
{
    /// <summary>
    /// Authenticates a MongoConnection.
    /// </summary>
    internal interface IAuthenticationMethod
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Authenticates the specified connection with the given credentials.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="credentials">The credentials.</param>
        void Authenticate(MongoConnection connection, MongoCredentials credentials);

        /// <summary>
        /// Determines whether this instance can use the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials.</param>
        /// <returns>
        ///   <c>true</c> if this instance can use the specified credentials; otherwise, <c>false</c>.
        /// </returns>
        bool CanUse(MongoCredentials credentials);
    }
}
