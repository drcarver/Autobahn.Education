//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProfessionalDevelopmentFinancialSupportEntity.g.cs
//* Name:       Professional Development Financial Support Type
//* Definition: The type of financial assistance received in support of non-credit professional development activities.
//***************************************************************************

/// <summary>
/// Professional Development Financial Support Type <see cref="RefProfessionalDevelopmentFinancialSupport"/>
/// <para>
/// The type of financial assistance received in support of non-credit professional development activities.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
/// </para>
/// </summary>
[Table("RefProfessionalDevelopmentFinancialSupport", Schema = "Common")]
[Comment("The type of financial assistance received in support of non-credit professional development activities.")]
public partial class RefProfessionalDevelopmentFinancialSupportEntity : ReferenceBaseEntity, IReferenceBase
{
}
