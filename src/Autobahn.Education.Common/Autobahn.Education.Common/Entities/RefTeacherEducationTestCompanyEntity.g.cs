//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTeacherEducationTestCompanyEntity.g.cs
//* Name:       Teacher Education Test Company
//* Definition: The name of the company that provides the examination used in the teacher education program.
//***************************************************************************

/// <summary>
/// Teacher Education Test Company <see cref="RefTeacherEducationTestCompany"/>
/// <para>
/// The name of the company that provides the examination used in the teacher education program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
/// </para>
/// </summary>
[Table("RefTeacherEducationTestCompany", Schema = "Common")]
[Comment("The name of the company that provides the examination used in the teacher education program.")]
public partial class RefTeacherEducationTestCompanyEntity : ReferenceBaseEntity, IReferenceBase
{
}
