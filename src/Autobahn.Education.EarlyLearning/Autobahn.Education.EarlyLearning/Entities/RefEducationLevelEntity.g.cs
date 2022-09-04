//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefEducationLevelEntity.g.cs
//* Name:       Highest Level of Education Completed
//* Definition: The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
//***************************************************************************

/// <summary>
/// Highest Level of Education Completed <see cref="RefEducationLevel"/>
/// <para>
/// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
/// </para>
/// </summary>
[Table("RefEducationLevel", Schema = "EarlyLearning")]
[Comment("The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).")]
public partial class RefEducationLevelEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEducationLevelType"/> model
    /// </summary>
    [ForeignKey("RefEducationLevelType")]
    public Guid? RefEducationLevelTypeId { get; set; }

    #endregion
}
