﻿// <copyright file="UpdateNotificationDataEntity.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Data.Func.Services.NotificationDataServices
{
    using System;
    using Microsoft.Azure.Cosmos.Table;

    /// <summary>
    /// A subset of the full NotificationDataEntity setting fields as nullable in order to
    /// perform an update without needing to set the full object. Needed in order to not
    /// overwrite unset non-nullable values from the full NotificationDataEntity and remove
    /// unexpected data from the existing database row e.g. not setting TotalMessageCount for this
    /// entity will not result in the value being set to 0 in the database by mistake.
    /// </summary>
    public class UpdateNotificationDataEntity : TableEntity
    {
        /// <summary>
        /// Gets or sets the number of recipients who have received the notification successfully.
        /// </summary>
        public int? Succeeded { get; set; }

        /// <summary>
        /// Gets or sets the number of recipients who failed in receiving the notification.
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or sets the number of not found recipients.
        /// </summary>
        public int? RecipientNotFound { get; set; }

        /// <summary>
        /// Gets or sets the number of recipients who were throttled out.
        /// </summary>
        public int? Throttled { get; set; }

        /// <summary>
        /// Gets or sets the number or recipients who have an unknown status.
        /// </summary>
        public int? Unknown { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the notification is in the "preparing to send" state.
        /// </summary>
        public bool? IsPreparingToSend { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sending process is completed or not.
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the Sent DateTime value.
        /// </summary>
        public DateTime? SentDate { get; set; }
    }
}
