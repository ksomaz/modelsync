using System;

namespace UmbrellaFrame.ModelSync.Core
{
    /// <summary>
    /// Options used to explicitly allow operations that may cause data loss.
    /// </summary>
    public sealed class DestructiveOperationOptions
    {
        /// <summary>
        /// When <c>true</c>, destructive operations such as DROP TABLE, DROP COLUMN,
        /// and ALTER COLUMN TYPE are allowed to execute.
        /// </summary>
        public bool AllowDestructiveChanges { get; set; }

        /// <summary>
        /// Creates options that allow destructive schema changes.
        /// </summary>
        public static DestructiveOperationOptions Allow()
            => new DestructiveOperationOptions { AllowDestructiveChanges = true };
    }
}
