﻿/*
    eduOpenVPN - OpenVPN Management Library for eduVPN (and beyond)

    Copyright: 2017-2019 The Commons Conservancy eduVPN Programme
    SPDX-License-Identifier: GPL-3.0+
*/

using System;
using System.Diagnostics;
using System.Security;

namespace eduOpenVPN.Management
{
    /// <summary>
    /// <see cref="Session.AuthenticationTokenReported"/> event arguments
    /// </summary>
    public class AuthenticationTokenReportedEventArgs : EventArgs, IDisposable
    {
        #region Properties

        /// <summary>
        /// Authentication token
        /// </summary>
        public SecureString Token { get => _token; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SecureString _token;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs an event arguments
        /// </summary>
        /// <param name="token">Authentication token</param>
        public AuthenticationTokenReportedEventArgs(SecureString token)
        {
            _token = token;
        }

        #endregion

        #region IDisposable Support
        /// <summary>
        /// Flag to detect redundant <see cref="Dispose(bool)"/> calls.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposedValue = false;

        /// <summary>
        /// Called to dispose the object.
        /// </summary>
        /// <param name="disposing">Dispose managed objects</param>
        /// <remarks>
        /// To release resources for inherited classes, override this method.
        /// Call <c>base.Dispose(disposing)</c> within it to release parent class resources, and release child class resources if <paramref name="disposing"/> parameter is <c>true</c>.
        /// This method can get called multiple times for the same object instance. When the child specific resources should be released only once, introduce a flag to detect redundant calls.
        /// </remarks>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_token != null)
                        _token.Dispose();
                }

                disposedValue = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting resources.
        /// </summary>
        /// <remarks>
        /// This method calls <see cref="Dispose(bool)"/> with <c>disposing</c> parameter set to <c>true</c>.
        /// To implement resource releasing override the <see cref="Dispose(bool)"/> method.
        /// </remarks>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
