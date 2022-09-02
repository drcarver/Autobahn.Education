//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefExitOrWithdrawalStatusEntity.g.cs
//* Name:       Exit or Withdrawal Status
//* Definition: An indication as to whether an instance of student exit/withdrawal is considered to be of a permanent or temporary nature.
//***************************************************************************

/// <summary>
/// Exit or Withdrawal Status <see cref="RefExitOrWithdrawalStatus"/>
/// <para>
/// An indication as to whether an instance of student exit/withdrawal is considered to be of a permanent or temporary nature.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19108">Exit or Withdrawal Status</a>
/// </para>
/// </summary>
[Table("RefExitOrWithdrawalStatus", Schema = "Common")]
[Comment("An indication as to whether an instance of student exit/withdrawal is considered to be of a permanent or temporary nature.")]
public partial class RefExitOrWithdrawalStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
