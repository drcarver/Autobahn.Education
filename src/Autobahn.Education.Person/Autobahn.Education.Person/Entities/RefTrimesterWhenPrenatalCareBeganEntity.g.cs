//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefTrimesterWhenPrenatalCareBeganEntity.g.cs
//* Name:       Trimester When Prenatal Care Began
//* Definition: The trimester of pregnancy in which a child's mother began receiving prenatal health care.
//***************************************************************************

/// <summary>
/// Trimester When Prenatal Care Began <see cref="RefTrimesterWhenPrenatalCareBegan"/>
/// <para>
/// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
/// </para>
/// </summary>
[Table("RefTrimesterWhenPrenatalCareBegan", Schema = "Person")]
[Comment("The trimester of pregnancy in which a child's mother began receiving prenatal health care.")]
public partial class RefTrimesterWhenPrenatalCareBeganEntity : ReferenceBaseEntity, IReferenceBase
{
}
