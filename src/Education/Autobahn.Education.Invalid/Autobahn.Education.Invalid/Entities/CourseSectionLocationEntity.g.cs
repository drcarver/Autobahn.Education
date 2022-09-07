//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionLocation file
/// </summary>
[Table("CourseSectionLocation", Schema = "Invalid")]
public partial class CourseSectionLocationEntity : EntityBase, ICourseSectionLocation
{
    #region "ICourseSectionLocation Properties"
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
    [ForeignKey("Classroom")]
    [Comment("A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.")]
    public Guid ClassroomId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CourseSection")]
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Receiving Location of Instruction
    /// <para>
    /// The type of location at which instruction or service takes place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19515">Receiving Location of Instruction</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInstructionLocationType")]
    [Comment("The type of location at which instruction or service takes place.")]
    public Guid? RefInstructionLocationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual ClassroomEntity ClassroomEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity CourseSectionEntity { get; set; }

    /// <summary>
    /// The type of location at which instruction or service takes place.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19515">Receiving Location of Instruction</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefInstructionLocationTypeEntity? RefInstructionLocationTypeEntity { get; set; }

    #endregion
}
