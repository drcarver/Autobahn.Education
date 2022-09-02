//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDataCollectionStatusEntity.g.cs
//* Name:       Data Collection Status
//* Definition: A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
//***************************************************************************

/// <summary>
/// Data Collection Status <see cref="RefDataCollectionStatus"/>
/// <para>
/// A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20926">Data Collection Status</a>
/// </para>
/// </summary>
[Table("RefDataCollectionStatus", Schema = "Common")]
[Comment("A process indicator of the level of stability, quality, and/or preparedness of the collection of data.")]
public partial class RefDataCollectionStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
