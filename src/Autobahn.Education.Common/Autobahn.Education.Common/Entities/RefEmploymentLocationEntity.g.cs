//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEmploymentLocationEntity.g.cs
//* Name:       Employment Location
//* Definition: The state or other location in which an individual is found employed.
//***************************************************************************

/// <summary>
/// Employment Location <see cref="RefEmploymentLocation"/>
/// <para>
/// The state or other location in which an individual is found employed.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19992">Employment Location</a>
/// </para>
/// </summary>
[Table("RefEmploymentLocation", Schema = "Common")]
[Comment("The state or other location in which an individual is found employed.")]
public partial class RefEmploymentLocationEntity : ReferenceBaseEntity, IReferenceBase
{
}
