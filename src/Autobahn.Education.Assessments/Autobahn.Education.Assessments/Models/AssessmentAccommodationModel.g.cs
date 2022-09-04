//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAccommodation file
/// </summary>
public partial class AssessmentAccommodationModel : AutobahnBaseModel, IAssessmentAccommodation
{
    #region "IAssessmentAccommodation Properties"
    /// <summary>
    /// Accommodation Other Description
    /// <para>
    /// The description of the accommodation when 'Accommodation Type' is set to 'Other'.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20116">Accommodation Other Description</a>
    /// </para>
    /// </summary>
    public System.String OtherDescription { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAccommodationTypeId { get; set; }

    /// <summary>
    /// Assessment Accommodation Category
    /// <para>
    /// A category of accommodations needed for a given assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentAccommodationCategoryId { get; set; }

    #endregion
}
