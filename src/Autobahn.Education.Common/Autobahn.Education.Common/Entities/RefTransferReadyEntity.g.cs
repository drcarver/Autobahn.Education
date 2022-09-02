//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTransferReadyEntity.g.cs
//* Name:       Transfer-ready
//* Definition: A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.
//***************************************************************************

/// <summary>
/// Transfer-ready <see cref="RefTransferReady"/>
/// <para>
/// A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19296">Transfer-ready</a>
/// </para>
/// </summary>
[Table("RefTransferReady", Schema = "Common")]
[Comment("A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.")]
public partial class RefTransferReadyEntity : ReferenceBaseEntity, IReferenceBase
{
}
