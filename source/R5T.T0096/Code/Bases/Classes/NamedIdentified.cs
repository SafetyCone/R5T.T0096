using System;


namespace R5T.T0096
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamedIdentified : INamedIdentified
    {
        #region Static
        
        public static NamedIdentified Instance { get; } = new();

        #endregion
    }
}