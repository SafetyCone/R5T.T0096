using System;

using R5T.T0092;

using INamedIdentifiedOperator = R5T.T0096.INamedIdentifiedOperator;


namespace System
{
    public static class INamedIdentifiedOperatorExtensions
    {
        public static string GetRepresentation(this INamedIdentifiedOperator _,
            INamedIdentified namedIdentified)
        {
            var output = $"{namedIdentified.Name} ({namedIdentified.Identity})";
            return output;
        }
    }
}