//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefHigherEducationInstitutionAccreditationStatusEntity.g.cs
//* Name:       Higher Education Institution Accreditation Status
//* Definition: An indication of the accreditation status of a higher education institution.
//***************************************************************************

/// <summary>
/// Higher Education Institution Accreditation Status <see cref="RefHigherEducationInstitutionAccreditationStatus"/>
/// <para>
/// An indication of the accreditation status of a higher education institution.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
/// </para>
/// </summary>
[Table("RefHigherEducationInstitutionAccreditationStatus", Schema = "Common")]
[Comment("An indication of the accreditation status of a higher education institution.")]
public partial class RefHigherEducationInstitutionAccreditationStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
