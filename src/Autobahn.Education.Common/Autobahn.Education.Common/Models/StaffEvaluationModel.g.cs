//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluation file
/// </summary>
public partial class StaffEvaluationModel : AutobahnBaseModel, IStaffEvaluation
{
    #region "IStaffEvaluation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Outcome
    /// <para>
    /// The result of an assessment of a person's performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19102">Staff Evaluation Outcome</a>
    /// </para>
    /// </summary>
    public System.String Outcome { get; set; }

    /// <summary>
    /// Faculty and Administration Performance Level
    /// <para>
    /// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
    /// </para>
    /// </summary>
    public Guid? RefStaffPerformanceLevelId { get; set; }

    /// <summary>
    /// Staff Evaluation Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's overall performance (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19103">Staff Evaluation Scale</a>
    /// </para>
    /// </summary>
    public System.String Scale { get; set; }

    /// <summary>
    /// Staff Evaluation Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's overall performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19104">Staff Evaluation Score or Rating</a>
    /// </para>
    /// </summary>
    public System.String ScoreOrRating { get; set; }

    /// <summary>
    /// Staff Evaluation System
    /// <para>
    /// The instrument and/or set of procedures with which a person's performance is assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19105">Staff Evaluation System</a>
    /// </para>
    /// </summary>
    public System.String System { get; set; }

    #endregion
}
