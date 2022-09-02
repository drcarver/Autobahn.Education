//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefStandardizedAdmissionTestEntity.g.cs
//* Name:       Standardized Admission Test Type
//* Definition: The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
//***************************************************************************

/// <summary>
/// Standardized Admission Test Type <see cref="RefStandardizedAdmissionTest"/>
/// <para>
/// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
/// </para>
/// </summary>
[Table("RefStandardizedAdmissionTest", Schema = "Common")]
[Comment("The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.")]
public partial class RefStandardizedAdmissionTestEntity : ReferenceBaseEntity, IReferenceBase
{
}
