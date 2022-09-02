//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefGradeLevelEntity.g.cs
//* Name:       Entry Grade Level
//* Definition: The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
//***************************************************************************

/// <summary>
/// Entry Grade Level <see cref="RefGradeLevel"/>
/// <para>
/// The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19100">Entry Grade Level</a>
/// </para>
/// </summary>
[Table("RefGradeLevel", Schema = "Common")]
[Comment("The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.")]
public partial class RefGradeLevelEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefGradeLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelType"/> model
    /// </summary>
    [ForeignKey("RefGradeLevelType")]
    public Guid? RefGradeLevelTypeId { get; set; }

    #endregion
}
