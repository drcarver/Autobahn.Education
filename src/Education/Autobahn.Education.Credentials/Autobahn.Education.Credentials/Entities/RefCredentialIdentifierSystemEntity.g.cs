//***************************************************************************
//* DomainName: Credentials
//* FileName:   RefCredentialIdentifierSystemEntity.g.cs
//* Name:       Credential Definition Identifier System
//* Definition: A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
//***************************************************************************

/// <summary>
/// Credential Definition Identifier System <see cref="RefCredentialIdentifierSystem"/>
/// <para>
/// A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20720">Credential Definition Identifier System</a>
/// </para>
/// </summary>
[Table("RefCredentialIdentifierSystem", Schema = "Credentials")]
[Comment("A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.")]
public partial class RefCredentialIdentifierSystemEntity : ReferenceBaseEntity, IReferenceBase
{
}
