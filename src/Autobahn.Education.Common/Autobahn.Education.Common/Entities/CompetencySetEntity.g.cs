//***************************************************************************
//* DomainName: Common Models
//* FileName:   CompetencySetEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySet file
/// </summary>
[Table("CompetencySet", Schema = "Common")]
public partial class CompetencySetEntity : EntityBase, ICompetencySet
{
    #region "ICompetencySet Properties"
    public Int32? ChildOfCompetencySet { get; set; }

    /// <summary>
    /// Competency Set Completion Criteria Threshold
    /// <para>
    /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
    /// </para>
    /// </summary>
    [Comment("The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.")]
    public Int32? CompletionCriteriaThreshold { get; set; }

    /// <summary>
    /// Competency Set Completion Criteria
    /// <para>
    /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19877">Competency Set Completion Criteria</a>
    /// </para>
    /// </summary>
    [Obsolete("The RefCompletionCriteria property is obsolete and will be removed in a later version")]
    [ForeignKey("RefCompletionCriteria")]
    [Comment("The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.")]
    public Guid? RefCompletionCriteriaId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
