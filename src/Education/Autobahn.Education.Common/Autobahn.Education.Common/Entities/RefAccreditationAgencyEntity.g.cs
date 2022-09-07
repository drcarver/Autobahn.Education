//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAccreditationAgencyEntity.g.cs
//* Name:       Accreditation Agency
//* Definition: The agency that accredited a program.
//***************************************************************************

/// <summary>
/// Accreditation Agency <see cref="RefAccreditationAgency"/>
/// <para>
/// The agency that accredited a program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
/// </para>
/// </summary>
[Table("RefAccreditationAgency", Schema = "Common")]
[Comment("The agency that accredited a program.")]
public partial class RefAccreditationAgencyEntity : ReferenceBaseEntity, IReferenceBase
{
}
