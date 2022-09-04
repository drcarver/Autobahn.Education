//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefLicenseExemptEntity.g.cs
//* Name:       License Exempt
//* Definition: The program or center is legally exempt from licensing.
//***************************************************************************

/// <summary>
/// License Exempt <see cref="RefLicenseExempt"/>
/// <para>
/// The program or center is legally exempt from licensing.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19349">License Exempt</a>
/// </para>
/// </summary>
[Table("RefLicenseExempt", Schema = "Invalid")]
[Comment("The program or center is legally exempt from licensing.")]
public partial class RefLicenseExemptEntity : ReferenceBaseEntity, IReferenceBase
{
}
