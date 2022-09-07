//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefPsStudentLevelEntity.g.cs
//* Name:       Student Level
//* Definition: Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.
//***************************************************************************

/// <summary>
/// Student Level <see cref="RefPsStudentLevel"/>
/// <para>
/// Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19272">Student Level</a>
/// </para>
/// </summary>
[Table("RefPsStudentLevel", Schema = "EarlyLearning")]
[Comment("Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.")]
public partial class RefPsStudentLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}
