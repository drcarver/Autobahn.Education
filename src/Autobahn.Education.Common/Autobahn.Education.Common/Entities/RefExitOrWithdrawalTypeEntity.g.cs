//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefExitOrWithdrawalTypeEntity.g.cs
//* Name:       Exit or Withdrawal Type
//* Definition: The circumstances under which the student exited from membership in an educational institution. 
//***************************************************************************

/// <summary>
/// Exit or Withdrawal Type <see cref="RefExitOrWithdrawalType"/>
/// <para>
/// The circumstances under which the student exited from membership in an educational institution. 
/// </para>
/// <para>
/// <a href="">Exit or Withdrawal Type</a>
/// </para>
/// </summary>
[Table("RefExitOrWithdrawalType", Schema = "Common")]
[Comment("The circumstances under which the student exited from membership in an educational institution. ")]
public partial class RefExitOrWithdrawalTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
