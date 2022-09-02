//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefInternetAccessEntity.g.cs
//* Name:       Internet Access
//* Definition: The type of internet access available.
//***************************************************************************

/// <summary>
/// Internet Access <see cref="RefInternetAccess"/>
/// <para>
/// The type of internet access available.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19580">Internet Access</a>
/// </para>
/// </summary>
[Table("RefInternetAccess", Schema = "Common")]
[Comment("The type of internet access available.")]
public partial class RefInternetAccessEntity : ReferenceBaseEntity, IReferenceBase
{
}
