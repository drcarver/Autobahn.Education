//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPersonalInformationTypeEntity.g.cs
//* Name:       Personal Information Type
//* Definition: The type of personal information verified through the Personal Information Verification evidence.
//***************************************************************************

/// <summary>
/// Personal Information Type <see cref="RefPersonalInformationType"/>
/// <para>
/// The type of personal information verified through the Personal Information Verification evidence.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
/// </para>
/// </summary>
[Table("RefPersonalInformationType", Schema = "Common")]
[Comment("The type of personal information verified through the Personal Information Verification evidence.")]
public partial class RefPersonalInformationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
