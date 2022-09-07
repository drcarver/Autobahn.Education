//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IStaffEvaluationPart.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluationPart file
/// </summary>
public partial interface IStaffEvaluationPart
{
    #region "IStaffEvaluationPart Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Part Name
    /// <para>
    /// The name of the component part that is being evaluated and scored.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20965">Staff Evaluation Part Name</a>
    /// </para>
    /// </summary>
    System.String PartName { get; set; }

    /// <summary>
    /// Staff Evaluation Part Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20966">Staff Evaluation Part Scale</a>
    /// </para>
    /// </summary>
    System.String Scale { get; set; }

    /// <summary>
    /// Staff Evaluation Part Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20967">Staff Evaluation Part Score or Rating</a>
    /// </para>
    /// </summary>
    System.String ScoreOrRating { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> model
    /// </summary>
    Guid? StaffEvaluationId { get; set; }

    #endregion
}
