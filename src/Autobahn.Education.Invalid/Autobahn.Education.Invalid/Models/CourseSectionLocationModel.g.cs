//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionLocation file
/// </summary>
public partial class CourseSectionLocationModel : AutobahnBaseModel, ICourseSectionLocation
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
    public Guid ClassroomId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
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
    public Guid? RefInstructionLocationTypeId { get; set; }

    #endregion
}
