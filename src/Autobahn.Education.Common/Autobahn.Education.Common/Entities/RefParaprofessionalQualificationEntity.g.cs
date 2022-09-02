//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefParaprofessionalQualificationEntity.g.cs
//* Name:       Paraprofessional Qualification Status
//* Definition: An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
//***************************************************************************

/// <summary>
/// Paraprofessional Qualification Status <see cref="RefParaprofessionalQualification"/>
/// <para>
/// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
/// </para>
/// </summary>
[Table("RefParaprofessionalQualification", Schema = "Common")]
[Comment("An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.")]
public partial class RefParaprofessionalQualificationEntity : ReferenceBaseEntity, IReferenceBase
{
}
