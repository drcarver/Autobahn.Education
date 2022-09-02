//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAdmittedStudentEntity.g.cs
//* Name:       Admitted Student
//* Definition: Applicant who has been granted an official offer to enroll in a postsecondary institution. Admitted applicants should include wait-listed students who were subsequently offered admission.
//***************************************************************************

/// <summary>
/// Admitted Student <see cref="RefAdmittedStudent"/>
/// <para>
/// Applicant who has been granted an official offer to enroll in a postsecondary institution. Admitted applicants should include wait-listed students who were subsequently offered admission.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19736">Admitted Student</a>
/// </para>
/// </summary>
[Table("RefAdmittedStudent", Schema = "Common")]
[Comment("Applicant who has been granted an official offer to enroll in a postsecondary institution. Admitted applicants should include wait-listed students who were subsequently offered admission.")]
public partial class RefAdmittedStudentEntity : ReferenceBaseEntity, IReferenceBase
{
}
