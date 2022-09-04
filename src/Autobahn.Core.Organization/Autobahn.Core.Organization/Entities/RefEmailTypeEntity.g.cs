//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefEmailTypeEntity.g.cs
//* Name:       Electronic Mail Address Type
//* Definition: The type of electronic mail (e-mail) address listed for a person or organization.
//***************************************************************************

/// <summary>
/// Electronic Mail Address Type <see cref="RefEmailType"/>
/// <para>
/// The type of electronic mail (e-mail) address listed for a person or organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
/// </para>
/// </summary>
[Table("RefEmailType", Schema = "Autobahn.Core.Organization")]
[Comment("The type of electronic mail (e-mail) address listed for a person or organization.")]
public partial class RefEmailTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
