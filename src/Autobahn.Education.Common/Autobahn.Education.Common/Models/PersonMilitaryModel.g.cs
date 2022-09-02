//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonMilitary file
/// </summary>
public partial class PersonMilitaryModel : AutobahnBaseModel, IPersonMilitary
{
    #region "IPersonMilitary Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Military Active Student Indicator
    /// <para>
    /// An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20556">Military Active Student Indicator</a>
    /// </para>
    /// </summary>
    public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

    /// <summary>
    /// Military Branch
    /// <para>
    /// A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20621">Military Branch</a>
    /// </para>
    /// </summary>
    public Guid? RefMilitaryBranchId { get; set; }

    /// <summary>
    /// Military Connected Student Indicator
    /// <para>
    /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20555">Military Connected Student Indicator</a>
    /// </para>
    /// </summary>
    public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

    /// <summary>
    /// Military Veteran Student Indicator
    /// <para>
    /// An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20557">Military Veteran Student Indicator</a>
    /// </para>
    /// </summary>
    public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

    #endregion
}
