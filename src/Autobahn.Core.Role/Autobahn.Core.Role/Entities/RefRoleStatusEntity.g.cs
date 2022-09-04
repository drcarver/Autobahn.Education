//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefRoleStatusEntity.g.cs
//* Name:       Enrollment Status
//* Definition: An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
//***************************************************************************

/// <summary>
/// Enrollment Status <see cref="RefRoleStatus"/>
/// <para>
/// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
/// </para>
/// </summary>
[Table("RefRoleStatus", Schema = "Autobahn.Core.Role")]
[Comment("An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.")]
public partial class RefRoleStatusEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefRoleStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
    /// </summary>
    [ForeignKey("RefRoleStatusType")]
    public Guid? RefRoleStatusTypeId { get; set; }

    #endregion
}
