using System;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Event, as received from JSON API.
    /// </summary>
    public class JsonEvent {

        /// <summary>
        /// Event name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date and time of event creation
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Text of the event
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Attributes of objects related to the event
        /// </summary>
        public JsonRelatedObject[] RelatedObjects { get; set; }

        /// <summary>
        /// User details
        /// </summary>
        public JsonUser User { get; set; }

        /// <summary>
        /// Parameters with details about event, specific for each type of event
        /// </summary>
        public object Params { get; set; }

        /// <summary>
        /// Represents an object related to the event.
        /// </summary>
        public class JsonRelatedObject {

            /// <summary>
            /// Type of the object related to the event
            /// Values: Invoice, Subject, Expense, Generator, RecurringGenerator, ExpenseGenerator, Estimate
            /// </summary>
            public string Type { get; set; }

            /// <summary>
            /// ID of the object related to event
            /// </summary>
            public int Id { get; set; }
        }

        /// <summary>
        /// Represents a user associated with the event.
        /// </summary>
        public class JsonUser {

            /// <summary>
            /// User ID
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Full user name
            /// </summary>
            public string FullName { get; set; }

            /// <summary>
            /// Avatar URL
            /// </summary>
            public string Avatar { get; set; }

        }

    }
}