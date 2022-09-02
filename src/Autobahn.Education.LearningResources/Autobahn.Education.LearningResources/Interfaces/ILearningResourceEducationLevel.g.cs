//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourceEducationLevel.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceEducationLevel file
/// </summary>
public partial interface ILearningResourceEducationLevel
{
    #region "ILearningResourceEducationLevel Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Education Level�
    /// <para>
    /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
    /// </para>
    /// </summary>
    Guid RefEducationLevelId { get; set; }

    #endregion
}
