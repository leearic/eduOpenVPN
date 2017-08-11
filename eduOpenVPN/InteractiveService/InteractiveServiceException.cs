﻿/*
eduOpenVPN - An OpenVPN Client for eduVPN (and beyond)

Copyright: 2017, The Commons Conservancy eduVPN Programme
SPDX-License-Identifier: GPL-3.0+
*/

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace eduOpenVPN.InteractiveService
{
    /// <summary>
    /// OpenVPN Interactive Service returned an error.
    /// </summary>
    [Serializable]
    public class InteractiveServiceException : ApplicationException, ISerializable
    {
        #region Properties

        /// <summary>
        /// The error message
        /// </summary>
        public override string Message
        {
            get
            {
                string msg;
                msg = String.Format(Resources.Strings.ErrorInteractiveService, String.Format("0x{0:X}", ErrorNumber), Function);

                if (base.Message != null)
                    msg = msg != null ? String.Format("{0}\n{1}", msg, base.Message) : base.Message;

                return msg;
            }
        }

        /// <summary>
        /// Error number
        /// </summary>
        public uint ErrorNumber { get; }

        /// <summary>
        /// The function that failed
        /// </summary>
        public string Function { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an exception
        /// </summary>
        /// <param name="error_num">Error number</param>
        /// <param name="function">The function that failed</param>
        /// <param name="error_description">Human-readable text providing additional information</param>
        public InteractiveServiceException(uint error_num, string function, string error_description) :
            base(error_description)
        {
            ErrorNumber = error_num;
            Function = function;
        }

        #endregion

        #region ISerializable Support

        protected InteractiveServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ErrorNumber = (uint)info.GetValue("ErrorNumber", typeof(uint));
            Function = (string)info.GetValue("Function", typeof(string));
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ErrorNumber", ErrorNumber);
            info.AddValue("Function", Function);
        }

        #endregion
    }
}