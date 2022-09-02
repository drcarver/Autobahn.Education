//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentNeedNumberOfBrailleDotEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefAssessmentNeedNumberOfBrailleDot file
/// </summary>
[Table("RefAssessmentNeedNumberOfBrailleDot", Schema = "Assessments")]
public partial class RefAssessmentNeedNumberOfBrailleDotEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefAssessmentNeedNumberOfBrailleDot Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefAssessmentNeedNumberOfBrailleDots property is obsolete and will be removed in a later version")]
    [ForeignKey("RefAssessmentNeedNumberOfBrailleDots")]
    public Guid RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

    #endregion
}
