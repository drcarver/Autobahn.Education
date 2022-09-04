//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefPersonIdentificationSystemEntity.g.cs
//* Name:       Staff Member Identification System
//* Definition: A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.
//***************************************************************************

/// <summary>
/// Staff Member Identification System <see cref="RefPersonIdentificationSystem"/>
/// <para>
/// A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19162">Staff Member Identification System</a>
/// </para>
/// </summary>
[Table("RefPersonIdentificationSystem", Schema = "Autobahn.Core.Person")]
[Comment("A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.")]
public partial class RefPersonIdentificationSystemEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefPersonIdentificationSystem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPersonentifierType"/> model
    /// </summary>
    [ForeignKey("RefPersonentifierType")]
    public Guid? RefPersonIdentifierTypeId { get; set; }

    #endregion
}
