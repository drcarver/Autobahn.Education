//***************************************************************************
//* DomainName: Common Models
//* FileName:   ClassroomEntity.g.cs
//***************************************************************************

/// <summary>
/// The IClassroom file
/// </summary>
[Table("Classroom", Schema = "Common")]
public partial class ClassroomEntity : EntityBase, IClassroom
{
    #region "IClassroom Properties"
    /// <summary>
    /// Classroom Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.")]
    public System.String ClassroomIdentifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual LocationEntity LocationEntity { get; set; }

    #endregion
}
