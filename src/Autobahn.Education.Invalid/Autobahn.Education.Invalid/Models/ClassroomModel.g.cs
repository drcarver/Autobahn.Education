//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ClassroomEntity.g.cs
//***************************************************************************

/// <summary>
/// The IClassroom file
/// </summary>
public partial class ClassroomModel : AutobahnBaseModel, IClassroom
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
    public System.String ClassroomIdentifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    public Guid LocationId { get; set; }

    #endregion
}
