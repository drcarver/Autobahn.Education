//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentAccommodation.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAccommodation file
/// </summary>
public partial interface IAssessmentAccommodation
{
    #region "IAssessmentAccommodation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Accommodation Other Description
    /// <para>
    /// The description of the accommodation when 'Accommodation Type' is set to 'Other'.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20116">Accommodation Other Description</a>
    /// </para>
    /// </summary>
    System.String OtherDescription { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    Guid? RefAccommodationTypeId { get; set; }

    /// <summary>
    /// Assessment Accommodation Category
    /// <para>
    /// A category of accommodations needed for a given assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentAccommodationCategoryId { get; set; }

    #endregion
}
