namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    [DataContract]
    public class BuddhistTemple : PlaceOfWorship
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BuddhistTemple";
    }
}