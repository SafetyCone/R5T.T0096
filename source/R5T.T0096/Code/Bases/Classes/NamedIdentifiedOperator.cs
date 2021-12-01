using System;


namespace R5T.T0096
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamedIdentifiedOperator : INamedIdentifiedOperator
    {
        #region Static
        
        public static NamedIdentifiedOperator Instance { get; } = new();

        #endregion
    }
}