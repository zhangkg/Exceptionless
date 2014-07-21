﻿using System;
using System.Diagnostics;

namespace Exceptionless.Models {
    [DebuggerDisplay("{Id}, {Date}")]
    public class PersistentEvent : Event, IOwnedByOrganization, IOwnedByProject, IOwnedByStack, IIdentity {
        /// <summary>
        /// Unique id that identifies an event.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The organization that the event belongs to.
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// The project that the event belongs to.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// The stack that the event belongs to.
        /// </summary>
        public string StackId { get; set; }

        /// <summary>
        /// The event summary html.
        /// </summary>
        public string SummaryHtml { get; set; }

        /// <summary>
        /// Wether the error has been marked as fixed or not.
        /// </summary>
        public bool IsFixed { get; set; }

        /// <summary>
        /// Wether the error has been marked as hidden or not.
        /// </summary>
        public bool IsHidden { get; set; }
    }
}
