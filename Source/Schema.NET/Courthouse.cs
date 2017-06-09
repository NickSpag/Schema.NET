namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A courthouse.
    /// </summary>
    [DataContract]
    public class Courthouse : GovernmentBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Courthouse";
    }
}